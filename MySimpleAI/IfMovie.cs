using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAI
{
    class IfMovie
    {
        public bool checkMovie(bool a, bool c, bool d, bool e, bool f, bool h)
        {
            if (a && c || d && e || f && h)
                return true;
            else return false;
            ;
        }
    }
}
