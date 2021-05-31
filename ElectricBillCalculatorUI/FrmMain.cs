using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerConsumptionCalculatorLibrary;

namespace ElectricBillCalculatorUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //double output = Convert.ToDouble(txtPowerDemand.Text) * 1 / 1000;

            //lblKilowatt.Text = output.ToString();

            double duration = Convert.ToDouble(txtTimeDuration.Text);

            lblKilowatt.Text = TimeConverter.ConvertTime(cmbTime.SelectedItem, duration).ToString();

            
        }
    }
}
