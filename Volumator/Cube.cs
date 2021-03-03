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
    public partial class cubeForm : Form
    {
        // HomeForm object
        homeForm home;

        // Toggle for pic display 
        bool picToggle = true;

        // Save Pi as a variable to make it easier to write out label
        const double pi = Math.PI;

        // The successfully converted numbers
        double edge = 0.0;
        double volume = 0.0;

        public cubeForm()
        {
            InitializeComponent();

            home = new homeForm();

            // Set the background images of the display / formula controls
            displayPic.BackgroundImage = Properties.Resources.CubeDiagram;
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
            bool resultR = Double.TryParse(edgeTextBox.Text, out edge);

            edgeErrorLabel.Visible = !resultR;

            return (resultR);
        }

        // Calculate the volume of the given values
        private void CalculateValues()
        {
            volume = edge * edge * edge;
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

        // Return to the home form
        private void backBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void forumulaBut_Click(object sender, EventArgs e)
        {
            if (picToggle)
            {
                displayPic.BackgroundImage = Properties.Resources.CubeFormula;
                formulaBut.BackgroundImage = Properties.Resources.DiagramBut;
            }
            else
            {
                displayPic.BackgroundImage = Properties.Resources.CubeDiagram;
                formulaBut.BackgroundImage = Properties.Resources.FormulaBut;
            }
            picToggle = !picToggle;
        }
    }
}
