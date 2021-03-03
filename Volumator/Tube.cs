using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumator
{
    public partial class tubeForm : Form
    {
        // HomeForm object
        homeForm home;

        // Toggle for pic display 
        bool picToggle = true;

        // Save Pi as a variable to make it easier to write out label
        const double pi = Math.PI;

        // The successfully converted numbers
        double inner = 0.0;
        double outer = 0.0;
        double length = 0.0;
        double volume = 0.0;

        public tubeForm()
        {
            InitializeComponent();

            home = new homeForm();

            // Set the background images of the display / formula controls
            displayPic.BackgroundImage = Properties.Resources.TubeDiagram;
            formulaBut.BackgroundImage = Properties.Resources.FormulaBut;

            // Set the unit combobox list
            unitComboBox.DataSource = home.unitList;
        }

        // Check and convert input string to double
        private bool CheckConvertInput()
        {
            // Attempt to convert string inputs from textboxes to double
            // If true then set class varibles height and radius and return true
            // if not then display error message and return false
            bool resultI = Double.TryParse(innerTextBox.Text, out inner);
            bool resultO = Double.TryParse(outerTextBox.Text, out outer);
            bool resultL = Double.TryParse(lengthTextBox.Text, out length);

            innerErrorLabel.Visible = !resultI;
            outerErrorLabel.Visible = !resultO;
            lengthErrorLabel.Visible = !resultL;

            return (resultI && resultO && resultL);
        }

        // Calculate the volume of the given values
        private void CalculateValues()
        {
            volume = pi * (outer * outer - inner * inner) / 4 * length;
        }

        // Set the result label using the correct unit
        private void SetResultLabel()
        {
            resultLabel.Text = "Result : " + volume.ToString() + " " + unitComboBox.SelectedValue + "³";
            resultLabel.Visible = true;
        }

        // Check the input and calculate values if possible
        // Turn off the result message if it's on from previous calculation
        private void calculateBut_Click(object sender, EventArgs e)
        {
            if (CheckConvertInput())
            {
                CalculateValues();
                SetResultLabel();
            }
            else
            {
                resultLabel.Visible = false;
            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void formulaBut_Click(object sender, EventArgs e)
        {
            if (picToggle)
            {
                displayPic.BackgroundImage = Properties.Resources.TubeFormula;
                formulaBut.BackgroundImage = Properties.Resources.DiagramBut;
            }
            else
            {
                displayPic.BackgroundImage = Properties.Resources.TubeDiagram;
                formulaBut.BackgroundImage = Properties.Resources.FormulaBut;
            }
            picToggle = !picToggle;
        }
    }
}
