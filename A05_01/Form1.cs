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
            var hamCost = 3.5;
            var friesCost = 0.0;
            var drinkCost = 0.0;
            double total = 0.0;
            string totalFormat = string.Empty;

            //Start of Fries Size and Cost area.
            if(cmbFries.Text == "Sm   :  $1.00")
            {
                friesCost = 1;
            }
            if(cmbFries.Text == "Med :  $1.50")
            {
                friesCost = 1.5;
            }
            if (cmbFries.Text == "Lrg   :  $1.75")
            {
                friesCost = 1.75;
            }
            //End of Fries Size and Cost area.

            //Start of Drink Size and Cost area.
            if (cmbDrink.Text == "Sm   :  $1.00")
            {
                drinkCost = 1;
            }
            if (cmbDrink.Text == "Med :  $1.50")
            {
                drinkCost = 1.5;
            }
            if (cmbDrink.Text == "Lrg   :  $1.75")
            {
                drinkCost = 1.75;
            }
            if (cmbDrink2.Text == "Water (Free)")
            {
                drinkCost = 0;
            }

            //End of Drink Size and Cost area.

            //Start of Bacon Price Modifier
            if (lstHamburger.GetItemCheckState(7) == CheckState.Checked)
            {
                hamCost += 1.5;
            }
            //End of Bacon Price Modifier.

            //Start of modifying the Total Cost.
            if (chkHamburger.Checked )
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
            //Start of modifying the Total Cost.

            if (txtName.Text == string.Empty)
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

        private void chkDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDrink.Checked )
            {
                cmbDrink.Visible = true;
                cmbDrink.Enabled = true;

                cmbDrink2.Visible = true;
                cmbDrink2.Enabled = true;
            }
            else 
            { 
                cmbDrink.Visible = false;
                cmbDrink.Enabled = false;

                cmbDrink2.Enabled = false;
                cmbDrink2.Visible = false;
            }
        }
    }
}
