using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Methods
{
    class PersonBaseClass : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ComplexKey Key { get; set; }


        public PersonBaseClass(string fn, string ln, ComplexKey key)
        {
            FirstName = fn;
            LastName = ln;
            Key = key;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is PersonBaseClass)
            {
                PersonBaseClass tmp = obj as PersonBaseClass;
                return
                    string.Compare(FirstName, tmp.FirstName, true) == 0 &&
                    string.Compare(LastName, tmp.LastName, true) == 0 &&
                    Key == tmp.Key;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            long tmp = (long)FirstName.GetHashCode() + LastName.GetHashCode() + Key.GetHashCode();
            return tmp.GetHashCode();
        }
    }

    class Person : PersonBaseClass, ICloneable, IEqualityComparer<string>, IComparable
    {
        // If you add properties here, remember to update the Clone() method.
        public int Age { get; set; }
        public Company Employer { get; set; }

        public Person(string fn, string ln, int age, ComplexKey key) : base(fn, ln, key)
        {
            Age = age;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Age}: {Employer?.ToString()}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person p = obj as Person;
                return base.Equals(p) && Age == p.Age && Employer == p.Employer;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            long tmp = (long)base.GetHashCode() + Age.GetHashCode() + Employer.GetHashCode();
            return tmp.GetHashCode();
        }

        public Person GetClone()
        {
            return (Person)Clone();
        }

        public new object Clone()
        {
            Person newPerson = (Person)MemberwiseClone();
            newPerson.Employer = Employer.GetClone();
            return newPerson;
        }

        public bool Equals(string x, string y)
        {
            return string.Compare(x, y, true) == 0;
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }

        public int CompareTo(object obj) // Default comparer for Max(), Min(), OrderBy()
        {
            if (obj is Person)
            {
                var p = obj as Person;

                if (p.Employer != null && Employer != null)
                {
                    var thisCompanyAge = Employer.YearFounded > 0 ? DateTime.Now.Year - Employer.YearFounded : 0;
                    var objCompanyAge = p.Employer.YearFounded > 0 ? DateTime.Now.Year - p.Employer.YearFounded : 0;
                    return thisCompanyAge.CompareTo(objCompanyAge);
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public static bool operator ==(Person a, Person b)
        {
            return Equals(a, b);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !Equals(a, b);
        }
    }
}