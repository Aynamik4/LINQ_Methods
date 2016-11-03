using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class ComplexKey : IEqualityComparer<ComplexKey>, ICloneable
    {
        int intKey;
        string stringKey;
        bool boolKey;

        public ComplexKey(int intKey, string stringKey, bool boolKey)
        {
            this.intKey = intKey;
            this.stringKey = stringKey;
            this.boolKey = boolKey;
        }

        public bool Equals(ComplexKey x, ComplexKey y)
        {
            bool xIsNull = ReferenceEquals(x, null);
            bool yIsNull = ReferenceEquals(y, null);
            bool isEqual = false;

            if (!xIsNull && !yIsNull)
            {
                isEqual =
                x.intKey == y.intKey &&
                x.boolKey == y.boolKey &&
                string.Compare(x.stringKey, y.stringKey, true) == 0;
            } // Yes, false even if both x and y are null.

            return isEqual;
        }

        public int GetHashCode(ComplexKey obj)
        {
            long tmp = (long)obj.intKey.GetHashCode() + obj.stringKey.GetHashCode() + obj.boolKey.GetHashCode();
            return tmp.GetHashCode();
        }

        public override string ToString()
        {
            return $"[{intKey} {stringKey} {boolKey}]";
        }

        public override bool Equals(object obj)
        {
            if (obj is ComplexKey)
            {
                var other = obj as ComplexKey;
                return Equals(this, other);
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return GetHashCode(this);
        }

        public ComplexKey CloneThis()
        {
            object o = Clone();

            if (o is ComplexKey)
                return (ComplexKey)o;
            else
                return null;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        static public bool operator ==(ComplexKey x, ComplexKey y)
        {
            bool xIsNull = ReferenceEquals(x, null);
            bool yIsNull = ReferenceEquals(y, null);
            bool isEqual = false;

            if (!xIsNull && !yIsNull)
            {
                isEqual = x.Equals(x, y);
            }  // Yes, false even if both x and y are null.

            return isEqual;
        }
        static public bool operator !=(ComplexKey x, ComplexKey y)
        {
            bool xIsNull = ReferenceEquals(x, null);
            bool yIsNull = ReferenceEquals(y, null);
            bool isEqual = false;

            if (!xIsNull && !yIsNull)
            {
                isEqual = !x.Equals(x, y);
            }

            return isEqual;
        }
    }
}