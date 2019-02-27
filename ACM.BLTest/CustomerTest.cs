using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange

            // objetcs are reference types
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            // arrange
            var C = new Customer();
            C.LastName = "Baggins";
            C.EmailAddress = "fbaggins@hobttion.me";

            bool expected = true;

            // act
            var actual = C.Validate();

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCustomerId()
        {
            var SetId = 1;
            var C1 = new Customer(SetId);
            var cId = C1.CustomerId;

            Assert.AreEqual(SetId, cId);
        }
    }
}
    


