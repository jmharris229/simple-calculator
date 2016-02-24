using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void EnsureICanCallNewClass()
        {
            Expression math_add = new Expression();
            Assert.IsNotNull(math_add);
        }
    }
}
