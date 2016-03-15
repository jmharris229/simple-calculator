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


        public void setDictionary(string exp, Dictionary<char, int> constants)
        {
            int constantValue = 0;
            if(constants.Count == 0)
            {
                if(exp.Length == 3)
                {
                    constantValue = int.Parse(exp[2].ToString());
                }
                else
                {
                    constantValue = int.Parse(exp.Substring(2, exp.Length - 2));
                }
                constants.Add(Char.ToLower(exp[0]), constantValue);
                Console.WriteLine("= Saved {0} as {1}", exp[0], constantValue);
            }
            else
            {
                foreach (var item in constants)
                {
                    if (exp[0] == item.Key)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        constantValue = Convert.ToInt32(exp.Substring(2, exp.Length - 1));
                        constants.Add(exp[0], constantValue);
                        Console.WriteLine("= Saved {0} as {1}", exp[0], constantValue);
                    }
                }
            }
        }

        public int constantsDictionary(string exp, Dictionary<char, int> constants)
        {
            //create an if statement that checks to see if the value is there, if it is return the value, else throw exception that constant not defined
            if (constants.ContainsKey(exp[0]))
            {
                return constants[exp[0]];
            }
            else
            {
                throw new Exception();
            }       
        }
    }
}
