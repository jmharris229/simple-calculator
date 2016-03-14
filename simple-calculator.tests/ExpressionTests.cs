using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace simple_calculator.tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void EnsureICanCallNewExpressionClass()
        {
            Expression math_add = new Expression();
            Assert.IsNotNull(math_add);
        }
        [TestMethod]
        public void EnsureNoSpacesPresentInExpression()
        {
            Expression math_add = new Expression();
            string exp = math_add.RecieveEquation();
            string expected = "1+2";
            Assert.AreEqual(expected, exp);
        }
        [TestMethod]
        public void EnsureCapturingTerm1InExpression()
        {
            Evaluate mathey = new Evaluate();
            Expression math_add = new Expression();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            ParsedExp exp = math_add.collectTerms("1+2", dict, constants);
            //tests to prove that the operator and terms were saved as numbers

            Assert.AreEqual(typeof(int),exp.term1.GetType());
        }
        [TestMethod]
        public void EnsureCapturingTerm2inExpression()
        {
            Evaluate mathey = new Evaluate();
            Expression math_add = new Expression();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            ParsedExp exp = math_add.collectTerms("1+2", dict, constants);
            //tests to prove that the operator and terms were saved as numbers

            Assert.AreEqual(typeof(int), exp.term2.GetType());
        }
        [TestMethod]
        public void EnsureCapturingOperatorinExpression()
        {
            Expression math_add = new Expression();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            ParsedExp exp = math_add.collectTerms("1+2", dict, constants);
            int opPresent = '+';
            //prove that the operator was saved and ensures that the correct operation was called
            Assert.AreEqual(opPresent, exp.oper);
        }
        [TestMethod]
        public void EnsureEvaluatHandleCorrectExpression()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            double result = mathey.calculate("1+2", dict, constants);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTermException))]
        public void EnsureEvaluateHandleBadTermsExpressionEndOp()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            mathey.calculate("1+", dict, constants);
        }
        [TestMethod]
        [ExpectedException(typeof(NoOperatorException))]
        public void EnsureEvaluateHandleBadTermsExpressionBegOp()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            mathey.calculate("%1", dict, constants);
            
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTermException))]
        public void EnsureEvaluateHandleBadTermsExpressionExtraOp()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            mathey.calculate("1+%2", dict, constants);
        }
        [TestMethod]
        [ExpectedException(typeof(NoOperatorException))]
        public void EnsureEvaluateHandleNoOperatorExpression()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            mathey.calculate("1", dict, constants);
        }
        [TestMethod]
        public void EnsureCollectTermsHandleNegativeInFirstTerm()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            double act_result = mathey.calculate("-1+2", dict, constants);
            int exp_result = 1;
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureCollectTermsHandleNegativeSecondTerm()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            double act_result = mathey.calculate("1+-2", dict, constants);
            int exp_result = -1;
            Assert.AreEqual(exp_result, act_result);
        }
    }
}
