using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class FirstNameAge : IEqualityComparer<FirstNameAge>
    {
        public string FirstName { get; set; }
        public int Age { get; set; }

        public FirstNameAge(string fn, int a)
        {
            FirstName = fn;
            Age = a;
        }

        public override string ToString()
        {
            return $"[{FirstName}-{Age}]";
        }

        public bool Equals(FirstNameAge x, FirstNameAge y)
        {
            return x.ToString().Equals(y.ToString());
        }

        public int GetHashCode(FirstNameAge obj)
        {
            return ToString().GetHashCode();
        }
    }
}
