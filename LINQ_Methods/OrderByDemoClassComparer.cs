using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class OrderByDemoClassComparer : IComparer<OrderByDemoClass>
    {
        public int Compare(OrderByDemoClass x, OrderByDemoClass y)
        {
            bool xIsNull = ReferenceEquals(x, null);
            bool yIsNull = ReferenceEquals(y, null);

            if (!xIsNull && !yIsNull)
            {
                if (string.Compare(x.f2, y.f2, true) == 0)
                    return x.f3.CompareTo(y.f3);
                else
                    return string.Compare(x.f2, y.f2, true);
            }
            else
                return 0;
        }
    }
}
