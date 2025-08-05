using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02Question01
{
    public class Circle : ICircle
    {
        public double Area { get ; set; }
        public double Radius { get; set; }

        public Circle(double radius) { 
            Radius = radius;
            Area = Math.PI * Radius * Radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Information : Radius => {Radius}, Area => {Area}");
        }
    }
}
