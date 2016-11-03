using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class PersonBasedCompanyComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return string.Compare(x.Employer.CompanyName, y.Employer.CompanyName, true) == 0;
        }

        public int GetHashCode(Person obj)
        {
            if (obj.Employer.CompanyName != null)
                return obj.Employer.CompanyName.ToLower().GetHashCode();
            else
                return 0;
        }
    }
}
