using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        //Retrieve one address
        public Address Retrieve(int addressId)
        {
            //Create the intance of the address Class
            //Pass in the requested id
            Address address = new Address(addressId);
            if(address.AddressId == 1)
            {
                address.AddressType = 1;
                address.StreetLineOne = "BeaconValley";
                address.StreetLineTwo = "Buick";
                address.City = "Cape Town"; 
                address.Country = "Middle East";
            }

            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLineOne = "Dka",
                StreetLineTwo = "Jbt",
                PostCode = "234",
                City = "SU",
                Country = "Dj"

            };
            addressList.Add(address);

            Address address1 = new Address(2)
            {
                AddressType = 2,
                StreetLineOne = "Fba",
                StreetLineTwo = "IKbi",
                PostCode = "32d",
                City = "Ma",
                Country = "GH"

            };
            addressList.Add(address);
            return addressList;
        }
        public bool Save(Address addressId)
        {
            return true;
        }
    }
}
