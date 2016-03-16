using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class AlreadyDefinedConstantException :Exception
    {
        public AlreadyDefinedConstantException()
            : base(){ }
        public AlreadyDefinedConstantException(string message)
            : base(message){ }
    }
}
