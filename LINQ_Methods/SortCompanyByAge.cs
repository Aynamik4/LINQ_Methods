using System;
using System.Collections.Generic;

namespace LINQ_Methods
{
    internal class SortCompanyByCompanyAge : IComparer<Company>
    {
        public int Compare(Company x, Company y)
        {
            return (DateTime.Now.Year - x.YearFounded).CompareTo(DateTime.Now.Year - y.YearFounded);
        }
    }
}