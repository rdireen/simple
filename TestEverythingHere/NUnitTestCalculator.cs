// If I put header information in here will I be able to slurp it???
using NUnit.Framework;
using System;
using Calculator;

namespace TestEverythingHere
{
    [TestFixture ()]
    public class NUnitTestCalculator
    {
        [Test ()]
        public void TestCase ()
        {
           
        }

        [Test ()]
        public void TestAdd ()
        {
            var calc = new Calculate (5, 5);
            Assert.AreEqual (10, calc.add ());
        }

        [Test ()]
        public void TestSub ()
        {
            var calc = new Calculate (7, 5);
            Assert.AreEqual (2, calc.sub ());
        }

        [Test ()]
        public void TestMult ()
        {
            var calc = new Calculate (2, 2);
            Assert.AreEqual (4, calc.mult ());
        }

        [Test ()]
        public void TestDiv ()
        {
            var calc = new Calculate (4, 2);
            Assert.AreEqual (2, calc.div ());

            var calce = new Calculate (4, 0);

            //calce.div() will throw an error if it divides by zero.
            //This checks for that.
            Assert.Throws<DivideByZeroException>(()=>calce.div());
        }
    }
}

