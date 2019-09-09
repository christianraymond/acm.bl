using Acm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = CustomerId;
            AddressList = new List<Address>();
        }

        internal List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

        public static int InstanceCount { get; set; }
        private string _lastName;
        public string LastName {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        //Validate the Customer if these statement are true or false;
        /*===== <return></return> ====== */
        public override bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (String.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid; 
        }
    }
}
