using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.BL;

namespace RS.BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- arrange (preparate)
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //-- act

            string actual = customer.FullName;

            //-- assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- arrange
            Customer cust = new Customer();
            cust.LastName = "Baggins";
            string expected = "Baggins";

            //-- act (ual)
            string actual = cust.FullName;

            //-- assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- arrange
            Customer cust = new Customer();
            cust.FirstName = "Bilbo";
            string expected = "Bilbo";

            //-- act (ual)
            string actual = cust.FullName;

            //-- assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //-- arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //-- assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAdress = "fbaggins@hobbiton.me";

            var expected = false;

            //--act
            var actual = customer.Validate();

            //-- assert
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--arrange
            var customer = new Customer();
           // customer.LastName = "Baggins";
            customer.EmailAdress = "fbaggins@hobbiton.me";

            var expected = false;

            //--act
            var actual = customer.Validate(); //zwroci wartosc z funkcji validate, przy braku imienia
            //bedzie to false

            //-- assert
            Assert.AreEqual(expected, actual);
        }
    }
}
