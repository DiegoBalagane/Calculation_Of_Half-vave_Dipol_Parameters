using Calculation_Of_Half_vave_Dipol_Parameters.Presenters;
using Calculation_Of_Half_vave_Dipol_Parameters.Views;

namespace Calculation_Of_Half_vave_Dipol_Parameters.Windows.Forms
{
	public partial class DipoleParametersWindow : Form, IDipoleParameters
	{
		public DipoleParametersWindow()
		{
			InitializeComponent();
		}

		public string FrequencyText
		{
			get
			{
				return frequencyTextBox.Text;
			}
			set
			{
				frequencyTextBox.Text = value;
			}
		}

		public string LengthText
		{
			get
			{
				return lengthTextBox.Text;
			}
			set
			{
				lengthTextBox.Text = value;
			}
		}

		public string RadiusText
		{
			get
			{
				return radiusTextBox.Text;
			}
			set
			{
				radiusTextBox.Text = value;
			}
		}

		public string QuantityOfPartsText
		{
			get
			{
				return quantityOfPartsTextBox.Text;
			}
			set
			{
				quantityOfPartsTextBox.Text = value;
			}
		}

		public string SupplyPointText
		{
			get
			{
				return supplyPointTextBox.Text;
			}
			set
			{
				supplyPointTextBox.Text = value;
			}
		}

		public string InputImpedanceText
		{
			set
			{
				inputImpedanceValueLabel.Text = value;
			}
		}

		public string WaveLengthText
		{
			set
			{
				waveLengthValueLabel.Text = value;
			}
		}

		public string SlightnessText
		{
			set
			{
				slightnessValueLabel.Text = value;
			}
		}

		public bool FrequencyValidator
		{
			set
			{
				frequencyWrongData.Visible = value;
			}
		}

		public bool LengthValidator
		{
			set
			{
				lengthWrongData.Visible = value;
			}
		}

		public bool RadiusValidator
		{
			set
			{
				radiusWrongData.Visible = value;
			}
		}

		public bool QuantityValidator
		{
			set
			{
				quantityWrongData.Visible = value;
			}
		}

		public bool SupplyPointValidator
		{
			set
			{
				supplyPointWrongData.Visible = value;
			}
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			DipolePresenter presenter = new DipolePresenter(this);
			presenter.Calculate();
		}
	}
}