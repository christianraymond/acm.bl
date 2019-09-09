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
            var actual = StringHandler.InsertSpaces(source);
            Assert.AreEqual(expected, actual);
        }
    }
}
