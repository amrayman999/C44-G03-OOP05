using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterfaceExample01
{
    public interface ISeries
    {
        public int Current { get; set; }
        public void GetNext();
        public void Reset()
        {
            Current = 0;
        }
        public void Print()
        {
            Console.WriteLine();
        }
    }
}
