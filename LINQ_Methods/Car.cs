using System;
using System.Collections.Generic;

namespace LINQ_Methods
{
    class Car : ICloneable, IEqualityComparer<Car>
    {
        public string CarName { get; set; }
        public int Speed { get; set; }
        public ConsoleColor Color { get; set; }

        /* Note: Key ignored when compared using the default equality
         * comparer. Use the IEqualityComparer<Car> methods to compare cars
         * by Key (ComplexKey) and Key ONLY.
         */
        public ComplexKey Key { get; set; }

        public Car(string cn, int sp, ConsoleColor c, ComplexKey k)
        {
            CarName = cn;
            Speed = sp;
            Color = c;
            Key = k;
        }

        public override string ToString()
        {
            return $"Name: {(CarName + ',').PadRight(16)} Km/h: {(Speed + ",").PadRight(4)} Color: {Color}";
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;

            if (obj is Car)
            {
                Car c = obj as Car;
                isEqual = string.Compare(CarName, c.CarName, true) == 0 &&
                    Speed == c.Speed &&
                    Color == c.Color /*&&*/
                                     /*Key == c.Key*/;
            }

            return isEqual;
        }

        public override int GetHashCode()
        {
            long tmp = (long)CarName.GetHashCode() + Speed.GetHashCode() + Color.GetHashCode()/* + Key.GetHashCode()*/;
            return tmp.GetHashCode();
        }

        public static bool operator ==(Car a, Car b)
        {
            bool isEqual = false;
            bool aIsNull = ReferenceEquals(a, null);
            bool bIsNull = ReferenceEquals(b, null);

            if (!aIsNull && !bIsNull)
                isEqual = a.Equals(b);
            else
                isEqual = aIsNull && bIsNull;

            return isEqual;
        }

        public static bool operator !=(Car a, Car b)
        {
            bool isEqual = false;
            bool aIsNull = ReferenceEquals(a, null);
            bool bIsNull = ReferenceEquals(b, null);

            if (!aIsNull && !bIsNull)
                isEqual = !a.Equals(b);
            else
                isEqual = !(aIsNull && bIsNull);

            return isEqual;
        }

        public Car CloneThis()
        {
            return (Car)Clone();
        }

        public object Clone()
        {
            Car c = (Car)MemberwiseClone();
            c.Key = Key.CloneThis();
            return c;
        }

        public bool Equals(Car x, Car y)
        {
            bool isEqual = false;
            bool xIsNull = ReferenceEquals(x, null);
            bool yIsNull = ReferenceEquals(y, null);

            if (!xIsNull && !yIsNull)
                isEqual = x.Key == y.Key;

            return isEqual;
        }

        public int GetHashCode(Car obj)
        {
            if (!ReferenceEquals(obj, null) && !ReferenceEquals(obj.Key, null))
                return obj.Key.GetHashCode();
            else
                return 0.GetHashCode();
        }
    }
}