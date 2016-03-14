using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace simple_calculator.tests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EnsureEvaluateClassCalculateCanBeCalledCorrectly()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            double exp_result = 0.625;
            double act_result = mathey.calculate("5/8", dict, constants);
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureEvaluateClassLastCommandWorks()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            double exp_result = mathey.calculate("1+2", dict, constants);
            double act_result = mathey.calculate("last", dict, constants);
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureEvaluateClassLastqCommandWorks()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            double exp_result = mathey.calculate("1+2", dict, constants);
            double act_result = mathey.calculate("lastq", dict, constants);
            Assert.AreEqual(exp_result, act_result);
        }
    }
}
