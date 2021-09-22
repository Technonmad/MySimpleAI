using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAI
{
    class IfBusy
    {
        public bool checkBusy(bool a, bool b)
        {
            if (a && b)
                return true;
            else
                return false;
        }
    }
}
