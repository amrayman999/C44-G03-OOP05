using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterfaceExample02
{
    public class Car : Vehicle, IMoveOnGround
    {
        public void Backward()
        {
            throw new NotImplementedException();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
