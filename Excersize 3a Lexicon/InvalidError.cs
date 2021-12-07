using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class InvalidError : UserError
    {
        public override string UEMessage()
        {
            return "You typed in an invalid text. This fired an error!";
        }
    }
}
