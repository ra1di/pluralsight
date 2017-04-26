using System;
using System.Collections.Generic;

namespace RS.BL
{
    public class Customer
    {
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
