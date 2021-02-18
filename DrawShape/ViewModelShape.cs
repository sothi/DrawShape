using System;
using System.Collections.Generic;
using System.Text;

namespace DrawShape
{
    public class ViewModelShape
    {
        // Basic members of the shape, common for all shapes
        public string Name { get; private set; }
        public string ForeColor { get; private set; }
        public string BackColor { get; private set; }

        //Drawing location(x,y)
        public int X { get; private set; }
        public int Y { get; private set; }

        public float Area { get; set; }


        // Basic Drawing method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }


    public class vRectangle : ViewModelShape
    {
        //Shape Dimention 
        public int Height { get; set; }
        public int Width { get; set; }
        public vRectangle()
        {
            var _mRectangle = new mRectangle();
            Height = _mRectangle.Height;
            Width = _mRectangle.Width;

        }
        public override void Draw()
        {
            // Code to draw a rectangle...

            base.Draw();
        }
    }

    public class vCircle : ViewModelShape
    {
        public int Diameter { get; private set; }
        public vCircle()
        {
            var _mCircle = new mCircle();
            Diameter = _mCircle.Diameter;
            
        }
        public override void Draw()
        {
            // Code to draw a circle...

            base.Draw();
        }
    }
   
    public class vTriangle : ViewModelShape
    {
        public int cordinateX1 { get; private set; }
        public int cordinateY1 { get; private set; }
        public int cordinateX2 { get; private set; }
        public int cordinateY2 { get; private set; }
        public int cordinateX3 { get; private set; }
        public int cordinateY3 { get; private set; }
        public vTriangle()
        {
            var _mTriangle = new mTriangle();
            cordinateX1 = _mTriangle.cordinateX1;
            cordinateY1 = _mTriangle.cordinateY1;

            cordinateX2 = _mTriangle.cordinateX2;
            cordinateY2 = _mTriangle.cordinateY2;

            cordinateX3 = _mTriangle.cordinateX3;
            cordinateY3 = _mTriangle.cordinateY3;

        }
        public override void Draw()
        {
            // Code to draw a triangle...

            base.Draw();
        }
    }
}
