using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class CountryBasedCompanyComparer : IEqualityComparer<Company>
    {
        public bool Equals(Company x, Company y)
        {
            bool sameCountry = string.Compare(x.Country, y.Country, true) == 0;
            return sameCountry;
        }

        public int GetHashCode(Company obj)
        {
            return obj.Country.GetHashCode();
        }
    }
}
