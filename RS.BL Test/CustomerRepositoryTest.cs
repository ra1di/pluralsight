using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.BL2;
using RS.BL;
using System.Collections.Generic;

namespace RS.BL_Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExiting()
        {
            //-- arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
            };
            //-- ACT

            var actual = customerRepository.Retrieve(1);

            //-- assert
            //Assert.AreEqual(expected, actual); //Comparison is not equal even if they have same
            //properties!!! because they are not refference to same object
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);

        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",

                //colllection initializers
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag end",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };
            //-- ACT

            var actual = customerRepository.Retrieve(1);

            //-- assert
            //Assert.AreEqual(expected, actual); //Comparison is not equal even if they have same
            //properties!!! because they are not refference to same object

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }


        }
    }
}

