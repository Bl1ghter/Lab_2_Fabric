using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_KPZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            CreateCircle circleCreator = new CreateCircle();

            MessageBox.Show(circleCreator.GetFigureString());
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            CreateTriangle triangleCreator = new CreateTriangle();

            MessageBox.Show(triangleCreator.GetFigureString());
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            CreateSquare squareCreator = new CreateSquare();

            MessageBox.Show(squareCreator.GetFigureString());
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            CreateRectangle rectangleCreator = new CreateRectangle();

            MessageBox.Show(rectangleCreator.GetFigureString());
        }
    }
}
