using RS.BL2;
using System;
using System.Collections.Generic;

namespace RS.BL
{

    public class Customer
    {
        public Customer()
            : this(0) //constructor chaining, calling another constructor
        {

        }

        public Customer(int customerId)
        {

            CustomerId = customerId;
            AddressList = new List<Address>(); //full it with null
        }
        public List<Address> AddressList { get; set; } //relacja miedzy Customer class a AddressClass

        public static int InstanceCount { get; set; }

        //with code inside
        public string LastName;
        private string _lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }
        //without code inside
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;

            }
           
        }

        public Customer Retrieve(int CustomerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {

            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;

            return isValid;
        }

        
    }
}
