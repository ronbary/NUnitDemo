using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitDemo
{
    [TestFixture]
    class PalindromeTest
    {


        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void isPalindrome_ValidString_ReturnTrue()
        {
            CheckPalindrome obj = new CheckPalindrome();

            Assert.IsTrue( obj.IsPalindrom("abcba"));

        
        }


        [Test]
        public void isPalindrome_InvalidString_ReturnFalse()
        {
            CheckPalindrome obj = new CheckPalindrome();

            Assert.IsFalse(obj.IsPalindrom("agcba"));

        }

        [TearDown]
        public void TearDown()
        {

        }




    }
}
