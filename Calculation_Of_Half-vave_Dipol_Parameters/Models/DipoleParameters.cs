using System.Numerics;

namespace Calculation_Of_Half_vave_Dipol_Parameters.Models
{
	public class DipoleParameters
	{
		/// <summary>Częstotliwość dipola w MHz</summary>
		public double Frequency { get; set; }

		/// <summary>Długość dipola w m</summary>
		public double Length { get; set; }

		/// <summary>Promień dipola w m</summary>
		public double Radius { get; set; }

		/// <summary>Ilość części dipola (1 <= x <= 11)</summary>
		public int QuantityOfParts { get; set; }

		/// <summary>Numer modu zasilającego</summary>
		public int SupplyPoint { get; set; }

		/// <summary>Impedancja wejściowa</summary>
		public Complex InputImpedance { get; set; }

		/// <summary>Długość fali</summary>
		public double WaveLength { get; set; }

		/// <summary>Smukłość</summary>
		public double Slightness { get; set; }
	}
}
