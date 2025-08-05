using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    public class Type : IType
    {
        public int Id { get; set; }

        public void Print()
        {
           Console.WriteLine("Type");
        }
    }
}
