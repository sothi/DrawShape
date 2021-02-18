using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DrawShape
{
     public class DataAccess
    {
        //Later get it from App config file.
        private const string FILE_NAME = "c:\\Users\\sothi\\source\\repos\\DrawShape\\DrawShape\\Data\\Shapes.xml";

        //an XDocument which contains all the shapes records
        private XDocument m_XDocument;
        // todo Serializetion
        private XmlSerializer m_XmlSerializer;
        //all shapes
        private Shape m_shape;
       
        private IEnumerable<XElement> eRectangle;
        private IEnumerable<XElement> eCircle;
        private IEnumerable<XElement> eTriangle;

        public DataAccess   ()
        {

            try
            {
                m_XDocument = XDocument.Load(FILE_NAME);
            }
            catch (Exception e)
            {
                //error handing code
            }

        }

        public Shape GetShapes(string Scode)    
        {
           // Todo later
            m_shape = new Shape();
            return m_shape;  
        }

        public IEnumerable<XElement> GetRectangles()
        {
            //Get all Rectangles
            try
            {
                eRectangle = (IEnumerable<XElement>)from nm in m_XDocument.Elements("Shapes").Elements("Shape")
                                                    where (string)nm.Element("code") == "1"
                                                    select nm;
            }
            catch(Exception e)
            {
                //error handing code
            }

            return eRectangle;  //return all Rectangles
        }

        public IEnumerable<XElement> GetCircles()
        {
            //Get all Circles
            try
            {
                eCircle = (IEnumerable<XElement>)from nm in m_XDocument.Elements("Shapes").Elements("Shape")
                                                    where (string)nm.Element("code") == "2"
                                                    select nm;
            }
            catch (Exception e)
            {
                //error handing code
            }

            return eCircle;  //return all Circles
        }

        public IEnumerable<XElement> GetTriangles()
        {
            //Get all Trianles
            try
            {
                eRectangle = (IEnumerable<XElement>)from nm in m_XDocument.Elements("Shapes").Elements("Shape")
                                                    where (string)nm.Element("code") == "3"
                                                    select nm;
            }
            catch (Exception e)
            {
                //error handing code
            }

            return eRectangle;  //return all Triangles
        }

        //TODO: update and delete methods...
    }
}
