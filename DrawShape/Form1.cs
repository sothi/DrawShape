using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DrawShape
{
    public partial class Form1 : Form
    {
       // Variables for shapes
        private vRectangle _viewRectangle;
        private vCircle   _viewCircle;
        private vTriangle _viewTriangle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Pain(object sender, PaintEventArgs e)
        {
            try
            {
                _viewRectangle = new vRectangle();
                _viewCircle = new vCircle();
                _viewTriangle = new vTriangle();               

                // Create pen.
                Pen blackPenR = new Pen(Color.Black, 3);
                Pen blackPenP = new Pen(Color.Black, 3);
                Pen pen = new Pen(Color.Green, 3);
                // Create solid brush.
                SolidBrush redBrush = new SolidBrush(Color.Red);
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                SolidBrush whiteBrush = new SolidBrush(Color.White);

                Graphics g = e.Graphics;
                
                

                

                // Draw rectangle.
                //set default value, Todo: frontend error handling later
                Rectangle rect = new Rectangle(68, 50, 0, 0);
                rect.Height = _viewRectangle.Height;
                rect.Width = _viewRectangle.Height;
                e.Graphics.DrawRectangle(blackPenR, rect);
                // Fill rectangle to screen.
                e.Graphics.FillRectangle(blueBrush, rect);
                g.DrawString("Rectangle:", this.Font, redBrush, 5, 50);
                g.DrawString("Area=L*W", this.Font, whiteBrush, 177, 190);

                //Draw a circle , Todo: frontend error handling later.
                g.DrawEllipse(pen, 500, 230, _viewCircle.Diameter, _viewCircle.Diameter);
                g.DrawString("Circle:", this.Font, redBrush, 450, 250);
                g.DrawString("Area=PI*R*R", this.Font, redBrush, 566, 320);

                // Draw Triangle Create points that define polygon / Triangle.  Todo: frontend error handling later.
                Point point1 = new Point(_viewTriangle.cordinateX1, _viewTriangle.cordinateY1);
                Point point2 = new Point(_viewTriangle.cordinateX2, _viewTriangle.cordinateY2);
                Point point3 = new Point(_viewTriangle.cordinateX3, _viewTriangle.cordinateY3);
                Point[] curvePoints =
                                 {
                                    point1,
                                    point2,
                                    point3
                                  };
                e.Graphics.DrawPolygon(blackPenP, curvePoints);
                e.Graphics.FillPolygon(blueBrush, curvePoints);
                g.DrawString("Triangle:", this.Font, redBrush, 450, 50);
                g.DrawString("Area=B*H/2", this.Font, whiteBrush, 516, 60);

            }
            catch (Exception )
            {
                // error handling code,
            
            }

        }
    }
}
