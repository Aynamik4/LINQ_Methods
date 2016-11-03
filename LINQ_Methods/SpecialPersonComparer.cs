using System.Collections.Generic;

namespace LINQ_Methods
{
    class SpecialPersonComparer : IEqualityComparer<Person>
    {

        /// <summary>
        /// Consider two Persons equal if they have the same employer and
        /// have the same first name.
        /// </summary>
        /// <param name="x">Person x</param>
        /// <param name="y">Person y</param>
        /// <returns>True if the two persons are considered equal.</returns>
        public bool Equals(Person x, Person y)
        {
            bool eql = string.Compare(x.Employer.CompanyName, y.Employer.CompanyName, true) == 0;
            eql = eql && string.Compare(x.FirstName, y.FirstName, true) == 0;
            return eql;
        }

        /// <summary>
        /// Return the same hash code if two Persons they have the same
        /// employer and have the same first name.
        /// </summary>
        /// <param name="obj">Person to get hash code for</param>
        /// <returns>Hash code</returns>
        public int GetHashCode(Person obj)
        {
            string tmp = obj.Employer.CompanyName.ToLower() + obj.FirstName.ToLower();
            return tmp.GetHashCode();
        }
    }

}
