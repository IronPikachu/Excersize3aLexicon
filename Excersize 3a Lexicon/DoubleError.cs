using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class DoubleError : UserError
    {
        public override string UEMessage()
        {
            return "You didn't type in a double value. This fired an error!";
        }
    }
}
