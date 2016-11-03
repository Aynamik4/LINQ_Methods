using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class MaxMinClass : IComparable
    {
        public decimal? NullableDecimal { get; set; }
        public decimal ADecimal { get; set; }
        public double? NullableDouble { get; set; }
        public double ADouble { get; set; }
        public float? NullableFloat { get; set; }
        public float AFloat { get; set; }
        public int? NullableInt { get; set; }
        public int AnInt { get; set; }
        public long? NullableLong { get; set; }
        public long ALong { get; set; }

        public int CompareTo(object obj)
        {
            int returnValue = 0;

            if (obj is MaxMinClass)
            {
                MaxMinClass other = obj as MaxMinClass;
                returnValue = AnInt.CompareTo(other.AnInt);
            }

            return returnValue;
        }
    }
}
