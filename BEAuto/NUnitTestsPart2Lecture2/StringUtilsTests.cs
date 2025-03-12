using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsPart2Lecture2
{
    [TestFixture]
    internal class StringUtilsTests
    {

        [Test]
        public void ReverseStringHelloReturnsOlleh()
        {
            StringUtils stringUtils = new StringUtils();
            string result = stringUtils.ReverseString("hello");
            Assert.That("olleh", Is.EqualTo(result));
        }

        [Test]
        public void ReverseStringEmptyString()
        {
            StringUtils stringUtils = new StringUtils();
            string result = stringUtils.ReverseString("");
            Assert.That("", Is.EqualTo(result));
        }

        [Test]
        public void ReverseStringSpecialChars() 
        {
            StringUtils stringUtils = new StringUtils();
            string result = stringUtils.ReverseString("! @ # $ % ^ & * ( ) - _ = + \\ | [ ] { } ; : / ? . >");
            Assert.That("> . ? / : ; } { ] [ | \\ + = _ - ) ( * & ^ % $ # @ !", Is.EqualTo(result));
        }


    }
}
