using Calculation_Of_Half_vave_Dipol_Parameters.Windows.Forms;

namespace Calculation_Of_Half_vave_Dipol_Parameters.CalculationOfHalfvaveDipolParameters
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new DipoleParametersWindow());
		}
	}
}