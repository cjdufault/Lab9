using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class Form1 : Form
    {
        private List<double> quarters = new List<double>(); // list that contains values for all quarters
        WaterBillAnalysis analysis = new WaterBillAnalysis();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (ParseQuarterFields()) 
            {
                double total = analysis.SumQuarterlyBills(quarters);

                double avg = analysis.AvgQuarterlyBill(quarters);

                txtTotal.Text = total.ToString("c");
                txtAvg.Text = avg.ToString("c");
            }
        }

        // returns true if parsing was successful
        private bool ParseQuarterFields()
        {
            try
            {
                double q1Bill = Double.Parse(txtQ1.Text);
                double q2Bill = Double.Parse(txtQ2.Text);
                double q3Bill = Double.Parse(txtQ3.Text);
                double q4Bill = Double.Parse(txtQ4.Text);

                quarters.Add(q1Bill);
                quarters.Add(q2Bill);
                quarters.Add(q3Bill);
                quarters.Add(q4Bill);

                return true;
            }
            // catch fields w/o a number inputted
            catch (FormatException)
            {
                MessageBox.Show("At least one field does not contain a number.", "Error");
                return false;
            }
            // fields with too large of a number
            catch (OverflowException)
            {
                MessageBox.Show("At least one value is too large.", "Error");
                return false;
            }
        }
    }
}
