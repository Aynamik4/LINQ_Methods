using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class KeyClass : IEqualityComparer<KeyClass>
    {
        int lastNameLen;

        public KeyClass(string s)
        {
            lastNameLen = s.Length;
        }

        public override string ToString()
        {
            return $"-[{lastNameLen}-]";
        }

        public bool Equals(KeyClass x, KeyClass y)
        {
            return x.lastNameLen == y.lastNameLen;
        }

        public int GetHashCode(KeyClass obj)
        {
            return lastNameLen.GetHashCode();
        }
    }
}
