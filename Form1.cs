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
            // Read in the earth weight
            earthWeight = Convert.ToDecimal(textearthWeight.Text);
            //Find the mass on Earth
            earthMass = earthWeight * gravAccEarth;
            //find weight on Mars
            textmarsWeight.Text = ((earthMass * gravAccMars) / 100).ToString();
        }
    }
}
