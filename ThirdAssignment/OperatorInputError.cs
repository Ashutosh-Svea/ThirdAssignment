using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class OperatorInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an invalid operator.This fired an error!";
        }
    }
}
