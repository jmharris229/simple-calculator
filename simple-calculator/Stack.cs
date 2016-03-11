using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Stack
    {
        public string lastq { get; set; }
        public int last { get; set; }
        new Dictionary<string, int> constants = new Dictionary<string, int>();

        public string setDictionary(string exp)
        {
            //create an if statement that checks to see if an instance of the dictionary key value pair is in constatns if it is throw an exception, if not add it

            //convert letter to lower case for check and save
            return "value";
        }

        public string constantsDictionary(string exp)
        {
            //create an if statement that checks to see if the value is there, if it is return the value, else throw exception that constant not defined
            return "value";
            
        }

    }
}
