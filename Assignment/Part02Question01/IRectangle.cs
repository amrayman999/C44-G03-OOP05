using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02Question01
{
    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
