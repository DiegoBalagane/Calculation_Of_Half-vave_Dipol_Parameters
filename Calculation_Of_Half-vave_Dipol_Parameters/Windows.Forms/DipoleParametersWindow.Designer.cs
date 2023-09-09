namespace Calculation_Of_Half_vave_Dipol_Parameters.Windows.Forms
{
	partial class DipoleParametersWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.frequencyLabel = new System.Windows.Forms.Label();
			this.lengthLabel = new System.Windows.Forms.Label();
			this.radiusLabel = new System.Windows.Forms.Label();
			this.quantityOfPartsLabel = new System.Windows.Forms.Label();
			this.supplyPointLabel = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.frequencyTextBox = new System.Windows.Forms.TextBox();
			this.lengthTextBox = new System.Windows.Forms.TextBox();
			this.radiusTextBox = new System.Windows.Forms.TextBox();
			this.quantityOfPartsTextBox = new System.Windows.Forms.TextBox();
			this.supplyPointTextBox = new System.Windows.Forms.TextBox();
			this.inputImpedanceLabel = new System.Windows.Forms.Label();
			this.inputImpedanceValueLabel = new System.Windows.Forms.Label();
			this.waveLengthLabel = new System.Windows.Forms.Label();
			this.waveLengthValueLabel = new System.Windows.Forms.Label();
			this.frequencyWrongData = new System.Windows.Forms.Label();
			this.lengthWrongData = new System.Windows.Forms.Label();
			this.radiusWrongData = new System.Windows.Forms.Label();
			this.quantityWrongData = new System.Windows.Forms.Label();
			this.supplyPointWrongData = new System.Windows.Forms.Label();
			this.slightnessLabel = new System.Windows.Forms.Label();
			this.slightnessValueLabel = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// frequencyLabel
			// 
			this.frequencyLabel.AutoSize = true;
			this.frequencyLabel.Location = new System.Drawing.Point(27, 24);
			this.frequencyLabel.Name = "frequencyLabel";
			this.frequencyLabel.Size = new System.Drawing.Size(159, 20);
			this.frequencyLabel.TabIndex = 0;
			this.frequencyLabel.Text = "Częstotliwość [w MHz]";
			// 
			// lengthLabel
			// 
			this.lengthLabel.AutoSize = true;
			this.lengthLabel.Location = new System.Drawing.Point(27, 71);
			this.lengthLabel.Name = "lengthLabel";
			this.lengthLabel.Size = new System.Drawing.Size(146, 20);
			this.lengthLabel.TabIndex = 1;
			this.lengthLabel.Text = "Długość [w metrach]";
			// 
			// radiusLabel
			// 
			this.radiusLabel.AutoSize = true;
			this.radiusLabel.Location = new System.Drawing.Point(27, 114);
			this.radiusLabel.Name = "radiusLabel";
			this.radiusLabel.Size = new System.Drawing.Size(147, 20);
			this.radiusLabel.TabIndex = 2;
			this.radiusLabel.Text = "Promień [w metrach]";
			// 
			// quantityOfPartsLabel
			// 
			this.quantityOfPartsLabel.AutoSize = true;
			this.quantityOfPartsLabel.Location = new System.Drawing.Point(27, 165);
			this.quantityOfPartsLabel.Name = "quantityOfPartsLabel";
			this.quantityOfPartsLabel.Size = new System.Drawing.Size(179, 20);
			this.quantityOfPartsLabel.TabIndex = 3;
			this.quantityOfPartsLabel.Text = "Ilośc części dipola (<=10)";
			// 
			// supplyPointLabel
			// 
			this.supplyPointLabel.AutoSize = true;
			this.supplyPointLabel.Location = new System.Drawing.Point(27, 204);
			this.supplyPointLabel.Name = "supplyPointLabel";
			this.supplyPointLabel.Size = new System.Drawing.Size(230, 20);
			this.supplyPointLabel.TabIndex = 4;
			this.supplyPointLabel.Text = "Część zawierająca mod zasilający";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(304, 279);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(94, 29);
			this.calculateButton.TabIndex = 5;
			this.calculateButton.Text = "Oblicz";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// frequencyTextBox
			// 
			this.frequencyTextBox.Location = new System.Drawing.Point(292, 24);
			this.frequencyTextBox.Name = "frequencyTextBox";
			this.frequencyTextBox.Size = new System.Drawing.Size(125, 27);
			this.frequencyTextBox.TabIndex = 6;
			// 
			// lengthTextBox
			// 
			this.lengthTextBox.Location = new System.Drawing.Point(292, 71);
			this.lengthTextBox.Name = "lengthTextBox";
			this.lengthTextBox.Size = new System.Drawing.Size(125, 27);
			this.lengthTextBox.TabIndex = 7;
			// 
			// radiusTextBox
			// 
			this.radiusTextBox.Location = new System.Drawing.Point(292, 114);
			this.radiusTextBox.Name = "radiusTextBox";
			this.radiusTextBox.Size = new System.Drawing.Size(125, 27);
			this.radiusTextBox.TabIndex = 8;
			// 
			// quantityOfPartsTextBox
			// 
			this.quantityOfPartsTextBox.Location = new System.Drawing.Point(292, 165);
			this.quantityOfPartsTextBox.Name = "quantityOfPartsTextBox";
			this.quantityOfPartsTextBox.Size = new System.Drawing.Size(125, 27);
			this.quantityOfPartsTextBox.TabIndex = 9;
			// 
			// supplyPointTextBox
			// 
			this.supplyPointTextBox.Location = new System.Drawing.Point(292, 204);
			this.supplyPointTextBox.Name = "supplyPointTextBox";
			this.supplyPointTextBox.Size = new System.Drawing.Size(125, 27);
			this.supplyPointTextBox.TabIndex = 10;
			// 
			// inputImpedanceLabel
			// 
			this.inputImpedanceLabel.AutoSize = true;
			this.inputImpedanceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.inputImpedanceLabel.Location = new System.Drawing.Point(27, 353);
			this.inputImpedanceLabel.Name = "inputImpedanceLabel";
			this.inputImpedanceLabel.Size = new System.Drawing.Size(196, 20);
			this.inputImpedanceLabel.TabIndex = 11;
			this.inputImpedanceLabel.Text = "Impedancja wejściowa [Ω]:";
			// 
			// inputImpedanceValueLabel
			// 
			this.inputImpedanceValueLabel.Location = new System.Drawing.Point(229, 353);
			this.inputImpedanceValueLabel.Name = "inputImpedanceValueLabel";
			this.inputImpedanceValueLabel.Size = new System.Drawing.Size(379, 20);
			this.inputImpedanceValueLabel.TabIndex = 12;
			this.inputImpedanceValueLabel.Text = "brak";
			// 
			// waveLengthLabel
			// 
			this.waveLengthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.waveLengthLabel.Location = new System.Drawing.Point(27, 385);
			this.waveLengthLabel.Name = "waveLengthLabel";
			this.waveLengthLabel.Size = new System.Drawing.Size(196, 20);
			this.waveLengthLabel.TabIndex = 13;
			this.waveLengthLabel.Text = "Długość fali [m]:";
			// 
			// waveLengthValueLabel
			// 
			this.waveLengthValueLabel.Location = new System.Drawing.Point(229, 385);
			this.waveLengthValueLabel.Name = "waveLengthValueLabel";
			this.waveLengthValueLabel.Size = new System.Drawing.Size(379, 20);
			this.waveLengthValueLabel.TabIndex = 14;
			this.waveLengthValueLabel.Text = "brak";
			// 
			// frequencyWrongData
			// 
			this.frequencyWrongData.AutoSize = true;
			this.frequencyWrongData.Location = new System.Drawing.Point(461, 31);
			this.frequencyWrongData.Name = "frequencyWrongData";
			this.frequencyWrongData.Size = new System.Drawing.Size(147, 20);
			this.frequencyWrongData.TabIndex = 15;
			this.frequencyWrongData.Text = "Nieprawidłowe dane";
			this.frequencyWrongData.Visible = false;
			// 
			// lengthWrongData
			// 
			this.lengthWrongData.AutoSize = true;
			this.lengthWrongData.Location = new System.Drawing.Point(461, 78);
			this.lengthWrongData.Name = "lengthWrongData";
			this.lengthWrongData.Size = new System.Drawing.Size(147, 20);
			this.lengthWrongData.TabIndex = 16;
			this.lengthWrongData.Text = "Nieprawidłowe dane";
			this.lengthWrongData.Visible = false;
			// 
			// radiusWrongData
			// 
			this.radiusWrongData.AutoSize = true;
			this.radiusWrongData.Location = new System.Drawing.Point(461, 121);
			this.radiusWrongData.Name = "radiusWrongData";
			this.radiusWrongData.Size = new System.Drawing.Size(147, 20);
			this.radiusWrongData.TabIndex = 17;
			this.radiusWrongData.Text = "Nieprawidłowe dane";
			this.radiusWrongData.Visible = false;
			// 
			// quantityWrongData
			// 
			this.quantityWrongData.AutoSize = true;
			this.quantityWrongData.Location = new System.Drawing.Point(461, 172);
			this.quantityWrongData.Name = "quantityWrongData";
			this.quantityWrongData.Size = new System.Drawing.Size(147, 20);
			this.quantityWrongData.TabIndex = 18;
			this.quantityWrongData.Text = "Nieprawidłowe dane";
			this.quantityWrongData.Visible = false;
			// 
			// supplyPointWrongData
			// 
			this.supplyPointWrongData.AutoSize = true;
			this.supplyPointWrongData.Location = new System.Drawing.Point(461, 211);
			this.supplyPointWrongData.Name = "supplyPointWrongData";
			this.supplyPointWrongData.Size = new System.Drawing.Size(147, 20);
			this.supplyPointWrongData.TabIndex = 19;
			this.supplyPointWrongData.Text = "Nieprawidłowe dane";
			this.supplyPointWrongData.Visible = false;
			// 
			// slightnessLabel
			// 
			this.slightnessLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.slightnessLabel.Location = new System.Drawing.Point(27, 416);
			this.slightnessLabel.Name = "slightnessLabel";
			this.slightnessLabel.Size = new System.Drawing.Size(196, 20);
			this.slightnessLabel.TabIndex = 20;
			this.slightnessLabel.Text = "Współczynnik smukłości:";
			// 
			// slightnessValueLabel
			// 
			this.slightnessValueLabel.Location = new System.Drawing.Point(229, 416);
			this.slightnessValueLabel.Name = "slightnessValueLabel";
			this.slightnessValueLabel.Size = new System.Drawing.Size(379, 20);
			this.slightnessValueLabel.TabIndex = 21;
			this.slightnessValueLabel.Text = "brak";
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.resultLabel.Location = new System.Drawing.Point(27, 309);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(132, 35);
			this.resultLabel.TabIndex = 22;
			this.resultLabel.Text = "Parametry:";
			// 
			// DipoleParametersWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(613, 450);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.slightnessValueLabel);
			this.Controls.Add(this.slightnessLabel);
			this.Controls.Add(this.supplyPointWrongData);
			this.Controls.Add(this.quantityWrongData);
			this.Controls.Add(this.radiusWrongData);
			this.Controls.Add(this.lengthWrongData);
			this.Controls.Add(this.frequencyWrongData);
			this.Controls.Add(this.waveLengthValueLabel);
			this.Controls.Add(this.waveLengthLabel);
			this.Controls.Add(this.inputImpedanceValueLabel);
			this.Controls.Add(this.inputImpedanceLabel);
			this.Controls.Add(this.supplyPointTextBox);
			this.Controls.Add(this.quantityOfPartsTextBox);
			this.Controls.Add(this.radiusTextBox);
			this.Controls.Add(this.lengthTextBox);
			this.Controls.Add(this.frequencyTextBox);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.supplyPointLabel);
			this.Controls.Add(this.quantityOfPartsLabel);
			this.Controls.Add(this.radiusLabel);
			this.Controls.Add(this.lengthLabel);
			this.Controls.Add(this.frequencyLabel);
			this.MaximizeBox = false;
			this.Name = "DipoleParametersWindow";
			this.Text = "Program obliczający parametry dipola półfalowego";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label frequencyLabel;
		private Label lengthLabel;
		private Label radiusLabel;
		private Label quantityOfPartsLabel;
		private Label supplyPointLabel;
		private Button calculateButton;
		private TextBox frequencyTextBox;
		private TextBox lengthTextBox;
		private TextBox radiusTextBox;
		private TextBox quantityOfPartsTextBox;
		private TextBox supplyPointTextBox;
		private Label inputImpedanceLabel;
		private Label inputImpedanceValueLabel;
		private Label waveLengthLabel;
		private Label waveLengthValueLabel;
		private Label frequencyWrongData;
		private Label lengthWrongData;
		private Label radiusWrongData;
		private Label quantityWrongData;
		private Label supplyPointWrongData;
		private Label slightnessLabel;
		private Label slightnessValueLabel;
		private Label resultLabel;
	}
}