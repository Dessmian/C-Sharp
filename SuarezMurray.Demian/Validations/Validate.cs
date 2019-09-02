using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validations
{
    public class Validate
    {
        public static bool IntegerRange (int input,int minTolerance, int maxTolerance)
        {
            bool retBool = false;
            if (input >= minTolerance && input <= maxTolerance)
                retBool = true;
            return retBool;
        }
    }
}
