namespace FinancialCalculations
{
    partial class frmTab
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
            this.tabCalculations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDepreciation = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLife = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFinalValue = new System.Windows.Forms.TextBox();
            this.txtInitialCost = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new ctlCuteButton.cuteButton();
            this.btnCalculate = new ctlCuteButton.cuteButton();
            this.tabCalculations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCalculations
            // 
            this.tabCalculations.Controls.Add(this.tabPage2);
            this.tabCalculations.Controls.Add(this.tabPage1);
            this.tabCalculations.Location = new System.Drawing.Point(12, 12);
            this.tabCalculations.Name = "tabCalculations";
            this.tabCalculations.SelectedIndex = 0;
            this.tabCalculations.Size = new System.Drawing.Size(263, 266);
            this.tabCalculations.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstDepreciation);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboLife);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtFinalValue);
            this.tabPage1.Controls.Add(this.txtInitialCost);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(255, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Depreciation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "SYD Depreciation:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Initial Cost of Asset:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstDepreciation
            // 
            this.lstDepreciation.FormattingEnabled = true;
            this.lstDepreciation.Location = new System.Drawing.Point(18, 123);
            this.lstDepreciation.Name = "lstDepreciation";
            this.lstDepreciation.Size = new System.Drawing.Size(207, 69);
            this.lstDepreciation.TabIndex = 24;
            this.lstDepreciation.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Final Value of Asset:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboLife
            // 
            this.cboLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLife.FormattingEnabled = true;
            this.cboLife.Location = new System.Drawing.Point(138, 74);
            this.cboLife.Name = "cboLife";
            this.cboLife.Size = new System.Drawing.Size(87, 21);
            this.cboLife.TabIndex = 23;
            this.cboLife.Tag = "Life";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Life of Asset in Years:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFinalValue
            // 
            this.txtFinalValue.Location = new System.Drawing.Point(138, 47);
            this.txtFinalValue.Name = "txtFinalValue";
            this.txtFinalValue.Size = new System.Drawing.Size(84, 20);
            this.txtFinalValue.TabIndex = 20;
            this.txtFinalValue.Tag = "Final Value";
            // 
            // txtInitialCost
            // 
            this.txtInitialCost.Location = new System.Drawing.Point(138, 19);
            this.txtInitialCost.Name = "txtInitialCost";
            this.txtInitialCost.Size = new System.Drawing.Size(84, 20);
            this.txtInitialCost.TabIndex = 18;
            this.txtInitialCost.Tag = "Initial Cost";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFutureValue);
            this.tabPage2.Controls.Add(this.txtMonthlyInvestment);
            this.tabPage2.Controls.Add(this.txtYears);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtInterestRate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(255, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Future Value";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(138, 139);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(86, 20);
            this.txtFutureValue.TabIndex = 28;
            this.txtFutureValue.TabStop = false;
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(140, 55);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(84, 20);
            this.txtMonthlyInvestment.TabIndex = 25;
            this.txtMonthlyInvestment.Tag = "";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(140, 110);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(84, 20);
            this.txtYears.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Monthly Investment:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(140, 83);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(84, 20);
            this.txtInterestRate.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yearly Interest Rate:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number of Years:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Future Value:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.cuteColor1 = System.Drawing.Color.LightGreen;
            this.btnExit.cuteColor2 = System.Drawing.Color.DarkBlue;
            this.btnExit.cuteTransparent1 = 64;
            this.btnExit.cuteTransparent2 = 64;
            this.btnExit.Location = new System.Drawing.Point(200, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.cuteColor1 = System.Drawing.Color.LightGreen;
            this.btnCalculate.cuteColor2 = System.Drawing.Color.DarkBlue;
            this.btnCalculate.cuteTransparent1 = 64;
            this.btnCalculate.cuteTransparent2 = 64;
            this.btnCalculate.Location = new System.Drawing.Point(108, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 397);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tabCalculations);
            this.Name = "frmTab";
            this.Text = "frmTab";
            this.Load += new System.EventHandler(this.frmTab_Load);
            this.tabCalculations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCalculations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDepreciation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLife;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFinalValue;
        private System.Windows.Forms.TextBox txtInitialCost;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ctlCuteButton.cuteButton btnCalculate;
        private ctlCuteButton.cuteButton btnExit;
    }
}