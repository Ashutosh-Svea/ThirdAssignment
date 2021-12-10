using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class UnknownInputError : UserError
    {
        public override string UEMessage()
        {
            return "Unknown or Invalid input error.This fired an error!";
        }
    }
}
