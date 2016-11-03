using System;
using System.Collections.Generic;

namespace LINQ_Methods
{
    internal class SortPersonsByCompanyNameThenByFirstName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int compareResult;

            if (x.Employer != null && y.Employer != null)
            {
                compareResult = string.Compare(x.Employer.CompanyName, y.Employer.CompanyName, true);

                if (compareResult == 0)
                    compareResult = string.Compare(x.FirstName, y.FirstName, true);
            }
            else
                compareResult = string.Compare(x.FirstName, y.FirstName, true);

            return compareResult;
        }
    }
}