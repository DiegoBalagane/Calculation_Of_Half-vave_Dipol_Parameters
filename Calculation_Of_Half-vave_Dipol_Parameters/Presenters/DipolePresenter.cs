using Calculation_Of_Half_vave_Dipol_Parameters.Models;
using Calculation_Of_Half_vave_Dipol_Parameters.Services;
using Calculation_Of_Half_vave_Dipol_Parameters.Views;

namespace Calculation_Of_Half_vave_Dipol_Parameters.Presenters
{
	public class DipolePresenter
	{
		IDipoleParameters dipoleParametersView;

		public DipolePresenter(IDipoleParameters dipoleParametersView)
		{
			this.dipoleParametersView = dipoleParametersView;
		}

		private void CountOtherParameters(DipoleParameters parameters)
		{
			var service = new DipoleParametersService();
			parameters.WaveLength = service.CountWaveLength(parameters.Frequency);
			parameters.InputImpedance = service.CountInputImpedance(parameters);
			parameters.Slightness = service.CountSlightness(parameters.Length, parameters.Radius);
		}

		public void Calculate()
		{
			dipoleParametersView.FrequencyValidator = false;
			dipoleParametersView.LengthValidator = false;
			dipoleParametersView.RadiusValidator = false;
			dipoleParametersView.QuantityValidator = false;
			dipoleParametersView.SupplyPointValidator = false;

			var frequencyResult = double.TryParse(dipoleParametersView.FrequencyText, out var frequency);
			var lengthResult = double.TryParse(dipoleParametersView.LengthText, out var length);
			var radiusResult = double.TryParse(dipoleParametersView.RadiusText, out var radius);
			var quantityResult = int.TryParse(dipoleParametersView.QuantityOfPartsText, out var quantity);
			var supplyPointResult = int.TryParse(dipoleParametersView.SupplyPointText, out var supplyPoint);
			
			if (frequencyResult && lengthResult && radiusResult && quantityResult && supplyPointResult
				&& IsQuantityCorrect(quantity) && IsSupplyPointCorrect(quantity, supplyPoint))
			{
				DipoleParameters dipoleParameters = new DipoleParameters();
				dipoleParameters.Frequency = frequency;
				dipoleParameters.Length = length;
				dipoleParameters.Radius = radius;
				dipoleParameters.QuantityOfParts = quantity;
				dipoleParameters.SupplyPoint = supplyPoint;

				CountOtherParameters(dipoleParameters);

				if(dipoleParameters.InputImpedance.Imaginary > 0)
				{
					dipoleParametersView.InputImpedanceText =
					Math.Round(dipoleParameters.InputImpedance.Real, 2).ToString()
					+ " + "
					+ Math.Round(dipoleParameters.InputImpedance.Imaginary, 2).ToString()
					+ " j";
				}
				else
				{
					dipoleParametersView.InputImpedanceText =
					Math.Round(dipoleParameters.InputImpedance.Real, 2).ToString()
					+ " - "
					+ Math.Round(Math.Abs(dipoleParameters.InputImpedance.Imaginary), 2).ToString()
					+ " j";
				}
				dipoleParametersView.WaveLengthText = dipoleParameters.WaveLength.ToString();
				dipoleParametersView.SlightnessText = dipoleParameters.Slightness.ToString();
			}
			else
			{
				if (!frequencyResult)
					dipoleParametersView.FrequencyValidator = true;
				if (!lengthResult)
					dipoleParametersView.LengthValidator = true;
				if (!radiusResult)
					dipoleParametersView.RadiusValidator = true;
				if (!quantityResult || !IsQuantityCorrect(quantity))
					dipoleParametersView.QuantityValidator = true;
				if (!supplyPointResult || !IsSupplyPointCorrect(quantity, supplyPoint))
					dipoleParametersView.SupplyPointValidator = true;

				dipoleParametersView.InputImpedanceText = "Nieprawidłowe dane";
				dipoleParametersView.WaveLengthText = "Nieprawidłowe dane";
				dipoleParametersView.SlightnessText = "Nieprawidłowe dane";
			}
		}

		private bool IsSupplyPointCorrect(int quantity, int supplyPoint)
		{
			if (supplyPoint > 0 && supplyPoint <= quantity)
				return true;
			return false;
		}

		private bool IsQuantityCorrect(int quantity)
		{
			if (quantity > 0 && quantity <= 10)
				return true;
			return false;
		}
	}
}
