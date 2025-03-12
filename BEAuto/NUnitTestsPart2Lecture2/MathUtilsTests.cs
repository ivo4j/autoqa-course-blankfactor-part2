using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsPart2Lecture2
{
    [TestFixture]
    internal class MathUtilsTests
    {
        [Test]
        public void IsPrimeTestWithPrimes()
        {
            Assert.That(MathUtils.IsPrime(2), Is.True);
            Assert.That(MathUtils.IsPrime(3), Is.True);
            Assert.That(MathUtils.IsPrime(17), Is.True);
        }

        [Test]
        public void IsPrimeTestWithNonPrimes()
        {
            Assert.That(MathUtils.IsPrime(4), Is.False);
            Assert.That(MathUtils.IsPrime(6), Is.False);
            Assert.That(MathUtils.IsPrime(20), Is.False);
        }

        [Test]
        public void IsPrimeTestWithNegativeNumbersZeroOrOne()
        {
            Assert.That(MathUtils.IsPrime(0), Is.False);
            Assert.That(MathUtils.IsPrime(1), Is.False);
            Assert.That(MathUtils.IsPrime(-3), Is.False);
        }
    }
}
