using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class ValidError : UserError
    {
        public override string UEMessage()
        {
            return "You typed in a valid input. Good for you! This fired an error.";
        }
    }
}
