using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02Question02
{
    [Flags]
    public enum Role
    {
        None = 0,
        Editor = 1,
        Viewer = 2,
        Admin = 4,
    }
}
