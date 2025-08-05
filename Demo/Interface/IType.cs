using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    public interface IType
    {
        public int Id { get; set; }

        public void Print();

        // default Implemented method , not appearing in class that implement the interface
        // must bind the object to the interface type to use it
        public void PrintMessage()
        {
            Console.WriteLine("");
        }
    }
}
