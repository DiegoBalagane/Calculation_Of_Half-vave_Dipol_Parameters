namespace Calculation_Of_Half_vave_Dipol_Parameters.Views
{
	public interface IDipoleParameters
	{
		string FrequencyText { get; set; }

		string LengthText { get; set; }

		string RadiusText { get; set; }

		string QuantityOfPartsText { get; set; }

		string SupplyPointText { get; set; }

		string InputImpedanceText { set; }

		string WaveLengthText { set; }

		string SlightnessText { set; }

		bool FrequencyValidator { set; }

		bool LengthValidator { set; }

		bool RadiusValidator { set; }

		bool QuantityValidator { set; }

		bool SupplyPointValidator { set; }
	}
}
