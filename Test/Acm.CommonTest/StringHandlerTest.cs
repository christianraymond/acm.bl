using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acm.Common;

namespace Acm.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            //Arrange
            var source = "AppleComputer";
            var expected = "Apple Computer";

            //Act
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpaceBeforeCheckingValidation()
        {
            //Arrange
            var source = "Apple Computer";
            var expected = "Apple Computer";

            //Act
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
    }
}
