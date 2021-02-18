using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DrawShape
{
    public class ModelShape
    { 
    
    }
    public class Shape
    {
        // Basic members of the shape, common for all shapes
        public string Name { get; private set; }
        public string ForeColor { get; private set; }
        public string BackColor { get; private set; }

        //Drawing location(x,y)
        public int X { get; private set; }
        public int Y { get; private set; }

        public float Area { get; set; }

        // Drawing method
        public virtual void Draw()
        {
           
        }
    }

    public class mRectangle : Shape
    {
        public DataAccess _dal = new DataAccess();

        //Shape Dimention 
        public int Height { get; set; }
        public int Width { get; set; }

        public mRectangle()
        {

            XElement eRec = (_dal.GetRectangles()).First();
            Height = int.Parse(eRec.Element("Length").Value);
            Width = int.Parse(eRec.Element("Width").Value);
        }

        public float area()
        {
            //Calculate the area of rectangle
            return Area;
        }
        public override void Draw()
        {
            // Code to draw a rectangle...

            base.Draw();
        }
    }

    public class mCircle : Shape
    {
        public DataAccess _dal = new DataAccess();
        public int Diameter { get; private set; }
        public mCircle()
        {

            XElement eRec = (_dal.GetCircles()).First();
            Diameter = int.Parse(eRec.Element("Diameter").Value);
            
        }

        public float area()
        {
            //Calculate the area of the circle
            return Area;
        }
        public override void Draw()
        {
            // Code to draw a circle...
            
            base.Draw();
        }
    }
   
    public class mTriangle : Shape
    {
        public DataAccess _dal = new DataAccess();
        public int cordinateX1 { get; private set; }
        public int cordinateY1 { get; private set; }
        public int cordinateX2 { get; private set; }
        public int cordinateY2 { get; private set; }
        public int cordinateX3 { get; private set; }
        public int cordinateY3 { get; private set; }
        public mTriangle()
        {

            XElement eRec = (_dal.GetTriangles()).First();

            cordinateX1 = int.Parse(eRec.Element("cordinateX1").Value);
            cordinateY1 = int.Parse(eRec.Element("cordinateY1").Value);

            cordinateX2 = int.Parse(eRec.Element("cordinateX2").Value);
            cordinateY2 = int.Parse(eRec.Element("cordinateY2").Value);

            cordinateX3 = int.Parse(eRec.Element("cordinateX3").Value);
            cordinateY3 = int.Parse(eRec.Element("cordinateY3").Value);
        }

        public float area()
        {
            //Calculate the area of the Triangle
            return Area;
        }
        public override void Draw()
        {
            // Code to draw a triangle...
            
            base.Draw();
        }
    }
}
