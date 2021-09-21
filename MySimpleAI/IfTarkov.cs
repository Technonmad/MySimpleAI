using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAI
{
    public class IfTarkov
    {
        public bool CheckTarkov(bool a, bool b, bool c, bool d)
        {
            if (a && b && c && d)
                return true;
            else
                return false;
        }
    }
}
