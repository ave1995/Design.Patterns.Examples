using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FacetedBuilder
{
    public class StaffAddressBuilder : StaffBuilder
    {
        // might not work with a value type!
        public StaffAddressBuilder(Staff staff)
        {
            this.staff = staff;
        }

        public StaffAddressBuilder At(string streetAddress)
        {
            staff.StreetAddress = streetAddress;
            return this;
        }

        public StaffAddressBuilder WithPostcode(string postcode)
        {
            staff.Postcode = postcode;
            return this;
        }

        public StaffAddressBuilder In(string city)
        {
            staff.City = city;
            return this;
        }
    }
}
