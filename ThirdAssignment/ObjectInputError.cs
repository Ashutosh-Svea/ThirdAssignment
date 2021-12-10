using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class ObjectInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a wrong object type.This fired an error!";
        }
    }
}
