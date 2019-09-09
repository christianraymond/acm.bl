using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acm.Common;

namespace Acm.CommonTest
{
    [TestClass]
    public class InsertSpaceBeforeCheckingTest
    {
        [TestMethod]
        public void InsertSpaceBeforeCheckingValidation()
        {
            //Arrange
            var source = "Apple Computer";
            var expected = "Apple Computer";

            //Act
            var actual = StringHandler.InsertSpaces(source);
            Assert.AreEqual(expected, actual);
        }
    }
}
