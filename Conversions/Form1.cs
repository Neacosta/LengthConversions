using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
            {"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
            {"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
            {"Feet to meters", "Feet", "Meters", "0.3048"},
            {"Meters to feet", "Meters", "Feet", "3.2808"},
            {"Inches to centimeters", "Inches", "Centimeters", "2.54"},
            {"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
        };


        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboConversions.Items.Add("Miles to kilometers");
            cboConversions.Items.Add("Kilometers to miles");
            cboConversions.Items.Add("Feet to meters");
            cboConversions.Items.Add("Meters to feet");
            cboConversions.Items.Add("Inches to centimeters");
            cboConversions.Items.Add("Centimeters to inches");
            cboConversions.SelectedIndex = 0;

        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboConversions.SelectedIndex)
            {
                case 0:
                    lblCalculatedLength.Text = "";
                    txtLength.Focus();
                   
                    break;
                case 1:
                    
                    lblCalculatedLength.Text = "";
                    txtLength.Focus();
                    lblFromLength.Text = "Kilometers";
                    lblToLength.Text = "Miles";
                    break;
                case 2:
                    lblCalculatedLength.Text = "";
                    txtLength.Focus();
                    lblFromLength.Text = "Feet";
                    lblToLength.Text = "Meters";
                    break;
                case 3:
                    lblCalculatedLength.Text = "";
                    txtLength.Focus();
                    lblFromLength.Text = "Meters";
                    lblToLength.Text = "Feet";
                    break;
                case 4:
                    lblCalculatedLength.Text = "";
                    txtLength.Focus();
                    lblFromLength.Text = "Inches";
                    lblToLength.Text = "Centimeters";
                    break;
                case 5:
                    lblCalculatedLength.Text = "";
                    txtLength.Focus();
                    lblFromLength.Text = "Centimeters";
                    lblToLength.Text = "Inches";
                    break;

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboConversions.SelectedIndex == 0)
                {
                    decimal length = Convert.ToDecimal(txtLength.Text);
                    decimal getNumberFromTable = Convert.ToDecimal(conversionTable[0, 3]);
                    decimal conversion = length * getNumberFromTable;
                    lblCalculatedLength.Text = conversion.ToString();
                }
                else if (cboConversions.SelectedIndex == 1)
                {
                    decimal length = Convert.ToDecimal(txtLength.Text);
                    decimal getNumberFromTable = Convert.ToDecimal(conversionTable[1, 3]);
                    decimal conversion = length * getNumberFromTable;
                    lblCalculatedLength.Text = conversion.ToString();
                }
                else if (cboConversions.SelectedIndex == 2)
                {
                    decimal length = Convert.ToDecimal(txtLength.Text);
                    decimal getNumberFromTable = Convert.ToDecimal(conversionTable[2, 3]);
                    decimal conversion = length * getNumberFromTable;
                    lblCalculatedLength.Text = conversion.ToString();
                }
                else if (cboConversions.SelectedIndex == 3)
                {
                    decimal length = Convert.ToDecimal(txtLength.Text);
                    decimal getNumberFromTable = Convert.ToDecimal(conversionTable[3, 3]);
                    decimal conversion = length * getNumberFromTable;
                    lblCalculatedLength.Text = conversion.ToString();
                }
                else if (cboConversions.SelectedIndex == 4)
                {
                    decimal length = Convert.ToDecimal(txtLength.Text);
                    decimal getNumberFromTable = Convert.ToDecimal(conversionTable[4, 3]);
                    decimal conversion = length * getNumberFromTable;
                    lblCalculatedLength.Text = conversion.ToString();
                }
                else if (cboConversions.SelectedIndex == 5)
                {
                    decimal length = Convert.ToDecimal(txtLength.Text);
                    decimal getNumberFromTable = Convert.ToDecimal(conversionTable[5, 3]);
                    decimal conversion = length * getNumberFromTable;
                    lblCalculatedLength.Text = conversion.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                  "Invalid numeric format. Please check entry.",
                  "Entry Error");
            }
        }   

    }
}