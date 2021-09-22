using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAI
{
    class WannaSleep
    {
        public bool checkSleep(bool a, bool b, bool c)
        {
            if ((a || b) && c)
                return true;
            else return false;
        }
    }
}
