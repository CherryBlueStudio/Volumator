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
    public partial class homeForm : Form
    {
        // Lists for unit amount combobox
        public List<string> unitList;

        public homeForm()
        {
            InitializeComponent();

            unitList = new List<string>();

            unitList.Add("Millimetres");
            unitList.Add("Centimetres");
            unitList.Add("Metres");
            unitList.Add("Inches");
            unitList.Add("Feet");
            unitList.Add("Yards");
        }

        private void squareBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            coneForm temp = new coneForm();
            temp.ShowDialog();
            this.Close();
        }

        private void rectangleBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            RectangularForm temp = new RectangularForm();
            temp.ShowDialog();
            this.Close();
        }

        private void capsuleBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            capsuleForm temp = new capsuleForm();
            temp.ShowDialog();
            this.Close();
        }

        private void sphereBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            sphereForm temp = new sphereForm();
            temp.ShowDialog();
            this.Close();
        }

        private void cubeBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            cubeForm temp = new cubeForm();
            temp.ShowDialog();
            this.Close();
        }

        private void sphericalBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            capForm temp = new capForm();
            temp.ShowDialog();
            this.Close();
        }

        private void cylinderBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            cylinderForm temp = new cylinderForm();
            temp.ShowDialog();
            this.Close();
        }

        private void conicalBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            conicalForm temp = new conicalForm();
            temp.ShowDialog();
            this.Close();
        }

        private void ellipsoidBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            ellipsoidForm temp = new ellipsoidForm();
            temp.ShowDialog();
            this.Close();
        }

        private void pyramidBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            squarePyramidForm temp = new squarePyramidForm();
            temp.ShowDialog();
            this.Close();
        }

        private void tubeBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            tubeForm temp = new tubeForm();
            temp.ShowDialog();
            this.Close();
        }
    }
}
