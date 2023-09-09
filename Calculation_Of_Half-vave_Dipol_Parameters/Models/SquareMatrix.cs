using System.Numerics;

namespace Calculation_Of_Half_vave_Dipol_Parameters.Models
{
	public class SquareMatrix
	{
		public SquareMatrix(int m)
		{
			Data = new Complex[m][];
			for (int i = 0; i < m; i++)
				Data[i] = new Complex[m];

			for (int i = 0; i < m; i++)
				for(int j = 0; j < m; j++)
					Data[i][j] = new Complex(0, 0);
		}

		public Complex[][] Data { get; set; }
		public int Length { get { return Data.GetLength(0); } }
	}
}
