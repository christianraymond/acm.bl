using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void Retrievevalid()
        {
            //Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "rjeremy@gmail.com",
                FirstName = "Jeremy",
                LastName = "Billiant"

            };

            //Act
            var actual = customerRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
