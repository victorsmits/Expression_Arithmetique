using NUnit.Framework;
using System;
namespace Expression_arithmétique
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void TestEvaluatePostfixExpr()
        {
            //infixe test
            Assert.AreEqual(3, MainClass.EvaluatePostfixExpr("1+2"));
            //postfixe test
            Assert.AreEqual(3, MainClass.EvaluatePostfixExpr("12+"));
            //préfixe test
            Assert.AreEqual(3, MainClass.EvaluatePostfixExpr("+12"));
            //infixe groupe test
            Assert.AreEqual(6, MainClass.EvaluatePostfixExpr("(1+2)+3"));
            Assert.AreEqual(9, MainClass.EvaluatePostfixExpr("(1+2)*3"));
            Assert.AreEqual(0, MainClass.EvaluatePostfixExpr("(1+2)-3"));
            Assert.AreEqual(1, MainClass.EvaluatePostfixExpr("(1+2)/3"));
            Assert.AreEqual(8, MainClass.EvaluatePostfixExpr("(1+2)+(3+2)"));
            //infixe groupe test
            //Assert.AreEqual(8, MainClass.EvaluatePostfixExpr("++12+32"));
            //postfixe groupe test
            //Assert.AreEqual(8, MainClass.EvaluatePostfixExpr("12+32++"));


        }
    }
}
