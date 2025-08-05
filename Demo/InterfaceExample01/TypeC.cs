using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterfaceExample01
{
    public class TypeC : ISeries
    {
        public int Current { get ; set ; }
        public void GetNext()
        {
            Current += 3;
        }
    }
}
