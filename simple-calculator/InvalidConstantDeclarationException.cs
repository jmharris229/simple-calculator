using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class InvalidConstantDeclarationException :Exception
    {
        public InvalidConstantDeclarationException()
            : base(){ }
        public InvalidConstantDeclarationException(string message)
            : base(message){ }
    }
}
