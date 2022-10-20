namespace ElectricalCalculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabWireCable = new System.Windows.Forms.TabPage();
            this.lblVoltageDisplay = new System.Windows.Forms.Label();
            this.btnIron = new System.Windows.Forms.RadioButton();
            this.btnGold = new System.Windows.Forms.RadioButton();
            this.btnAluminium = new System.Windows.Forms.RadioButton();
            this.txtSrcCurrent = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtCSA = new System.Windows.Forms.TextBox();
            this.txtResistivity = new System.Windows.Forms.TextBox();
            this.txtResistance = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblVoltageDrop = new System.Windows.Forms.Label();
            this.btnCopper = new System.Windows.Forms.RadioButton();
            this.btnSilver = new System.Windows.Forms.RadioButton();
            this.lblMetals = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblCSA = new System.Windows.Forms.Label();
            this.lblResistivity = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.tabWireDiameters = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tabWireCable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabWireCable);
            this.tabMain.Controls.Add(this.tabWireDiameters);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(656, 357);
            this.tabMain.TabIndex = 0;
            // 
            // tabWireCable
            // 
            this.tabWireCable.Controls.Add(this.lblVoltageDisplay);
            this.tabWireCable.Controls.Add(this.btnIron);
            this.tabWireCable.Controls.Add(this.btnGold);
            this.tabWireCable.Controls.Add(this.btnAluminium);
            this.tabWireCable.Controls.Add(this.txtSrcCurrent);
            this.tabWireCable.Controls.Add(this.txtLength);
            this.tabWireCable.Controls.Add(this.txtCSA);
            this.tabWireCable.Controls.Add(this.txtResistivity);
            this.tabWireCable.Controls.Add(this.txtResistance);
            this.tabWireCable.Controls.Add(this.lblCurrent);
            this.tabWireCable.Controls.Add(this.lblVoltageDrop);
            this.tabWireCable.Controls.Add(this.btnCopper);
            this.tabWireCable.Controls.Add(this.btnSilver);
            this.tabWireCable.Controls.Add(this.lblMetals);
            this.tabWireCable.Controls.Add(this.lblLength);
            this.tabWireCable.Controls.Add(this.lblCSA);
            this.tabWireCable.Controls.Add(this.lblResistivity);
            this.tabWireCable.Controls.Add(this.lblResistance);
            this.tabWireCable.Location = new System.Drawing.Point(4, 22);
            this.tabWireCable.Name = "tabWireCable";
            this.tabWireCable.Padding = new System.Windows.Forms.Padding(3);
            this.tabWireCable.Size = new System.Drawing.Size(648, 331);
            this.tabWireCable.TabIndex = 0;
            this.tabWireCable.Text = "Wire/Cable";
            this.tabWireCable.UseVisualStyleBackColor = true;
            // 
            // lblVoltageDisplay
            // 
            this.lblVoltageDisplay.AutoSize = true;
            this.lblVoltageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltageDisplay.Location = new System.Drawing.Point(239, 252);
            this.lblVoltageDisplay.Name = "lblVoltageDisplay";
            this.lblVoltageDisplay.Size = new System.Drawing.Size(38, 24);
            this.lblVoltageDisplay.TabIndex = 17;
            this.lblVoltageDisplay.Text = "0 V";
            // 
            // btnIron
            // 
            this.btnIron.AutoSize = true;
            this.btnIron.Location = new System.Drawing.Point(523, 160);
            this.btnIron.Name = "btnIron";
            this.btnIron.Size = new System.Drawing.Size(43, 17);
            this.btnIron.TabIndex = 16;
            this.btnIron.TabStop = true;
            this.btnIron.Text = "Iron";
            this.btnIron.UseVisualStyleBackColor = true;
            // 
            // btnGold
            // 
            this.btnGold.AutoSize = true;
            this.btnGold.Location = new System.Drawing.Point(523, 127);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(47, 17);
            this.btnGold.TabIndex = 15;
            this.btnGold.TabStop = true;
            this.btnGold.Text = "Gold";
            this.btnGold.UseVisualStyleBackColor = true;
            // 
            // btnAluminium
            // 
            this.btnAluminium.AutoSize = true;
            this.btnAluminium.Location = new System.Drawing.Point(523, 93);
            this.btnAluminium.Name = "btnAluminium";
            this.btnAluminium.Size = new System.Drawing.Size(72, 17);
            this.btnAluminium.TabIndex = 14;
            this.btnAluminium.TabStop = true;
            this.btnAluminium.Text = "Aluminium";
            this.btnAluminium.UseVisualStyleBackColor = true;
            // 
            // txtSrcCurrent
            // 
            this.txtSrcCurrent.Location = new System.Drawing.Point(243, 163);
            this.txtSrcCurrent.Name = "txtSrcCurrent";
            this.txtSrcCurrent.Size = new System.Drawing.Size(237, 20);
            this.txtSrcCurrent.TabIndex = 13;
            this.txtSrcCurrent.Text = "1";
            this.txtSrcCurrent.TextChanged += new System.EventHandler(this.txtCSA_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(243, 129);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(237, 20);
            this.txtLength.TabIndex = 12;
            this.txtLength.Text = "1";
            this.txtLength.TextChanged += new System.EventHandler(this.txtCSA_TextChanged);
            // 
            // txtCSA
            // 
            this.txtCSA.Location = new System.Drawing.Point(243, 97);
            this.txtCSA.Name = "txtCSA";
            this.txtCSA.Size = new System.Drawing.Size(237, 20);
            this.txtCSA.TabIndex = 11;
            this.txtCSA.Text = "1";
            this.txtCSA.TextChanged += new System.EventHandler(this.txtCSA_TextChanged);
            // 
            // txtResistivity
            // 
            this.txtResistivity.Location = new System.Drawing.Point(243, 62);
            this.txtResistivity.Name = "txtResistivity";
            this.txtResistivity.ReadOnly = true;
            this.txtResistivity.Size = new System.Drawing.Size(237, 20);
            this.txtResistivity.TabIndex = 10;
            // 
            // txtResistance
            // 
            this.txtResistance.Location = new System.Drawing.Point(243, 27);
            this.txtResistance.Name = "txtResistance";
            this.txtResistance.ReadOnly = true;
            this.txtResistance.Size = new System.Drawing.Size(237, 20);
            this.txtResistance.TabIndex = 9;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(18, 166);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(87, 13);
            this.lblCurrent.TabIndex = 8;
            this.lblCurrent.Text = "Load Current (A):";
            // 
            // lblVoltageDrop
            // 
            this.lblVoltageDrop.AutoSize = true;
            this.lblVoltageDrop.Location = new System.Drawing.Point(18, 260);
            this.lblVoltageDrop.Name = "lblVoltageDrop";
            this.lblVoltageDrop.Size = new System.Drawing.Size(72, 13);
            this.lblVoltageDrop.TabIndex = 7;
            this.lblVoltageDrop.Text = "Voltage Drop:";
            // 
            // btnCopper
            // 
            this.btnCopper.AutoSize = true;
            this.btnCopper.Location = new System.Drawing.Point(523, 62);
            this.btnCopper.Name = "btnCopper";
            this.btnCopper.Size = new System.Drawing.Size(59, 17);
            this.btnCopper.TabIndex = 6;
            this.btnCopper.TabStop = true;
            this.btnCopper.Text = "Copper";
            this.btnCopper.UseVisualStyleBackColor = true;
            // 
            // btnSilver
            // 
            this.btnSilver.AutoSize = true;
            this.btnSilver.Location = new System.Drawing.Point(523, 30);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(51, 17);
            this.btnSilver.TabIndex = 5;
            this.btnSilver.TabStop = true;
            this.btnSilver.Text = "Silver";
            this.btnSilver.UseVisualStyleBackColor = true;
            // 
            // lblMetals
            // 
            this.lblMetals.AutoSize = true;
            this.lblMetals.Location = new System.Drawing.Point(519, 3);
            this.lblMetals.Name = "lblMetals";
            this.lblMetals.Size = new System.Drawing.Size(63, 13);
            this.lblMetals.TabIndex = 4;
            this.lblMetals.Text = "Metal Type:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(18, 132);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(60, 13);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length (m):";
            // 
            // lblCSA
            // 
            this.lblCSA.AutoSize = true;
            this.lblCSA.Location = new System.Drawing.Point(18, 100);
            this.lblCSA.Name = "lblCSA";
            this.lblCSA.Size = new System.Drawing.Size(136, 13);
            this.lblCSA.TabIndex = 2;
            this.lblCSA.Text = "Cross-Sectional Area (mm²):";
            // 
            // lblResistivity
            // 
            this.lblResistivity.AutoSize = true;
            this.lblResistivity.Location = new System.Drawing.Point(18, 65);
            this.lblResistivity.Name = "lblResistivity";
            this.lblResistivity.Size = new System.Drawing.Size(106, 13);
            this.lblResistivity.TabIndex = 1;
            this.lblResistivity.Text = "Resistivity (Ω/metre):";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Location = new System.Drawing.Point(18, 30);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(81, 13);
            this.lblResistance.TabIndex = 0;
            this.lblResistance.Text = "Resistance (Ω):";
            // 
            // tabWireDiameters
            // 
            this.tabWireDiameters.Location = new System.Drawing.Point(4, 22);
            this.tabWireDiameters.Name = "tabWireDiameters";
            this.tabWireDiameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabWireDiameters.Size = new System.Drawing.Size(648, 331);
            this.tabWireDiameters.TabIndex = 1;
            this.tabWireDiameters.Text = "Wire Information";
            this.tabWireDiameters.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 381);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "ElectronToolkit";
            this.tabMain.ResumeLayout(false);
            this.tabWireCable.ResumeLayout(false);
            this.tabWireCable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabWireCable;
        private System.Windows.Forms.Label lblVoltageDisplay;
        private System.Windows.Forms.RadioButton btnIron;
        private System.Windows.Forms.RadioButton btnGold;
        private System.Windows.Forms.RadioButton btnAluminium;
        private System.Windows.Forms.TextBox txtSrcCurrent;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtCSA;
        private System.Windows.Forms.TextBox txtResistivity;
        private System.Windows.Forms.TextBox txtResistance;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblVoltageDrop;
        private System.Windows.Forms.RadioButton btnCopper;
        private System.Windows.Forms.RadioButton btnSilver;
        private System.Windows.Forms.Label lblMetals;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblCSA;
        private System.Windows.Forms.Label lblResistivity;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.TabPage tabWireDiameters;
    }
}

