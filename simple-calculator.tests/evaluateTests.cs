using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.tests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EnsureEvaluateClassCalculateCanBeCalledCorrectly()
        {
            Evaluate mathey = new Evaluate();
            double exp_result = 0.625;
            double act_result = mathey.calculate("5/8");
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureEvaluateClassLastCommandWorks()
        {
            Evaluate mathey = new Evaluate();
            double exp_result = mathey.calculate("1+2");
            double act_result = mathey.calculate("last");
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureEvaluateClassLastqCommandWorks()
        {
            Evaluate mathey = new Evaluate();
            double exp_result = mathey.calculate("1+2");
            double act_result = mathey.calculate("lastq");
            Assert.AreEqual(exp_result, act_result);
        }
    }
}
