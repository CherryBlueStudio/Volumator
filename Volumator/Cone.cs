﻿using System;
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
    public partial class coneForm : Form
    {
        // HomeForm object
        homeForm home;

        // Toggle for pic display 
        bool picToggle = true;

        // Save Pi as a variable to make it easier to write out label
        const double pi = Math.PI;

        // The successfully converted numbers
        double height = 0.0;
        double radius = 0.0;
        double volume = 0.0;

        public coneForm()
        {
            InitializeComponent();

            home = new homeForm();

            // Set the background images of the display / formula controls
            displayPic.BackgroundImage = Properties.Resources.ConeDiagram;
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
            bool resultH = Double.TryParse(heightTextBox.Text, out height);
            bool resultR = Double.TryParse(radiusTextBox.Text, out radius);

            heightErrorLabel.Visible = !resultH;
            RadiusErrorLabel.Visible = !resultR;

            return (resultH && resultR);
        }

        // Calculate the volume of the given values
        private void CalculateValues()
        {
            volume = (1.0 / 3) * pi * radius * radius * height;
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

        // Toggle the diagram / formula display and button
        private void fomulaBut_Click(object sender, EventArgs e)
        {
            if (picToggle)
            {
                displayPic.BackgroundImage = Properties.Resources.ConeFormula;
                formulaBut.BackgroundImage = Properties.Resources.DiagramBut;
            }
            else
            {
                displayPic.BackgroundImage = Properties.Resources.ConeDiagram;
                formulaBut.BackgroundImage = Properties.Resources.FormulaBut;
            }
            picToggle = !picToggle;
        }
    }
}
