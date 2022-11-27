using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FacetedBuilder
{
    public class StaffBuilder
    {
        // the object we're going to build
        protected Staff staff = new(); // this is a reference!

        public StaffAddressBuilder Lives => new(staff);
        public StaffJobBuilder Works => new(staff);

        public static implicit operator Staff(StaffBuilder sb)
        {
            return sb.staff;
        }
    }
}
