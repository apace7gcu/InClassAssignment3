﻿/* Amanda Pace
 * CST-117
 * Bill Hughes
 * 
 * 10/02/2020
 * 
 * This is a program that takes a number the user
 * enters as their weight on earth, and converts it
 * into what their weight on mars would be.
 * 
 * This is an assignment done in-class as a group, 
 * code is primarily from the professor.
 * 
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bttnConvert_Click(object sender, EventArgs e)
        {
                //Define variables
                //Input value for weight on Earth
                decimal earthWeight = 0;
                decimal earthMass = 0;
                decimal gravAccEarth = Convert.ToDecimal(9.81);
                decimal gravAccMars = Convert.ToDecimal(3.71);

            try
            {
                // Read in the earth weight
                earthWeight = Convert.ToDecimal(textearthWeight.Text);
                //Find the mass on Earth
                earthMass = earthWeight * gravAccEarth;
                //find weight on Mars
                textmarsWeight.Text = ((earthMass * gravAccMars) / 100).ToString("#,0.000");
            }

            catch
            {
                MessageBox.Show("You must enter a number for for the calculation to execute. Please try again. (:");
            }
        }
    }
}

