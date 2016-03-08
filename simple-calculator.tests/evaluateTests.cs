using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.tests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EnsureCalculateCanBeCalledCorrectly()
        {
            Evaluate mathey = new Evaluate();
            int exp_result = 3;
            int act_result = mathey.calculate("1+2");

        }
    }
}
