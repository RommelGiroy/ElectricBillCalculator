
namespace ElectricBillCalculatorUI
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPowerDemand = new System.Windows.Forms.TextBox();
            this.txtTimeDuration = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rdoWatt = new System.Windows.Forms.RadioButton();
            this.rdoKilowatt = new System.Windows.Forms.RadioButton();
            this.rdoHorsePower = new System.Windows.Forms.RadioButton();
            this.lst = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComputeBillCost = new System.Windows.Forms.Button();
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKilowatt = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power demand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time duration";
            // 
            // txtPowerDemand
            // 
            this.txtPowerDemand.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPowerDemand.Location = new System.Drawing.Point(22, 110);
            this.txtPowerDemand.Name = "txtPowerDemand";
            this.txtPowerDemand.Size = new System.Drawing.Size(210, 28);
            this.txtPowerDemand.TabIndex = 1;
            // 
            // txtTimeDuration
            // 
            this.txtTimeDuration.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimeDuration.Location = new System.Drawing.Point(22, 263);
            this.txtTimeDuration.Name = "txtTimeDuration";
            this.txtTimeDuration.Size = new System.Drawing.Size(102, 28);
            this.txtTimeDuration.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(22, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(210, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // rdoWatt
            // 
            this.rdoWatt.AutoSize = true;
            this.rdoWatt.Location = new System.Drawing.Point(22, 147);
            this.rdoWatt.Name = "rdoWatt";
            this.rdoWatt.Size = new System.Drawing.Size(90, 24);
            this.rdoWatt.TabIndex = 2;
            this.rdoWatt.TabStop = true;
            this.rdoWatt.Text = "Watt (w)";
            this.rdoWatt.UseVisualStyleBackColor = true;
            // 
            // rdoKilowatt
            // 
            this.rdoKilowatt.AutoSize = true;
            this.rdoKilowatt.Location = new System.Drawing.Point(22, 177);
            this.rdoKilowatt.Name = "rdoKilowatt";
            this.rdoKilowatt.Size = new System.Drawing.Size(122, 24);
            this.rdoKilowatt.TabIndex = 3;
            this.rdoKilowatt.TabStop = true;
            this.rdoKilowatt.Text = "Kilowatt (kw)";
            this.rdoKilowatt.UseVisualStyleBackColor = true;
            // 
            // rdoHorsePower
            // 
            this.rdoHorsePower.AutoSize = true;
            this.rdoHorsePower.Location = new System.Drawing.Point(22, 207);
            this.rdoHorsePower.Name = "rdoHorsePower";
            this.rdoHorsePower.Size = new System.Drawing.Size(153, 24);
            this.rdoHorsePower.TabIndex = 4;
            this.rdoHorsePower.TabStop = true;
            this.rdoHorsePower.Text = "Horse Power (hp)";
            this.rdoHorsePower.UseVisualStyleBackColor = true;
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 20;
            this.lst.Location = new System.Drawing.Point(256, 27);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(360, 264);
            this.lst.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(256, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total (kWh) :";
            // 
            // btnComputeBillCost
            // 
            this.btnComputeBillCost.Location = new System.Drawing.Point(468, 309);
            this.btnComputeBillCost.Name = "btnComputeBillCost";
            this.btnComputeBillCost.Size = new System.Drawing.Size(148, 35);
            this.btnComputeBillCost.TabIndex = 14;
            this.btnComputeBillCost.Text = "Calculate Bill Cost";
            this.btnComputeBillCost.UseVisualStyleBackColor = true;
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApplianceName.Location = new System.Drawing.Point(22, 50);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(210, 28);
            this.txtApplianceName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Appliance name";
            // 
            // lblKilowatt
            // 
            this.lblKilowatt.AutoSize = true;
            this.lblKilowatt.Location = new System.Drawing.Point(358, 316);
            this.lblKilowatt.Name = "lblKilowatt";
            this.lblKilowatt.Size = new System.Drawing.Size(67, 20);
            this.lblKilowatt.TabIndex = 16;
            this.lblKilowatt.Text = "kilowatt";
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "Second",
            "Minute",
            "Hour"});
            this.cmbTime.Location = new System.Drawing.Point(130, 263);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(102, 28);
            this.cmbTime.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.lblKilowatt);
            this.Controls.Add(this.txtApplianceName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnComputeBillCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.rdoHorsePower);
            this.Controls.Add(this.rdoKilowatt);
            this.Controls.Add(this.rdoWatt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTimeDuration);
            this.Controls.Add(this.txtPowerDemand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electric Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPowerDemand;
        private System.Windows.Forms.TextBox txtTimeDuration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rdoWatt;
        private System.Windows.Forms.RadioButton rdoKilowatt;
        private System.Windows.Forms.RadioButton rdoHorsePower;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComputeBillCost;
        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKilowatt;
        private System.Windows.Forms.ComboBox cmbTime;
    }
}

