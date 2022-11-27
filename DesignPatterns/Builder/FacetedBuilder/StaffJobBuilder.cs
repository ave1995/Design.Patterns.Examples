using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FacetedBuilder
{
    public class StaffJobBuilder : StaffBuilder
    {
        public StaffJobBuilder(Staff staff)
        {
            this.staff = staff;
        }

        public StaffJobBuilder At(string companyName)
        {
            staff.CompanyName = companyName;
            return this;
        }

        public StaffJobBuilder AsA(string position)
        {
            staff.Position = position;
            return this;
        }

        public StaffJobBuilder Earning(int annualIncome)
        {
            staff.AnnualIncome = annualIncome;
            return this;
        }
    }
}
