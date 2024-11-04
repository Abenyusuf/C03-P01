// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Program 01 Chapter 03)
// Description of the Program: This program will calculate and display the percentage of lions and tigers
// I have also added the optional extra credit



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BIgCats : Form
    {
        public BIgCats()
         {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            // This button will complete the required calculations 
            // These doubles are representing point of storage for floats
            double Tigers;
            double Lions;
            double Total;
            double PercentTigers;
            double PercentLions;

            // Converts the inputs from strings to floats / integers
            Tigers = double.Parse(TigerInput.Text);
            Lions = double.Parse(LionInput.Text);

            // Calculate the total amount of cats and display them 
            Total = (Tigers + Lions);
            TotalCatsDisplay.Text = Total.ToString();

            // calculate the percentage of tigers and display
            PercentTigers = (Tigers / Total);
            OutputTigers.Text = PercentTigers.ToString("P1");

            // calculate the percentage of lions and display
            PercentLions = (Lions / Total);
            OutputLions.Text = PercentLions.ToString("P1");

        }
        private void Tigerinput_TextChanged(object sender, EventArgs e)
        {
            //This is an input for the amount of Tigers
        }

        private void LionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputDisplay_Click(object sender, EventArgs e)
        {

        }

        private void LionInput_TextChanged_1(object sender, EventArgs e)
        {
            //This is an input for the amount of lions
        }

        private void OutputDisplay_Click_1(object sender, EventArgs e)
        {
            //This is the output for the % of lions
        }

        private void TotalCatsDisplay_Click(object sender, EventArgs e)
        {
            //This is the output for the total amount of cats 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //This is a button to exit the program
        }

        private void OutputTigers_Click(object sender, EventArgs e)
        {
            //This is the output for the percent of tigers
        }

        private void BIgCats_Load(object sender, EventArgs e)
        {

        }
    }
}
