using Calculation_Of_Half_vave_Dipol_Parameters.Models;
using System.Numerics;

namespace Calculation_Of_Half_vave_Dipol_Parameters.Services
{
	public class DipoleParametersService
	{
		public double CountWaveLength(double frequency)
		{
			return 300 / frequency;
		}

		public double CountSlightness(double length, double radius)
		{
			return length / (2 * radius);
		}

		public Complex CountInputImpedance(DipoleParameters parameters)
		{
			var impedanceMatrix = GetImpedanceMatrix(parameters);
			var lambda = parameters.WaveLength;
			var k0 = 2 * Math.PI / lambda;
			var k = k0 * Math.Sqrt(1 * 1);
			var deltaZ = parameters.Length / parameters.QuantityOfParts;
			var mianownik = (parameters.Frequency) / (18000);

			for (int i = 0; i < impedanceMatrix.Length; i++)
			{
				for (int j = 0; j < impedanceMatrix.Length; j++)
				{
					impedanceMatrix.Data[i][j] *=
						new Complex(0, deltaZ * 1 / mianownik);
				}
			}

			var service = new SquareMatrixService();
			var admittanceMatrix = service.MatrixInverse(impedanceMatrix);

			var voltageVector = new Complex[admittanceMatrix.Length][];
			for (int i = 0; i < admittanceMatrix.Length; i++)
				voltageVector[i] = new Complex[1];

			voltageVector[parameters.SupplyPoint - 1][0] = new Complex(1, 0);

			var currentVector = new Complex[admittanceMatrix.Length][];
			for (int i = 0; i < admittanceMatrix.Length; i++)
				currentVector[i] = new Complex[1];

			for (int i = 0; i < admittanceMatrix.Length; i++)
			{
				for (int j = 0; j < admittanceMatrix.Length; j++)
				{
					if(j == (parameters.SupplyPoint - 1))
						currentVector[i][0] += voltageVector[j][0] * admittanceMatrix.Data[i][j];
				}
			}

			var result = voltageVector[parameters.SupplyPoint - 1][0]/
			currentVector[parameters.SupplyPoint - 1][0];

			return result;
		}

		private SquareMatrix GetImpedanceMatrix(DipoleParameters parameters)
		{
			var matrix = new SquareMatrix(parameters.QuantityOfParts);
			var deltaZ = parameters.Length / parameters.QuantityOfParts;
			var lambda = parameters.WaveLength;
			var k0 = 2 * Math.PI / lambda;
			var k = k0 * Math.Sqrt(1 * 1);
			var diagonalTermReal = (1 / (4 * Math.PI))*Math.Log(
			(Math.Sqrt(1 + Math.Pow(2.0 * parameters.Radius / deltaZ, 2)) + 1)/
			(Math.Sqrt(1 + Math.Pow(2.0 * parameters.Radius / deltaZ, 2)) - 1));
			var diagonalTermImaginary = (-k * deltaZ) / (4 * Math.PI);
			var diagonalTerm = new Complex(diagonalTermReal, diagonalTermImaginary);

			for (int i = 0; i < parameters.QuantityOfParts; i++)
			{
				for (int j = 0; j < parameters.QuantityOfParts; j++)
				{
					var y1 = (i * deltaZ) - (j * deltaZ) + (deltaZ / 2);
					var y2 = (i * deltaZ) - (j * deltaZ) - (deltaZ / 2);
					var r1 = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(parameters.Radius, 2));
					var t1Real = (y1 * Math.Cos(k * r1) / Math.Pow(r1, 3))
						+ (Math.Sin(k * r1) * (k * r1 * y1) / Math.Pow(r1, 3));
					var t1Imaginary = ((k * r1 * y1) * Math.Cos(k * r1) / Math.Pow(r1, 3))
						- (Math.Sin(k * r1) * y1 / Math.Pow(r1, 3));
					var t1 = new Complex(t1Real, t1Imaginary);
					var r2 = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(parameters.Radius, 2));
					var t2Real = (y2 * Math.Cos(k * r2) / Math.Pow(r2, 3))
						+ (Math.Sin(k * r2) * (k * r2 * y2) / Math.Pow(r2, 3));
					var t2Imaginary = ((k * r2 * y2) * Math.Cos(k * r2) / Math.Pow(r2, 3))
						- (Math.Sin(k * r2) * y2 / Math.Pow(r2, 3));
					var t2 = new Complex(t2Real, t2Imaginary);

					if (t2.Real - t1.Real < 0)
						matrix.Data[i][j] = (Math.Pow(k, 2) * diagonalTerm) - (t2 - t1);
					else
						matrix.Data[i][j] = (Math.Pow(k, 2) * diagonalTerm) + (t2 - t1);
				}
			}

			return matrix;
		}
	}
}
