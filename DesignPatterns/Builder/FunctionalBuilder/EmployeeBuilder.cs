using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FunctionalBuilder
{
    public sealed class EmployeeBuilder : FunctionalBuilder<Employee, EmployeeBuilder>
    {
        public EmployeeBuilder Called(string name) => Do(p => p.Name = name);
    }
}
