using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class InvalidTermException :Exception
    {
        public InvalidTermException()
            : base() { }

        public InvalidTermException(string message)
            : base(message){ }
    }
}
