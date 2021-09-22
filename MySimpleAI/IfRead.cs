using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAI
{
    class IfRead
    {
        public bool checkRead(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h)
        {
            if (a || b && c || d && e || f && g || h)
                return true;
            else return false;
;        }
    }
}
