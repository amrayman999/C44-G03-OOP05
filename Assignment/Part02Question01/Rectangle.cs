using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02Question01
{
    public class Rectangle : IRectangle
    {
        public double Area { get ; set ; }
        public double Width { get; set; }
        public double Height { get ; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Area = width * height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Information : Width => {Width}, Height => {Height}, Area => {Area}");
        }
    }
}
