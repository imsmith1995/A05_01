using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string orderName = txtName.Text;
            var hamCost = 2.5;
            var friesCost = 1.5;
            var drinkCost = 1;
            double total = 0;
            string totalFormat = string.Empty;



            if(chkHamburger.Checked )
            {
                total += hamCost;
            }

            if(chkFries.Checked )
            {
                total += friesCost;
            }

            if(chkDrink.Checked )
            {
                total += drinkCost;
            }

            totalFormat = total.ToString("C");

            if(txtName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter a Name for the Order.", 
                    "Missing Order Name");
                return;
            }

            MessageBox.Show($"{orderName}'s Total due is: {totalFormat}",
                $"{orderName}'s Order.");
                return;


        }

        private void chkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHamburger.Checked )
            {
                lstHamburger.Visible = true;
                lstHamburger.Enabled = true;
            }
            else
            {
                lstHamburger.Visible = false;
                lstHamburger.Enabled = false;
            }
        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked)
            {
                cmbFries.Visible = true;
                cmbFries.Enabled = true;
            }
            else
            {
                cmbFries.Visible = false;
                cmbFries.Enabled = false;
            }
        }
    }
}
