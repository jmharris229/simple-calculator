using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
   public class NoConstantException :Exception
    {
        public NoConstantException()
            :base(){ }
        public NoConstantException(string message)
            : base(message){ }
    }
}
