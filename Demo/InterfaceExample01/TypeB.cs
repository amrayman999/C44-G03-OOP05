using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterfaceExample01
{
    public class TypeB : ISeries
    {
        public int Current { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetNext()
        {
            Current += 2;
        }
    }
}
