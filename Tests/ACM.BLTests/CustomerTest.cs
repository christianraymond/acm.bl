using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Uncle";
            customer.FirstName = "Bob";
            string expected = "Uncle, Bob" ;
            //--Act
            string Result = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, Result);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "James";
            string expected = "James";
            //--Act
            string Result = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, Result);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Steve";
            string expected = "Steve";
            //--Act
            string Result = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, Result);
        }

        [TestMethod]
        public void StaticModifierUsage()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Greg";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Warren";
            Customer.InstanceCount += 1;

            //--Assert
            Assert.AreEqual(2, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Jeremy";
            customer.LastName = "ramos";
            customer.EmailAddress = "rjeremy@gmail.com";
            //Act
            var expected = true;
            var actual = customer.Validate();
            //Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMisssingFirstName()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "rjeremy@gmail.com";
            //Act
            var expected = false;
            var actual = customer.Validate();
            //Asset
            Assert.AreEqual(expected, actual);
        }
    }
}
