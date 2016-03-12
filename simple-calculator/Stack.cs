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
        Dictionary<char, int> constants = new Dictionary<char, int>();

        public Stack()
        {
           runExp = new Evaluate();
        }
        private Evaluate runExp;


        int exiter = 0;
        int counter = 1;

       public string command()
       {
            while(exiter == 0)
            {
                Console.WriteLine("[{x}]", counter);
                string expression = Console.ReadLine();

                if(expression == "exit" || expression == "quit")
                {
                    exiter = 1;                 
                }
                else
                {
                    double result = runExp.calculate(expression);
                    counter++;
                    return result.ToString();
                }
             }
            return "Bye!";
        }








        public void setDictionary(string exp)
        {
            //create an if statement that checks to see if an instance of the dictionary key value pair is in constatns if it is throw an exception, if not add it
            foreach (var item in constants)
            {
                if(exp[0] == item.Key)
                {
                    throw new Exception();
                }
                else
                {
                    
                    int constantValue = Convert.ToInt32(exp.Substring(2,    exp.Length - 1));
                    constants.Add(exp[0], constantValue);
                }
            }
            //convert letter to lower case for check and save
        }

        public string constantsDictionary(string exp)
        {
            //create an if statement that checks to see if the value is there, if it is return the value, else throw exception that constant not defined
            return "value";
            
        }

    }
}
