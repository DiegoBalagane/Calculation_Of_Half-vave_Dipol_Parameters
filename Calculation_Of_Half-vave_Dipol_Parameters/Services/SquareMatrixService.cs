using Calculation_Of_Half_vave_Dipol_Parameters.Models;
using System.Numerics;

namespace Calculation_Of_Half_vave_Dipol_Parameters.Services
{
	public class SquareMatrixService
	{
        public SquareMatrix MatrixInverse(SquareMatrix matrix)
        {
            var n = matrix.Length;
            var result = new SquareMatrix(n);
            for (var i = 0; i < n; ++i)
                for (var j = 0; j < n; ++j)
                    result.Data[i][j] = matrix.Data[i][j];
            int[] perm;
            perm = MatrixDecompose(matrix, out var lum);

            Complex[] b = new Complex[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                    if (i == perm[j])
                        b[j] = new Complex(1, 0);
                    else
                        b[j] = new Complex(0, 0);

                Complex[] x = Helper(lum, b);
                for (int j = 0; j < n; ++j)
                    result.Data[j][i] = x[j];
            }

            for (var i = 0; i < n; ++i)
			{
                for (var j = 0; j < n; ++j)
				{
                    if (result.Data[i][j].Real < 0)
                        result.Data[i][j] *= -1;
                }
            }

            return result;
        }

        static int[] MatrixDecompose(SquareMatrix matrix, out SquareMatrix lum)
        {
            int n = matrix.Length;
            int[] perm;

            lum = new SquareMatrix(n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    lum.Data[i][j] = matrix.Data[i][j];

            perm = new int[n];
            for (int i = 0; i < n; ++i)
                perm[i] = i;

            for (int j = 0; j < n - 1; ++j)
            {
                var max = lum.Data[j][j];
                int piv = j;

                for (int i = j + 1; i < n; ++i)
                {
                    var xij = lum.Data[i][j];
                    if (Math.Abs(xij.Magnitude) > Math.Abs(max.Magnitude))
                    {
                        max = xij;
                        piv = i;
                    }
                }

                if (piv != j)
                {
                    var tmp = lum.Data[piv];
                    lum.Data[piv] = lum.Data[j];
                    lum.Data[j] = tmp;

                    int t = perm[piv];
                    perm[piv] = perm[j];
                    perm[j] = t;
                }

                var xjj = lum.Data[j][j];
                if (xjj.Magnitude != 0)
                {
                    for (int i = j + 1; i < n; ++i)
                    {
                        var xij = lum.Data[i][j] / xjj;
                        lum.Data[i][j] = xij;
                        for (int k = j + 1; k < n; ++k)
                            lum.Data[i][k] -= xij * lum.Data[j][k];
                    }
                }
            }
            return perm;
        }

        static Complex[] Helper(SquareMatrix luMatrix, Complex[] b)
        {
            var n = luMatrix.Length;
            var x = new Complex[n];
            b.CopyTo(x, 0);

            for (int i = 1; i < n; ++i)
            {
                var sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix.Data[i][j] * x[j];
                x[i] = sum;
            }

            x[n - 1] /= luMatrix.Data[n - 1][n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                var sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix.Data[i][j] * x[j];
                x[i] = sum  / luMatrix.Data[i][i];
            }

			return x;
        }
    }
}
