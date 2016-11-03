using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace LINQ_Methods
{
    class Company : ICloneable
    {
        public string CompanyName { get; set; }
        public int YearFounded { get; set; }
        public string Country { get; set; }
        public List<string> Addresses { get; set; }

        public Company()
        {
            Addresses = new List<string>();
        }

        public Company(IEnumerable<string> addresses)
        {
            Addresses = new List<string>(addresses);
        }

        public override string ToString()
        {
            if (Addresses.Count > 0)
            {
                var resultSet = Addresses
                    .Aggregate((s1, s2) => s1 + ", " + s2);

                if (resultSet == null)
                    resultSet = "N/A";

                return $"[{CompanyName}, {YearFounded}, {Country}, {resultSet}]";
            }
            else
                return "N/A";
        }

        public override bool Equals(object obj)
        {
            Company c = null;
            bool isEqual = false;

            if (obj is Company)
            {
                c = obj as Company;
                isEqual = string.Compare(CompanyName, c.CompanyName, true) == 0 &&
                string.Compare(Country, c.Country, true) == 0 &&
                YearFounded == c.YearFounded;

                if (isEqual)
                {
                    var str1 = As1OrderedLowerCaseString(Addresses);
                    var str2 = As1OrderedLowerCaseString(c.Addresses);

                    if (str1 == null && str2 == null)
                        isEqual = true;
                    else
                        if (str1 != null && str2 != null)
                        isEqual = string.Compare(str1, str2, true) == 0;
                }
            }

            return isEqual;
        }

        private string As1OrderedLowerCaseString(List<string> los)
        {
            if (los.Count > 0)
                return los?
                    .OrderBy(s => s.ToLower())
                    .Aggregate((s1, s2) => s1.ToLower() + s2.ToLower());
            else
                return string.Empty;
        }

        public override int GetHashCode()
        {
            string tmpStr = As1OrderedLowerCaseString(Addresses);
            int hash = (tmpStr == null) ? 0.GetHashCode() : tmpStr.GetHashCode();
            long tmp = (long)CompanyName.GetHashCode() + YearFounded.GetHashCode() + Country.GetHashCode() + hash;
            return tmp.GetHashCode();
        }

        public Company GetClone()
        {
            return (Company)Clone();
        }

        public object Clone()
        {
            Company c = (Company)MemberwiseClone();
            c.Addresses = new List<string>(Addresses);
            return c;
        }

        // Just for fun!
        public static implicit operator Company(int year)
        {
            Company c = new Company();
            c.Addresses.Add("Göteborg");
            c.CompanyName = "Karin Kula AB";
            c.YearFounded = year;
            return c;
        }

        public static bool operator ==(Company a, Company b)
        {
            return Equals(a, b);
        }
        public static bool operator !=(Company a, Company b)
        {
            return !Equals(a, b);
        }
    }
}
