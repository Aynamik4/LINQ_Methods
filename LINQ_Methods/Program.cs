/* This project demonstrates all (C# 6) the methods of the static
 * System.Linq.Enumerable class. */

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using static System.Console;
using static System.Environment;
using UtilsLibrary;


namespace LINQ_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = CreateListOfPersons();

            #region ToArray()
            //ToArray(persons);
            #endregion ToArray()

            #region TList()
            //ToList(persons);
            #endregion TList()

            #region ToDictionary()
            //ToDictionary_Ovrld_01(persons);
            //ToDictionary_Ovrld_02(persons);
            //ToDictionary_Ovrld_03(persons);
            //ToDictionary_Ovrld_04(persons);
            #endregion ToDictionary()

            #region ToLookup()
            //ToLookup_Ovrld_01(persons);
            //ToLookup_Ovrld_02(persons);
            //ToLookup_Ovrld_03(persons);
            //ToLookup_Ovrld_04(persons);
            #endregion ToLookup

            #region Aggregate
            //Aggregate_Ovrld_01();
            //Aggregate_Ovrld_02();
            //Aggregate_Ovrld_03(persons);
            #endregion Aggregate

            #region All
            //All(persons);
            #endregion All

            #region Any
            //Any_Ovrld_01(persons);
            //Any_Ovrld_02(persons);
            #endregion Any

            #region AsEnumerable
            //AsEnumerable();
            #endregion AsEnumerable

            #region AsParallel
            //AsParallel(persons);
            #endregion AsParallel

            #region AsQueryable
            //AsQueryable(persons);
            #endregion AsQueryable

            #region AsReadOnly
            //AsReadOnly(persons);
            #endregion AsReadOnly

            #region Average
            //Average(persons);
            #endregion Average

            #region Cast
            //Cast(persons);
            #endregion Cast

            #region Concat - Se även // Union, Intersect
            //Concat();
            #endregion Concat

            #region Contains
            //ContainsOvrld_01(persons);
            //ContainsOvrld_02(persons);
            #endregion Contains

            #region Count
            //Count_Ovrld_01(persons);
            //Count_Ovrld_02(persons);
            #endregion Count

            #region DefaultIfEmpty
            //DefaultIfEmpty_Ovrld_01(new List<Person>()); // Note: Empty sequence!
            //DefaultIfEmpty_Ovrld_02(new List<PersonBaseClass>()); // Note: Empty sequence!
            #endregion DefaultIfEmpty

            #region Distinct
            //Distinct_Ovrld_01(persons);
            //Distinct_Ovrld_02(persons);
            #endregion Distinct

            #region ElementAt
            //ElementAt(persons);
            #endregion ElementAt

            #region ElementAtOrDefault
            //ElementAtOrDefault(persons);
            #endregion ElementAtOrDefault

            #region Except
            //Except_Ovrld_01();
            //Except_Ovrld_02(persons);
            #endregion Except

            #region First
            //First_Ovrld_01(persons);
            //First_Ovrld_02(persons);
            #endregion First

            #region FirstOrDefault
            //FirstOrDefault_Ovrld_01(persons);
            //FirstOrDefault_Ovrld_02(persons);
            #endregion FirstOrDefault

            #region GroupBy
            //GroupBy_Ovrld_01(persons);
            //GroupBy_Ovrld_02(persons);
            //GroupBy_Ovrld_03(persons);
            //GroupBy_Ovrld_04(persons);
            //GroupBy_Ovrld_05(persons);
            //GroupBy_Ovrld_06(persons);
            //GroupBy_Ovrld_07(persons);
            //GroupBy_Ovrld_08(persons);
            #endregion GroupBy

            #region Special: Anonymous Method Instead Of Lambda
            //AnonymousMethodInsteadOfLambda(persons);
            #endregion Special: Anonymous Method Instead Of Lambda

            #region Join
            //Join_Ovrld_01();
            //Join_Ovrld_02();
            #endregion

            #region GroupJoin
            //GroupJoin_Ovrld_01();
            //GroupJoin_Ovrld_02();
            #endregion

            #region Intersect
            //Intersect_Ovrld_01();
            //Intersect_Ovrld_02();
            #endregion

            #region Last
            //Last_Ovrld_01(persons);
            //Last_Ovrld_02(persons);
            #endregion

            #region LastOrDefault
            //LastOrDefault_Ovrld_01(persons);
            //LastOrDefault_Ovrld_02(persons);
            #endregion

            #region LongCount
            //LongCount_Ovrld_01(persons);
            //LongCount_Ovrld_02(persons);
            #endregion

            #region Max_Min
            //Max_Min_Ovrld_01(persons);
            //Max_Min_Ovrld_02To11();
            //Max_Min_Ovrld_12(persons);
            #endregion

            #region OfType
            //OfType();
            #endregion

            #region OrderBy
            //OrderBy_Ovrld_01(persons);
            //OrderBy_Ovrld_02(persons);
            #endregion

            #region OrderByDescending
            //OrderByDescending(persons);
            #endregion

            #region Reverse
            //Reverse(persons);
            #endregion

            #region Select
            //Select_Ovrld_01(persons);
            //Select_Ovrld_02(persons);
            #endregion

            #region SelectMany
            //SelectMany_Ovrld_01(persons);
            //SelectInsteadOfSelectMany(persons);
            //SelectMany_Ovrld_03(persons);
            //SelectMany_Ovrld_02(persons);
            //SelectMany_Ovrld_04(persons);
            #endregion

            #region SequenceEqual
            //SequenceEqual_Ovrld_01(persons);
            //SequenceEqual_Ovrld_02(persons);
            #endregion

            #region Single
            //Single_Ovrld_01();
            //Single_Ovrld_02();
            #endregion

            #region SingleOrDefault
            //SingleOrDefault_Ovrld_01(persons);
            //SingleOrDefault_Ovrld_02(persons);
            #endregion

            #region Skip
            //Skip(persons);
            #endregion

            #region SkipWhile
            //SkipWhile_Ovrld_01();
            //SkipWhile_Ovrld_02();
            #endregion

            #region Sum
            //Sum_Ovrld_01To10(persons);
            #endregion

            #region Take
            //Take(persons);
            #endregion

            #region TakeWhile
            //TakeWhile_Ovrld_01();
            //TakeWhile_Ovrld_02();
            #endregion

            #region Union
            //Union_Ovrld_01();
            //Union_Ovrld_02();
            #endregion

            #region Where
            //Where_Ovrld_01(persons);
            //Where_Ovrld_02(persons);
            #endregion

            #region Zip
            //Zip(persons);
            #endregion

            #region Empty
            //Empty();
            #endregion

            #region Range
            //Range();
            #endregion

            #region Repeat
            //Repeat();
            #endregion

            #region ThenBy
            //ThenBy_Ovrld_01();
            //ThenBy_Ovrld_02();
            #endregion

            #region ThenByDescending
            //ThenByDescending_Ovrld_01();
            //ThenByDescending_Ovrld_02();
            #endregion
        }

        private static void ThenByDescending_Ovrld_01()
        {
            /* ThenByDescending
             * ----------------
             * Performs a subsequent ordering of the elements in a sequence
             * in descending order according to a key.
             * 
             * Do note that ThenByDescending is an extension method on
             * IOrderedEnumerable<T>, that is the return type of the OrderBy
             * and OrderByDescending methods.
             */

            List<OrderByDemoClass> items = new List<OrderByDemoClass>
            {
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'b' },
                new OrderByDemoClass() { f1 = 2, f2 = "Cesar", f3 = 'a' },
                new OrderByDemoClass() { f1 = 1, f2 = "Xerxes", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Bertil", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'a' },
            };

            var resultSet = items
                .OrderBy(i => i.f1)
                .ThenByDescending(i => i.f2);

            foreach (var item in resultSet)
                WriteLine($"{item.f1} {item.f2} {item.f3}");
        }

        private static void ThenByDescending_Ovrld_02()
        {
            /* ThenByDescending
             * ----------------
             * Performs a subsequent ordering of the elements in a sequence
             * in descending order by using a specified comparer.
             * 
             * Do note that ThenByDescending is an extension method on
             * IOrderedEnumerable<T>, that is the return type of the OrderBy
             * and OrderByDescending methods.
             */

            List<OrderByDemoClass> items = new List<OrderByDemoClass>
            {
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'b' },
                new OrderByDemoClass() { f1 = 2, f2 = "Cesar", f3 = 'a' },
                new OrderByDemoClass() { f1 = 1, f2 = "Xerxes", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Bertil", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'a' },
            };

            var resultSet = items
                .OrderBy(i => i.f1)
                .ThenByDescending(i => i, new OrderByDemoClassComparer());

            foreach (var item in resultSet)
                WriteLine($"{item.f1} {item.f2} {item.f3}");

            // Git Test... Mera test
        }

        private static void ThenBy_Ovrld_01()
        {
            /* ThenBy
             * ------
             * Performs a subsequent ordering of the elements in a sequence
             * in ascending order according to a key.
             * 
             * Do note that ThenBy is an extension method on
             * IOrderedEnumerable<T>, that is the return type of the OrderBy
             * and OrderByDescending methods.
             */

            List<OrderByDemoClass> items = new List<OrderByDemoClass>
            {
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'b' },
                new OrderByDemoClass() { f1 = 2, f2 = "Cesar", f3 = 'a' },
                new OrderByDemoClass() { f1 = 1, f2 = "Xerxes", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Bertil", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'a' },
            };

            var resultSet = items
                .OrderBy(i => i.f1)
                .ThenBy(i => i.f2);

            foreach (var item in resultSet)
                WriteLine($"{item.f1} {item.f2} {item.f3}");
        }

        private static void ThenBy_Ovrld_02()
        {
            /* ThenBy
             * ------
             * Performs a subsequent ordering of the elements in a sequence
             * in ascending order by using a specified comparer.
             * 
             * Do note that ThenBy is an extension method on
             * IOrderedEnumerable<T>, that is the return type of the OrderBy
             * and OrderByDescending methods.
             */

            List<OrderByDemoClass> items = new List<OrderByDemoClass>
            {
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'b' },
                new OrderByDemoClass() { f1 = 2, f2 = "Cesar", f3 = 'a' },
                new OrderByDemoClass() { f1 = 1, f2 = "Xerxes", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Bertil", f3 = 'a' },
                new OrderByDemoClass() { f1 = 2, f2 = "Adam", f3 = 'a' },
            };

            var resultSet = items
                .OrderBy(i => i.f1)
                .ThenBy(i => i, new OrderByDemoClassComparer());

            foreach (var item in resultSet)
                WriteLine($"{item.f1} {item.f2} {item.f3}");
        }

        private static void Repeat()
        {
            /* Repeat
             * ------
             * Generates a sequence that contains one repeated value.
             */

            /* Create an array with 10 bool values initialized to false */
            var boolArray = Enumerable.Repeat(false, 10)
                .ToArray();

            foreach (bool b in boolArray)
                WriteLine(b);

            WriteLine();

            /* Do note that when the "element" parameter of the Repeat
             * method is of a reference type, each resulting element is
             * simply a reference to the same instance.*/

            /* Create a list that references the same Car instance three
             * times. */
            var listOfCars = Enumerable.Repeat(new Car("Volvo V90", 180, ConsoleColor.Yellow, null), 5)
                .ToList();

            listOfCars[0].CarName = "SAAB 95"; // Will, of course, change "all" cars!

            foreach (Car car in listOfCars)
                WriteLine(car);
        }

        private static void Range()
        {
            /* Range
             * -----
             * Generates a sequence of integral numbers within a specified
             * range.
             */

            var count = ConsoleUtils.ConsoleGetInt(1, 50, "How many ints would you like?: ", "Ivalid input!");
            var start = ConsoleUtils.ConsoleGetInt(int.MinValue, int.MaxValue - (count - 1), "Start on what value?: ", "Ivalid input!");

            var enumerable = Enumerable.Range(start, count).ToArray();

            for (int i = 0; i < enumerable.Count(); i++)
            {
                Write(enumerable[i]);

                if (i < enumerable.Count() - 1)
                    Write(", ");
            }

            WriteLine();
        }

        private static void Empty()
        {
            /* Empty
             * -----
             * Returns an empty IEnumerable<out T> that has the specified
             * type argument.
             * 
             * Not really a LINQ/Extension method.
             */

            var cars = Enumerable.Empty<Car>().ToList();

            cars.Add(new Car("Volvo", 110, ConsoleColor.Red, null));
            cars.Add(new Car("Saab", 120, ConsoleColor.Blue, null));

            foreach (var item in cars)
                WriteLine(item);
        }

        private static void Zip(List<Person> persons)
        {
            /* Zip
             * ---
             * Applies a specified function to the corresponding elements of two
             * sequences, producing a sequence of the results.
             * 
             * In this example the first person is combined with the first
             * car, the second person is then combined with the second car,
             * and so on. When the end of one of the two sequences is
             * reached the process stops.
             */

            List<Car> garage = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Daisy", 95, ConsoleColor.DarkRed, null)
            };

            var enumerable = persons
                .Zip(garage, (p, c) => new
                {
                    p.FirstName,
                    c.CarName
                });

            foreach (var anonymousItem in enumerable)
                WriteLine(anonymousItem);
        }

        private static void Where_Ovrld_01(List<Person> persons)
        {
            /* Where
             * -----
             * Filters a sequence of values based on a predicate.
             */

            var enumerable = persons
                .Where(p => p.Employer.CompanyName.ToLower().Contains("academ"));

            foreach (var item in enumerable)
                WriteLine(item);
        }

        private static void Where_Ovrld_02(List<Person> persons)
        {
            /* Where
             * -----
             * Filters a sequence of values based on a predicate. Each
             * element's index is used in the logic of the predicate
             * funtion.
             */

            var enumerable = persons
                .Where((p, i) => p.Employer.CompanyName.ToLower().Contains("academ") && (i % 2 == 1));

            foreach (var item in enumerable)
                WriteLine(item);
        }

        private static void Union_Ovrld_01()
        {
            /* Union
             * -----
             * Produces the set union of two sequences by using the default
             * equality comparer.
             * 
             * That is, all elements from both collections are included
             * without duplicates.
             */

            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Speedy", 175, ConsoleColor.Gray, null)
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Creeper", 10, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Maestro", 195, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Cutie", 175, ConsoleColor.DarkGreen, null)
            };

            var enumerable = garage1
                .Union(garage2);

            foreach (Car car in enumerable)
                WriteLine(car);
        }

        private static void Union_Ovrld_02()
        {
            /* Union
             * -----
             * Produces the set union of two sequences by using a specified
             * IEqualityComparer<in T>.
             * 
             * That is, all elements from both collections are included
             * without duplicates.
             */

            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, new ComplexKey(1, "A", true)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(2, "A", true)),
                new Car("Daisy", 95, ConsoleColor.DarkRed, new ComplexKey(3, "A", true)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(4, "A", true)),
                new Car("Speedy", 175, ConsoleColor.Gray, new ComplexKey(5, "A", true))
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Creeper", 10, ConsoleColor.Cyan, new ComplexKey(6, "A", true)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(2, "A", true)),
                new Car("Maestro", 195, ConsoleColor.DarkRed, new ComplexKey(7, "A", true)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(4, "A", true)),
                new Car("Cutie", 175, ConsoleColor.DarkGreen, new ComplexKey(8, "A", true))
            };

            var enumerable = garage1
                .Union(garage2, new Car(null, 0, ConsoleColor.Black, null));

            foreach (Car car in enumerable)
                WriteLine(car);
        }

        private static void TakeWhile_Ovrld_01()
        {
            /*
             * TakeWhile
             * ---------
             * Returns elements from a sequence as long as a specified
             * condition is true.
             */

            List<Car> garage = new List<Car>
            {
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null), // Condition true so include.
                new Car("Rusty",   90, ConsoleColor.DarkCyan, null),    // Condition still true so include.
                new Car("Daisy",   95, ConsoleColor.DarkRed, null),     // Condition still true so include.
                new Car("Bumpy",  100, ConsoleColor.Blue, null),        // Condition false so from now on exclude.
                new Car("Speedy",  65, ConsoleColor.Gray, null),        // Exclude. (Ignore condition)
                new Car("Slower",   5, ConsoleColor.Magenta, null)      // Exclude. (Ignore condition)
            };

            var resultSet = garage
                .TakeWhile(c => c.Speed < 100);

            foreach (Car car in resultSet)
                WriteLine(car);
        }

        private static void TakeWhile_Ovrld_02()
        {
            /*
             * TakeWhile
             * ---------
             * Returns elements from a sequence as long as a specified
             * condition is true. The element's index is used in the logic
             * of the predicate function.
             */

            List<Car> garage = new List<Car>
            {
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null), // Condition true so include.
                new Car("Rusty",   80, ConsoleColor.DarkCyan, null),    // Condition still true so include.
                new Car("Daisy",   85, ConsoleColor.DarkRed, null),     // Condition still true so include.
                new Car("Bumpy",   90, ConsoleColor.Blue, null),        // Condition still true so include.
                new Car("Speedy", 105, ConsoleColor.Gray, null),        // Condition still true so include.
                new Car("Speedy",  95, ConsoleColor.Gray, null),        // Condition false so from now on exclude.
                new Car("Slower", 200, ConsoleColor.Magenta, null)      // Exclude. (Ignore condition)
            };

            var resultSet = garage
                .TakeWhile((c, i) => c.Speed > 100 || i < 4);

            foreach (Car car in resultSet)
                WriteLine(car);
        }

        private static void Take(List<Person> persons)
        {
            /* Take
             * ----
             * Returns a specified number of contiguous elements from the
             * start of a sequence.
             */

            int i = ConsoleUtils.ConsoleGetInt(
                0,
                persons.Count,
                $"How many elements do you want (0-{persons.Count})?: ",
                "Ivalid input!");

            var resultSet = persons
                .Take(i);

            foreach (Person person in resultSet)
                WriteLine(person);
        }

        private static void Sum_Ovrld_01To10(List<Person> persons)
        {
            /* Computes the sum of the sequence of
             * 
             * » nullable decimal   (Overload  1)
             * » decimal            (Overload  2)
             * 
             * » nullable double    (Overload  3)
             * » double             (Overload  4)
             * 
             * » nullable float     (Overload  5)
             * » float              (Overload  6)
             * 
             * » nullable int       (Overload  7)
             * » int                (Overload  8)
             * 
             * » nullable long      (Overload  9)
             * » long               (Overload 10)
             * 
             * values that are obtained by invoking a transform function
             * on each element of the input sequence. */


            var numPersons = persons
                .Sum(p => 1);

            var sumAge = persons
                .Sum(p => p.Age);

            WriteLine($"There are {numPersons} persons in the list.");
            WriteLine($"The sum of their ages is {sumAge} years.");
            WriteLine($"The average age is {sumAge / numPersons} years.");
        }

        private static void SkipWhile_Ovrld_01()
        {
            /* Bypasses elements in a sequence as long as a specified
             * condition is true and then returns the remaining elements. */

            List<Car> garage = new List<Car>
            {
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null), // Condition true so skip.
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),      // Condition still true so skip.
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),       // Condition still true so skip.
                new Car("Bumpy", 100, ConsoleColor.Blue, null),         // Condition not true so from now on include.
                new Car("Speedy", 175, ConsoleColor.Gray, null),        // Include. (Ignore condition)
                new Car("Slower", 5, ConsoleColor.Magenta, null)        // Include. (Ignore condition)
            };

            var resultSet = garage
                .SkipWhile(c => c.Speed < 100);

            foreach (var car in resultSet)
                WriteLine($"{car.CarName} {car.Speed} Km/h");
        }

        private static void SkipWhile_Ovrld_02()
        {
            /* Bypasses elements in a sequence as long as a specified
             * condition is true and then returns the remaining elements.
             * The element's index is used in the logic of the predicate
             * function. */

            List<Car> garage = new List<Car>
            {
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null), // Condition true so skip.
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),      // Condition still true so skip.
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),       // Condition still true so skip.
                new Car("Bumpy", 100, ConsoleColor.Blue, null),         // Condition still true so skip.
                new Car("Speedy", 175, ConsoleColor.Gray, null),        // Condition false so include.
                new Car("Slower", 5, ConsoleColor.Magenta, null)        // Include. (Ignore condition)
            };

            var resultSet = garage
                .SkipWhile((c, i) => i < garage.Count - 2);

            foreach (var car in resultSet)
                WriteLine($"{car.CarName} {car.Speed} Km/h");
        }

        private static void Skip(List<Person> persons)
        {
            /*
             * Skip
             * ----
             * Bypasses a specified number of elements in a sequence and
             * then returns the remaining elements.
             */

            var resultSet = persons
                .Skip(persons.Count - 2); // Skip all but the two last elements.

            foreach (var item in resultSet)
                WriteLine(item);
        }

        private static void SingleOrDefault_Ovrld_01(List<Person> persons)
        {
            /*
             * Returns the ONLY element of a sequence, or a default value
             * if the sequence is empty, this method throws an exception if
             * there is more than one element in the sequence.
             */

            Car[] cars = new Car[]
            {
                new Car("Volvo V60", 195, ConsoleColor.Blue, null),
                new Car("Volvo V70", 180, ConsoleColor.Red, null)
            };

            try
            {
                var resultSet = cars
                    .SingleOrDefault();

                if (resultSet == default(Car))
                    WriteLine("The car collection is empty.");
                else
                    WriteLine(resultSet);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine(ex.Message + '.');
            }
        }

        private static void SingleOrDefault_Ovrld_02(List<Person> persons)
        {
            /*
             * Returns the ONLY element of a sequence that satisfies a
             * specified condition, or a default value if no element
             * satisfies the condition or the collection is empty to begin
             * with.
             * 
             * This method throws an exception if more than one element
             * satisfies the condition.
             */

            Car[] cars = new Car[]
            {
                new Car("Volvo V60", 195, ConsoleColor.Blue, null),
                new Car("Volvo V70", 180, ConsoleColor.Red, null),
                new Car("Volvo V90", 200, ConsoleColor.Green, null),
                new Car("Volvo V40", 170, ConsoleColor.White, null)
            };

            try
            {
                var resultSet = cars
                    .SingleOrDefault(c => c.Speed > 195);

                if (resultSet == default(Car))
                    WriteLine("The car collection is empty.");
                else
                    WriteLine(resultSet);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine(ex.Message + '.');
            }
        }

        private static void Single_Ovrld_01()
        {
            /*
             * Returns the ONLY element of a sequence, and throws an
             * exception if there is not exactly one element in the
             * sequence.
             */

            Car[] cars = new Car[]
            {
                new Car("Volvo V60", 195, ConsoleColor.Blue, null),
                new Car("Volvo V70", 180, ConsoleColor.Red, null)
            };

            try
            {
                var resultSet = cars
                    .Single();

                WriteLine(resultSet);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine("Collection doesn't contain exactly one element.");
                WriteLine("More exactly: " + ex.Message + '.');
            }
        }

        private static void Single_Ovrld_02()
        {
            /*
             * Returns the ONLY element of a sequence that satisfies a
             * specified condition, and throws an exception if more than
             * one such element exists.
             */

            Car[] cars = new Car[]
            {
                new Car("Volvo V60", 195, ConsoleColor.Blue, null),
                new Car("Volvo V70", 180, ConsoleColor.Red, null),
                new Car("Volvo V90", 200, ConsoleColor.Green, null),
                new Car("Volvo V40", 170, ConsoleColor.White, null)
            };

            try
            {
                var resultSet = cars
                    .Single(c => c.Speed >= 195);

                WriteLine(resultSet);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine("Collection doesn't contain exactly one element.");
                WriteLine("More exactly: " + ex.Message + '.');
            }
        }

        private static void SequenceEqual_Ovrld_01(List<Person> persons)
        {
            /*
             * Determines whether two sequences are equal by comparing the
             * elements by using the default equality comparer for their
             * type.
             * 
             * For this method to return true, the elements in the two
             * lists must come in the same order and be equal.
             */

            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Speedy", 175, ConsoleColor.Gray, null)
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Speedy", 175, ConsoleColor.Gray, null)
            };

            bool IsEqual = garage1
                .SequenceEqual(garage2);

            if (IsEqual)
                WriteLine("Sequences equal!");
            else
                WriteLine("Sequences NOT equal!");
        }
        private static void SequenceEqual_Ovrld_02(List<Person> persons)
        {
            /*
             * Determines whether two sequences are equal by comparing their
             * elements by using a specified IEqualityComparer<in T>.
             * 
             * For this method to return true, the elements in the two
             * lists must come in the same order and be equal.
             */

            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, new ComplexKey(1, "A", false)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(2, "A", false)),
                new Car("Daisy", 95, ConsoleColor.DarkRed, new ComplexKey(3, "A", false)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(4, "A", false)),
                new Car("Speedy", 175, ConsoleColor.Gray, new ComplexKey(5, "A", false))  // <- NOT EQUAL
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, new ComplexKey(1, "A", false)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(2, "A", false)),
                new Car("Daisy", 95, ConsoleColor.DarkRed, new ComplexKey(3, "A", false)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(4, "A", false)),
                new Car("Speedy", 175, ConsoleColor.Gray, new ComplexKey(5, "A", true))  // <- NOT EQUAL
            };

            bool IsEqual = garage1
                .SequenceEqual(garage2, new Car(null, 0, ConsoleColor.Black, null));

            if (IsEqual)
                WriteLine("Sequences equal!");
            else
                WriteLine("Sequences NOT equal!");
        }

        private static void SelectMany_Ovrld_01(List<Person> persons)
        {
            /*
             * SelectMany()
             * ------------
             * When each element of collection contains another collection,
             * we can use the SelectMany method to create a single
             * collection of all the contained collection elements.
             * 
             * In this example we have a collection of car owners. Each car
             * owner has a list of owned cars. By using the SelectMany
             * method we can create a list of all cars from all owners.
             * 
             * When can accomplish this by using the Select method as well.
             * However, using SelectMany is more convenient. See the
             * SelectInsteadOfSelectMany method.
             */

            List<CarOwner> carOwners = CreateListOfCarOwners();

            WriteLine("ALL CARS:");
            WriteLine("ALL CARS:".AsChar('-'));

            var resultSet = carOwners
                .SelectMany(co => co.Cars);

            foreach (var car in resultSet)
                WriteLine(car);

            WriteLine();

            /* Tip: To remove all duplicate cars from the list we can use
             * the Distinct Linq method as shown next. */
            WriteLine("DISTINCT CARS:");
            WriteLine("DISTINCT CARS:".AsChar('-'));

            resultSet = resultSet
                .Distinct()
                .OrderByDescending(c => c.Speed);

            foreach (var car in resultSet)
                WriteLine(car);
        }

        private static void SelectMany_Ovrld_03(List<Person> persons)
        {
            /*
             * SelectMany()
             * ------------
             * This SelectMany overload works just like the one demonstrated
             * in the SelectMany_Ovrld_01 method. However, the second
             * parameter allows us to iterate over each item in the result
             * set combined with each item in the original collection to
             * project a new type. */

            List<CarOwner> carOwners = CreateListOfCarOwners();

            WriteLine("ALL CARS:");
            WriteLine("ALL CARS:".AsChar('-'));

            var resultSet = carOwners
                .SelectMany(
                carOwner => carOwner.Cars,
                (carOwner, resultSetItem) => new { carOwner.Owner.FirstName, resultSetItem.CarName });
            // I.e. each owner is reperated for each car.

            foreach (var car in resultSet)
                WriteLine(car);
        }

        private static void SelectMany_Ovrld_02(List<Person> persons)
        {
            /*
             * SelectMany()
             * ------------
             * This overload allows us to incorporate the index of each item
             * in the original collection.
             * 
             * Do note that this code also demonstrates how to create an
             * array of an anonymous type.
             */

            List<CarOwner> carOwners = CreateListOfCarOwners();

            var arrayOfAnonymousType = carOwners
                .SelectMany((carOwner, index) => new[] { new { Index = index + 1, Cars = carOwner.Cars } });

            foreach (var item in arrayOfAnonymousType)
            {
                WriteLine($"Index: {item.Index}");
                WriteLine($"Index: {item.Index}".AsChar('-'));

                foreach (var car in item.Cars)
                    WriteLine(car);

                WriteLine();
            }
        }

        private static void SelectMany_Ovrld_04(List<Person> persons)
        {
            /*
             * SelectMany()
             * ------------
             * Same as SelectMany_Ovrld_02 but also lets us project a new
             * type based on our flattened result set.
             */
            List<CarOwner> carOwners = CreateListOfCarOwners();

            var resultSet = carOwners
                .SelectMany(
                (carOwner, index) => new[] { new { Index = index + 1, Cars = carOwner.Cars } },
                (carOwner, anonymoysType) => new { anonymoysType.Index, carOwner.Owner.FirstName, anonymoysType.Cars });

            foreach (var item in resultSet)
            {
                WriteLine($"Index: {item.Index}, {item.FirstName}");
                WriteLine($"Index: {item.Index}, {item.FirstName}".AsChar('-'));

                foreach (var car in item.Cars)
                    WriteLine(car);

                WriteLine();
            }
        }

        private static void SelectInsteadOfSelectMany(List<Person> persons)
        {
            /*
             * See the SelectMany_Ovrld_01 method.
             */

            List<CarOwner> carOwners = CreateListOfCarOwners();

            var listOf_ListOfCars = carOwners
                .Select(co => co.Cars);

            List<Car> allCars = new List<Car>();

            foreach (var listOfCars in listOf_ListOfCars)
                allCars.AddRange(listOfCars);

            WriteLine("ALL CARS:");
            WriteLine("ALL CARS:".AsChar('-'));

            foreach (var car in allCars)
                WriteLine(car);

            WriteLine();

            /* Tip: To remove all duplicate cars from the list we can use
             * the Distinct Linq method as shown next. */
            WriteLine("DISTINCT CARS:");
            WriteLine("DISTINCT CARS:".AsChar('-'));

            allCars = allCars
                .Distinct()
                .OrderByDescending(c => c.Speed)
                .ToList();

            foreach (var car in allCars)
                WriteLine(car);
        }

        private static List<CarOwner> CreateListOfCarOwners()
        {
            return new List<CarOwner>
            {
                new CarOwner
                {
                    Owner = new PersonBaseClass("Carl", "Kula", null),
                    Cars = new List<Car>
                    {
                        new Car("Volvo V70", 180, ConsoleColor.White, null)
                    }

                },
                new CarOwner
                {
                    Owner = new PersonBaseClass("Carin", "Cula", null),
                    Cars = new List<Car>
                    {
                        new Car("Volvo V70", 180, ConsoleColor.White, null),
                        new Car("SEAT Leon", 170, ConsoleColor.Red, null)
                    }

                },
                new CarOwner
                {
                    Owner = new PersonBaseClass("Bertil", "Best", null),
                    Cars = new List<Car>
                    {
                        new Car("Volvo V70", 180, ConsoleColor.White, null ),
                        new Car("SEAT Leon CUPRA", 280, ConsoleColor.DarkGreen, null),
                        new Car("Bugatti Chiron", 460, ConsoleColor.DarkBlue, null)
                    }
                }
            };
        }

        private static void Select_Ovrld_01(List<Person> persons)
        {
            /* Projects each element of a sequence into a new form. */

            var resultSet = persons
                .Select(p => new
                {
                    Business = p.Employer.CompanyName,
                    GivenName = p.FirstName,
                    Surname = p.LastName
                });

            foreach (var item in resultSet)
                WriteLine($"{item.Business,20}:{item.GivenName} {item.Surname}");
        }

        private static void Select_Ovrld_02(List<Person> persons)
        {
            /* Projects each element of a sequence into a new form by
             * incorporating the element's index. */

            /* This could possibly be interesting:
             * http://geekswithblogs.net/BlackRabbitCoder/archive/2012/05/17/c.net-little-wonders-select-and-where-with-indexes.aspx?utm_medium=Twitter&utm_source=Shared */

            var resultSet = persons
                .Select((p, index) => new
                {
                    Index = index,
                    Business = p.Employer.CompanyName,
                    GivenName = p.FirstName,
                    Surname = p.LastName
                });

            foreach (var item in resultSet)
                WriteLine($"Index: {item.Index} {item.Business,20}:{item.GivenName} {item.Surname}");
        }

        private static void Reverse(List<Person> persons)
        {
            /* Inverts the order of the elements in a sequence. Note: The
             * List<T> class has an overloaded void Reverse method which can
             * be used to reverse a section of elements within the list. */

            WriteLine("NON-REVERSED:");
            persons.ForEach(p => WriteLine(p.LastName));

            WriteLine(NewLine + "REVERSED:");
            persons.Reverse<Person>().ToList().ForEach(p => WriteLine(p.LastName));
        }

        private static void OrderByDescending(List<Person> persons)
        {
            /* Works exactly like the OrderBy() method but sorts the
             * elements in descending order. */

            var resultSet = persons
                .OrderByDescending(p => p.LastName);

            foreach (var item in resultSet)
                WriteLine(item.LastName);
        }

        private static void OrderBy_Ovrld_01(List<Person> persons)
        {
            /* Sorts the elements of a sequence in ascending order according
             * to a key. If the key is a complex type (as in this example)
             * the IComparable interface must be implemented on the key. */

            var resultSet = persons
                .OrderBy(p => p);

            foreach (var item in resultSet)
                WriteLine(
                    $"Company: {item.Employer.CompanyName}," +
                    $"Company age: {DateTime.Now.Year - item.Employer.YearFounded}");

            WriteLine();

            /* Sorts the elements of a sequence in ascending order according
             * to a key. In this case the key is a value type (int Age). */

            resultSet = persons
                .OrderBy(p => p.Age);

            foreach (var item in resultSet)
                WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");

            WriteLine();
        }

        private static void OrderBy_Ovrld_02(List<Person> persons)
        {
            /* Sorts the elements of a sequence in ascending order by using
             * a specified IComparer. */

            var resultSet = persons
                .OrderBy(p => p, new SortPersonsByCompanyNameThenByFirstName());

            foreach (var item in resultSet)
                WriteLine(
                    $"Company: {item.Employer.CompanyName}," +
                    $"Employee: {item.FirstName} {item.LastName}");

            WriteLine();

            resultSet = persons
                .OrderBy(p => p.Employer, new SortCompanyByCompanyAge());

            foreach (var item in resultSet)
            {
                string companyAgeStr;

                if (item.Employer.YearFounded == 0)
                    companyAgeStr = "N/A";
                else
                    companyAgeStr = (DateTime.Now.Year - item.Employer.YearFounded).ToString();

                WriteLine(
                    $"Company: {item.Employer.CompanyName}, Company age: {companyAgeStr}, " +
                    $"Employee: {item.FirstName} {item.LastName}");
            }
        }

        private static void OfType()
        {
            /* Filters the elements of an IEnumerable based on a specified
             * type <T> */

            Stack stack = new Stack(10);

            stack.Push(30);
            stack.Push(true);
            stack.Push(new Person("Carin", "Kula", 30, null));
            stack.Push(50);
            stack.Push(Math.PI);
            stack.Push(new PersonBaseClass("Calle", "Cula", null));
            stack.Push(10);

            // Three ints (10, 30, and 50) on the stack.
            foreach (var item in stack.OfType<int>())
                WriteLine($"Basetype: {item.GetType().BaseType.Name}, Type: {item.GetType().Name}, Value: {item}");

            WriteLine();

            // One bool on the stack.
            foreach (var item in stack.OfType<bool>())
                WriteLine($"Basetype: {item.GetType().BaseType.Name}, Type: {item.GetType().Name}, Value: {item}");

            WriteLine();

            // One Person on the stack.
            foreach (var item in stack.OfType<Person>())
                WriteLine($"Basetype: {item.GetType().BaseType.Name}, Type: {item.GetType().Name}, Value: {item}");

            WriteLine();

            // One double on the stack.
            foreach (var item in stack.OfType<double>())
                WriteLine($"Basetype: {item.GetType().BaseType.Name}, Type: {item.GetType().Name}, Value: {item}");

            WriteLine();

            // Two PersonBaseClass on the stack.
            // Note: Person is a PersonBaseClass so two PersonBaseClass elements on the stack.
            foreach (var item in stack.OfType<PersonBaseClass>())
                WriteLine($"Basetype: {item.GetType().BaseType.Name}, Type: {item.GetType().Name}, Value: {item}");
        }

        private static void Max_Min_Ovrld_01(List<Person> persons)
        {
            /* Returns the maximum/minimum value in a generic sequence. For
             * this parameterless overload of Max() to work, Person must
             * implement the IComparable interface. */

            /* Press [F12] on CompareTo to see the IComparable interface implementation.
               var x = new Person(null, null, 0, null).CompareTo(new Person(null, null, 0, null));
                                                       --------- */
            var resultSet = persons.Max();
            WriteLine($"Oldest company: {resultSet.Employer}");

            resultSet = persons.Min();
            WriteLine($"Youngest company: {resultSet.Employer}");
        }

        private static void Max_Min_Ovrld_02To11()
        {

            MaxMinClass[] maxMinItems = new MaxMinClass[]
            {
                new MaxMinClass { NullableDecimal = 1.25m, ADecimal = 9.25m, NullableDouble = null, ADouble = 5.25, NullableFloat = null, AFloat = 8.98f, NullableInt = 4, AnInt = 4, NullableLong = 2, ALong = 4 },
                new MaxMinClass { NullableDecimal = null, ADecimal = 5.25m, NullableDouble = 8.25, ADouble = 9.55, NullableFloat = 9.99f, AFloat = 8.99f, NullableInt = null, AnInt = 6, NullableLong = null, ALong = 3 },
                new MaxMinClass { NullableDecimal = 5.25m, ADecimal = 3.25m, NullableDouble = null, ADouble = 6.25, NullableFloat = null, AFloat = 8.97f, NullableInt = 5, AnInt = 5, NullableLong = 8, ALong = 7 },
                new MaxMinClass { NullableDecimal = null, ADecimal = 7.25m, NullableDouble = 8.24, ADouble = 4.25, NullableFloat = 9.96f, AFloat = 8.95f, NullableInt = null, AnInt = 2, NullableLong = null, ALong = 1 },
                new MaxMinClass { NullableDecimal = 3.25m, ADecimal = 1.25m, NullableDouble = null, ADouble = 3.25, NullableFloat = null, AFloat = 8.96f, NullableInt = 3, AnInt = 3, NullableLong = 1, ALong = 2 }
            };

            var r2Max = maxMinItems
                .Max(m => m.NullableDecimal);

            var r3Max = maxMinItems
                .Max(m => m.ADecimal);

            var r4Max = maxMinItems
                .Max(m => m.NullableDouble);

            var r5Max = maxMinItems
                .Max(m => m.ADouble);

            var r6Max = maxMinItems
                .Max(m => m.NullableFloat);

            var r7Max = maxMinItems
                .Max(m => m.AFloat);

            var r8Max = maxMinItems
                .Max(m => m.NullableInt);

            var r9Max = maxMinItems
                .Max(m => m.AnInt);

            var r10Max = maxMinItems
                .Max(m => m.NullableLong);

            var r11Max = maxMinItems
                .Max(m => m.ALong);

            WriteLine(
                    $"r2Max: {r2Max}" + NewLine +
                    $"r3Max: {r3Max}" + NewLine +
                    $"r4Max: {r4Max}" + NewLine +
                    $"r5Max: {r5Max}" + NewLine +
                    $"r6Max: {r6Max}" + NewLine +
                    $"r7Max: {r7Max}" + NewLine +
                    $"r8Max: {r8Max}" + NewLine +
                    $"r9Max: {r9Max}" + NewLine +
                    $"r10Max: {r10Max}" + NewLine +
                    $"r11Max: {r11Max}");

            WriteLine();

            var r2Min = maxMinItems
                .Min(m => m.NullableDecimal);

            var r3Min = maxMinItems
                .Min(m => m.ADecimal);

            var r4Min = maxMinItems
                .Min(m => m.NullableDouble);

            var r5Min = maxMinItems
                .Min(m => m.ADouble);

            var r6Min = maxMinItems
                .Min(m => m.NullableFloat);

            var r7Min = maxMinItems
                .Min(m => m.AFloat);

            var r8Min = maxMinItems
                .Min(m => m.NullableInt);

            var r9Min = maxMinItems
                .Min(m => m.AnInt);

            var r10Min = maxMinItems
                .Min(m => m.NullableLong);

            var r11Min = maxMinItems
                .Min(m => m.ALong);

            WriteLine(
                    $"r2Min: {r2Min}" + NewLine +
                    $"r3Min: {r3Min}" + NewLine +
                    $"r4Min: {r4Min}" + NewLine +
                    $"r5Min: {r5Min}" + NewLine +
                    $"r6Min: {r6Min}" + NewLine +
                    $"r7Min: {r7Min}" + NewLine +
                    $"r8Min: {r8Min}" + NewLine +
                    $"r9Min: {r9Min}" + NewLine +
                    $"r10Min: {r10Min}" + NewLine +
                    $"r11Min: {r11Min}");
        }

        private static void Max_Min_Ovrld_12(List<Person> persons)
        {
            /* Invokes a transform function on each element of a generic
             * sequence and returns the maximum/minimum resulting value. For
             * this overload of Max to work, the transformed values (in
             * this case instances of MaxClass) must implement the
             * IComparable interface. */

            var resultSet = persons
                .Max(m => new MaxMinClass { AnInt = m.Employer.YearFounded });

            WriteLine($"Maximum year founded: {resultSet.AnInt}");

            resultSet = persons
                .Min(m => new MaxMinClass { AnInt = m.Employer.YearFounded });

            WriteLine($"Minimum year founded: {resultSet.AnInt}");
        }

        private static void LongCount_Ovrld_01(List<Person> persons)
        {
            /* Returns a long that represents the total number of elements
             * in a sequence. */
            var resultSet = persons
                .LongCount();

            WriteLine($"Total number of elements in sequence: {resultSet}");
        }

        private static void LongCount_Ovrld_02(List<Person> persons)
        {
            /* Returns a long that represents how many elements in a
             * sequence satisfies a condition. */

            var resultSet = persons // An empty list returns 0.
                .LongCount(p => p.Age > 36 && p.Age < 55);

            WriteLine($"Total number of elements in sequence: {resultSet}");
        }

        private static void LastOrDefault_Ovrld_01(List<Person> persons)
        {
            /* Returns the last element of a sequence or a default value if
             * the sequence contains no elements. */

            //AskToClearList(persons);
            persons = null;

            var resultSet = persons?.LastOrDefault();

            if (resultSet == null)
                WriteLine("Last element not found.");
            else
                WriteLine(resultSet);
        }

        private static void LastOrDefault_Ovrld_02(List<Person> persons)
        {
            /* Returns the last element of a sequence that satisfies a
             * condition or a default value if no such element is found. */

            AskToClearList(persons);

            var resultSet = persons?.LastOrDefault(p => p.Age > 53 && p.Age < 55);

            if (resultSet == null)
                WriteLine("Last element not found.");
            else
                WriteLine(resultSet);
        }

        private static void Last_Ovrld_01(List<Person> persons)
        {
            // Returns the last element of a sequence. Returns an
            // InvalidOperationException if the list is empty.

            AskToClearList(persons);

            try
            {
                var resultSet = persons
                    .Last();

                WriteLine(resultSet);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine("Last element not found." + NewLine + ex.Message + '.');
            }
        }

        private static void Last_Ovrld_02(List<Person> persons)
        {
            /* Returns the last element of a sequence that satisfies a
             * specified condition. Returns an InvalidOperationException if
             * the list is empty or no element was found.*/

            AskToClearList(persons);

            try
            {
                var resultSet = persons
                    .Last(p => p.Employer.YearFounded == 1998);

                WriteLine(resultSet);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine("Last element not found." + NewLine + ex.Message + '.');
            }
        }

        private static void Intersect_Ovrld_01()
        {
            /*
             * Produces the set intersection of two sequences by using the
             * default equality comparer to compare values. In this example
             * the set intersection consist of "Rusty" and "Clonker" as they
             * exist in both collections. Note Car.Key (set to null in the
             * constructor) is excluded in the default equality comparer.
             */
            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Speedy", 175, ConsoleColor.Gray, null)
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Creeper", 10, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Maestro", 195, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Cutie", 175, ConsoleColor.DarkGreen, null)
            };

            var resultSet = garage1
                .Intersect(garage2)
                .ToList();

            resultSet.ForEach(c => WriteLine(c));
        }

        private static void Intersect_Ovrld_02()
        {
            /*
             * Produces the set intersection of two sequences by using the
             * specified IEqualityComparer<in T> to compare values. In this
             * example the set intersection consist of "Rusty" and "Clonker"
             * as they exist in both collections and have equal Keys. Note
             * that the IEqualityComparer<in T> of the Car class only
             * compares the Key property of the cars and does not involve
             * the default equality comparer.
             */
            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, new ComplexKey(1, "A", true)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(2, "A", true)),
                new Car("Daisy", 95, ConsoleColor.DarkRed, new ComplexKey(3, "A", true)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(4, "A", true)),
                new Car("Speedy", 175, ConsoleColor.Gray, new ComplexKey(5, "A", true))
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Creeper", 10, ConsoleColor.Blue, new ComplexKey(6, "A", true)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(2, "A", true)),
                new Car("Maestro", 195, ConsoleColor.DarkRed, new ComplexKey(7, "A", true)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(4, "A", true)),
                new Car("Cutie", 175, ConsoleColor.DarkGreen, new ComplexKey(8, "A", true))
            };

            var resultSet = garage1
                .Intersect(garage2, new Car(null, 0, ConsoleColor.Black, null))
                .ToList();

            resultSet.ForEach(c => WriteLine(c));
        }

        private static void GroupJoin_Ovrld_01()
        {
            string[] firstNames = new string[5]
            { "Håkan", "Marilyn", "Adam", "Nathalie", "Kenneth" };

            string[] lastNames = new string[9]
            { "Mson", "Nson", "Kson", "Mason", "Hson", "Hoa", "Mup", "Ason", "Xes" };

            var resultSet = firstNames
                .GroupJoin(
                lastNames,
                f => f[0],
                l => l[0],
                (s, g) => new { FirstName = s, Group = g }
                );

            foreach (var item in resultSet)
            {
                WriteLine(item.FirstName);
                WriteLine("----------");

                foreach (var gm in item.Group)
                    WriteLine(gm);

                WriteLine(Environment.NewLine);
            }
        }
        private static void GroupJoin_Ovrld_02()
        {
            List<PersonBaseClass> persons = new List<PersonBaseClass>
            {
                new PersonBaseClass("Håkan", "Johansson", new ComplexKey(1, "A", true)),
                new PersonBaseClass("Pontus", "Wittenmark", new ComplexKey(2, "A", true)),
                new PersonBaseClass("Patrik", "Jönsson", new ComplexKey(3, "A", true)),
                new PersonBaseClass("Emelie", "Bernhardsson", new ComplexKey(4, "A", true))
            };

            List<Car> cars = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, new ComplexKey(1, "A", true)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(1, "A", true)),
                new Car("Daisy", 95, ConsoleColor.DarkRed, new ComplexKey(1, "A", true)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(2, "A", true)),
                new Car("Speedy", 175, ConsoleColor.Gray, new ComplexKey(2, "A", true)),
                new Car("Wheely", 180, ConsoleColor.Green, new ComplexKey(3, "A", true)),
                new Car("Maestro", 210, ConsoleColor.White, new ComplexKey(4, "A", true))
            };

            var resultSet = persons
                .GroupJoin(
                cars,
                p => p.Key,
                c => c.Key,
                (o, m) => new { One = o, Many = m },
                new ComplexKey(default(int), default(string), default(bool))
                );

            foreach (var result in resultSet)
            {
                WriteLine($"Car owner: {result.One}");

                foreach (var one in result.Many)
                    WriteLine(one);

                WriteLine();
            }
        }

        private static void Join_Ovrld_01()
        {
            string[] firstNames = new string[5]
            { "Håkan", "Marilyn", "Adam", "Nathalie", "Kenneth" };

            string[] lastNames = new string[9]
            { "Mson", "Nson", "Kson", "Mason", "Hson", "Hoa", "Mup", "Ason", "Xes" };

            /*
             * SQL Pseuducode
             * --------------
             * select
             *      firstNames.f + ' ' + lastNames.l
             * from
             *      firstNames
             * inner join
             *      lastNames on
             *      firstNames.f[0] = lastNames.l[0]
             */

            var resultSet = firstNames
                .Join(
                lastNames,
                f => f[0],
                l => l[0],
                (f, l) => $"{f} {l}");

            foreach (var item in resultSet)
                Console.WriteLine(item);
        }

        private static void Join_Ovrld_02()
        {
            List<PersonBaseClass> persons = new List<PersonBaseClass>
            {
                new PersonBaseClass("Håkan", "Johansson", new ComplexKey(1, "A", true)),
                new PersonBaseClass("Pontus", "Wittenmark", new ComplexKey(2, "A", true)),
                new PersonBaseClass("Patrik", "Jönsson", new ComplexKey(3, "A", true)),
                new PersonBaseClass("Emelie", "Bernhardsson", new ComplexKey(4, "A", true))
            };

            List<Car> cars = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, new ComplexKey(1, "A", true)),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, new ComplexKey(1, "A", true)),
                new Car("Daisy", 95, ConsoleColor.DarkRed, new ComplexKey(1, "A", true)),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, new ComplexKey(2, "A", true)),
                new Car("Speedy", 175, ConsoleColor.Gray, new ComplexKey(2, "A", true)),
                new Car("Wheely", 180, ConsoleColor.Green, new ComplexKey(3, "A", true)),
                new Car("Cutie", 210, ConsoleColor.White, new ComplexKey(4, "A", true))
            };

            var resultSet = persons
                .Join(
                cars,
                p => p.Key,
                c => c.Key,
                (p, c) => new { APerson = p, ACar = c },
                new ComplexKey(default(int), default(string), default(bool))
                );

            foreach (var join in resultSet)
                Console.WriteLine($"{join.APerson.FirstName} {join.ACar.CarName}");
        }

        private static void AnonymousMethodInsteadOfLambda(List<Person> persons)
        {
            int age = 0;
            ConsoleKey key;

            var myDel = new Predicate<Person>(delegate (Person p)
            {
                bool approved = false;

                if (p.Age >= age)
                {
                    Write($"Include: {p}?: ");
                    key = ReadKey().Key;
                    WriteLine();

                    if (key == ConsoleKey.Y)
                        approved = true;
                }

                return approved;
            });

            do
            {
                Write("Enter age: ");
                age = int.Parse(ReadLine());
                Clear();

                var resultSet = persons
                    .FindAll(myDel);

                Clear();

                foreach (var item in resultSet)
                    WriteLine(item);
            } while (age < 100);
        }

        private static void GroupBy_Ovrld_01(List<Person> persons)
        {
            /* Groups the elements of a sequence according to a specified
             * key selector function.  */

            var groups = persons
                .GroupBy(p => p.Employer.CompanyName); // Group by CompanyName

            foreach (var group in groups)
            {
                WriteLine(group.Key); // string Key (CompanyName)

                foreach (var person in group)
                    WriteLine(person);

                WriteLine();
            }
        }

        private static void GroupBy_Ovrld_02(List<Person> persons)
        {
            /* Groups the elements of a sequence according to a specified
             * key selector function and compares the keys by using a
             * specified comparer. */

            var groups = persons
                .GroupBy(p => p.Employer, new CountryBasedCompanyComparer());
            /* The Key here is the employer (Company) of each person.
             * However, we only wish to use the Country property of each key
             * to group the persons together. That is, the persons in the
             * list will be grouped by Country.*/

            foreach (var group in groups)
            {
                WriteLine(group.Key.Country);
                // Each key is still a company. However, the grouping is on the Country of each company.

                foreach (var person in group)
                    WriteLine(person);

                WriteLine();
            }
        }

        private static void GroupBy_Ovrld_03(List<Person> persons)
        {
            /* Groups the elements of a sequence according to a specified
             * key selector function and projects the elements for each
             * group by using a specified function. */

            var resultSet = persons
                .GroupBy(p => p.Employer.CompanyName, p => new { p.FirstName, p.Age });

            foreach (var group in resultSet)
            {
                WriteLine(group.Key); // string CompanyName

                foreach (var anonymousTypeItem in group)
                    WriteLine(anonymousTypeItem);

                WriteLine();
            }
        }

        private static void GroupBy_Ovrld_04(List<Person> persons)
        {
            /* Groups the elements of a sequence according to a specified
             * key selector function and creates _a_result_value_ for each
             * group and its key. */

            var listOfResultValues = persons
                .GroupBy(

                p => p.Employer.Country, // Group by Country

                (key, group) => // Create a result value for each key/group.
                $"Medelålder {key}:\t{Math.Round(group.Average(p => p.Age), 1)}");

            foreach (var resultValue in listOfResultValues)
                WriteLine(resultValue);

            WriteLine();
        }

        private static void GroupBy_Ovrld_05(List<Person> persons)
        {
            /* Groups the elements of a sequence according to a key selector
             * function. The keys are compared by using a comparer and each
             * group's elements are projected by using a specified function. */

            var resultSet = persons
                .GroupBy(

                p => p.Employer, // Each company is a Key.

                p => new { p.LastName, p.Age, p.Employer.Country }, // Anonymous type. Note "new"!

                new CountryBasedCompanyComparer()); // Compares and groups companys by Country.

            foreach (var group in resultSet)
            {
                WriteLine(group.Key.Country);

                foreach (var anonymousTypeItem in group)
                    WriteLine(anonymousTypeItem);

                WriteLine();
            }

            WriteLine();
        }

        private static void GroupBy_Ovrld_06(List<Person> persons)
        {
            /* Groups the elements of a sequence according to a specified
             * key selector function and creates a result value from each
             * group and its key. The keys are compared by using a specified
             * comparer. */

            var listOfResultValues = persons
                .GroupBy(

                p => p.Employer, // Company is the Key.

                (key, group) => // Create a result value for each key/group.
                $"Medelålder {key.Country}:\t{Math.Round(group.Average(p => p.Age), 1)}",

                new CountryBasedCompanyComparer() // Compares and groups companys by Country.
                );

            foreach (var resultValue in listOfResultValues)
                Console.WriteLine(resultValue);

            WriteLine();
        }

        private static void GroupBy_Ovrld_07(List<Person> persons)
        {
            /* a) Groups the elements of a sequence according to a specified
             * key selector function and b) creates a result value from each
             * group and its key. c) The elements of each group are projected
             * by using a specified function. */

            var resultSet = persons
                .GroupBy(

                /* a) */
                p => p.Employer,
                // Specify the "key" (Company).

                /* c) */
                p => new { p.FirstName, p.LastName, p.Age },
                // Create anonymous type for the elements of each group.

                /* b) */
                (key, group) => $"{key.CompanyName}: medelålder: {group.Average(p => p.Age)}"
                // Each key is a Company.
                // Each group is now a list of the anonymous type for each key.
                );

            foreach (var group in resultSet)
                Console.WriteLine(group);

            WriteLine();
        }

        private static void GroupBy_Ovrld_08(List<Person> persons)
        {
            /* a) Groups the elements of a sequence according to a specified
             * key selector function and c) creates a result value from each
             * group and its key. d) Key values are compared by using a
             * specified comparer, and b) the elements of each group are
             * projected by using a specified function.  */

            var resultSet = persons
                .GroupBy(

                /* a) */
                p => p.Employer,
                // Specify the "key" (Company).

                /* b) */
                p => new { p.FirstName, p.LastName, p.Age },
                // Create an anonymous type for the elements of each group.

                /* c) */
                (key, group) => $"{key.Country}, medelålder: {Math.Round(group.Average(p => p.Age), 1)}",
                // Each key is a Company.
                // Each group is now a list of the anonymous type.

                /* d) */
                new CountryBasedCompanyComparer()
                // Compare each company based on the company's country.
                );

            foreach (var group in resultSet)
                Console.WriteLine(group);

            WriteLine();
        }

        private static void FirstOrDefault_Ovrld_01(List<Person> persons)
        {
            /* FirstOrDefault() Returns the first element of a sequence, or
             * a default value if the sequence contains no elements.  */

            AskToClearList(persons);

            var resultSet = persons
                .FirstOrDefault();

            if (resultSet == null)
                WriteLine("Listan är tom!");
            else
                WriteLine(resultSet);
        }

        private static void AskToClearList<T>(List<T> listOfT)
        {
            Write("Vill du tömma listan för få ett default värde (J/Y/N)?: ");
            string input = ReadLine();
            char tmp = (input.Length > 0) ? input.ToUpper()[0] : ' ';

            if (tmp == 'J' || tmp == 'Y')
                listOfT.Clear();
        }

        private static void FirstOrDefault_Ovrld_02(List<Person> persons)
        {
            /* FirstOrDefault() Returns the first element of the sequence
             * that satisfies a condition or a default value if no such
             * element is found. */

            Write("Ange företagsnamn: ");
            string input = ReadLine();

            var resultSet = persons
                .FirstOrDefault(p => p.Employer.CompanyName.ToLower() == input.ToLower());

            if (resultSet == null)
                WriteLine("Listan är tom!");
            else
                WriteLine(resultSet);
        }

        private static void First_Ovrld_01(List<Person> persons)
        {
            /* First() returns the first element of a sequence. */

            AskToClearList(persons);

            try
            {
                var resultSet = persons
                    .First();

                WriteLine(resultSet);
            }
            catch
            {
                WriteLine("Listan är tom!");
            }
        }

        private static void First_Ovrld_02(List<Person> persons)
        {
            /* First() Returns the first element in a sequence that
             * satisfies a specified condition. */

            Write("Ange företagsnamn: ");
            string input = ReadLine();

            try
            {
                var resultSet = persons
                    .First(p => p.Employer.CompanyName.ToLower() == input.ToLower());

                WriteLine(resultSet);
            }
            catch
            {
                WriteLine("No first element found matching the condition!");
            }
        }

        private static void Except_Ovrld_01()
        {
            /* Produces the set difference of two sequences by using the
             * default equality comparer to compare values. (return everything
             * in stringArr1 EXCEPT equal elements in stringArr2.) */

            string[] stringArr1 = new string[] { "Patrik", "Håkan", "Pontus" };
            string[] stringArr2 = new string[] { "Håkan" };

            var resultSet = stringArr1
                .Except(stringArr2);

            foreach (var item in resultSet)
                Write($"{item} "); // Patrik Pontus

            WriteLine();
        }

        private static void Except_Ovrld_02(List<Person> persons)
        {
            /* Produces the set difference of two sequences by using the
             * specified IEqualityComparer<T> to compare values. (return
             * everything in stringArr1 EXCEPT equal elements in
             * stringArr2.) */

            List<Person> tmpList = new List<Person>
            {
                new Person("Kalle", "Kula", 10, new ComplexKey(1, "B", false))
                {
                    Employer = new Company
                    {
                        CompanyName = "Academy AB"
                    }
                },
                new Person("Carin", "Kula", 12, new ComplexKey(1, "B", false))
                {
                    Employer = new Company
                    {
                        CompanyName = "Academic Work AB"
                    }
                }
            };

            var resultSet = persons
                .Except(tmpList, new PersonBasedCompanyComparer());

            foreach (var item in resultSet)
                WriteLine(item);
        }

        private static void ElementAtOrDefault(List<Person> persons)
        {
            /* Returns the element at a specified index in a sequence or a
             * default value if the index is out of range. */

            bool isValidIndex;

            do
            {
                Write($"Ange index för person (0-{persons.Count - 1}): ");
                int index = int.Parse(ReadLine());
                Clear();

                var person = persons
                    .ElementAtOrDefault(index);

                isValidIndex = person != default(Person);

                if (isValidIndex)
                    WriteLine(person);
                else
                    WriteLine("Invalid index!");
            } while (!isValidIndex);
        }

        private static void ElementAt(List<Person> persons)
        {
            // Returns the element at a specified index in a sequence.
            // Generates exception "ArgumentOutOfRangeException"

            Write($"Ange index för person (0-{persons.Count - 1}): ");
            int index = int.Parse(ReadLine());

            try
            {
                var resultSet = persons
                    .ElementAt(index);

                WriteLine(resultSet);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            }
        }

        private static void Distinct_Ovrld_01(List<Person> persons)
        {
            /* Distinct() Returns distinct elements from a sequence by using
             * the default equality comparer to compare values. */

            Person p = new Person("Håkan", "Johansson", 54, new ComplexKey(1, "B", false))
            {
                Employer = new Company
                {
                    CompanyName = "Keges Grosshandel AB",
                    Country = "Sverige",
                    YearFounded = 1974,
                    Addresses = new List<string> { "Visby" }
                }
            };
            persons.Add(p); // Add duplicate record.
            WriteLine($"Total number of records: {persons.Count()}");

            var resultSet = persons
                .Distinct();

            WriteLine($"Distinct number of records: {resultSet.Count()}\n\r");

            int recordCount = 0;
            foreach (var item in resultSet)
                Console.WriteLine($"{++recordCount}: {item}");
        }

        private static void Distinct_Ovrld_02(List<Person> persons)
        {
            /* Returns distinct elements from a sequence by using a
             * specified IEqualityComparer<T> to compare values. */

            WriteLine($"Total number of records: {persons.Count()}");

            var resultSet = persons
                .Distinct(new PersonBasedCompanyComparer());

            WriteLine($"Distinct number of records: {resultSet.Count()}\n\r");

            int recordCount = 0;

            foreach (var item in resultSet)
                WriteLine($"{++recordCount}: {item}");
        }

        private static void DefaultIfEmpty_Ovrld_01(List<Person> persons)
        {
            /* Returns the elements of the specified sequence, OR the type
             * parameter's default value in a singleton collection if the
             * sequence is empty. */

            var resultSet = persons
                .DefaultIfEmpty();

            foreach (var item in resultSet)
            {
                Console.WriteLine(item);
            }
        }

        private static void DefaultIfEmpty_Ovrld_02(List<PersonBaseClass> persons)
        {
            /* Returns the elements of the specified sequence, OR the type
             * parameter's default value in a singleton collection if the
             * sequence is empty. */

            // defaultValue: The value to return if the sequence is empty.
            PersonBaseClass defaultValue = new PersonBaseClass("Kalle", "Kula", new ComplexKey(1, "B", false));

            var resultSet = persons
                .DefaultIfEmpty(defaultValue);

            foreach (var item in resultSet)
            {
                Console.WriteLine(item);
            }
        }

        private static void Count_Ovrld_01(List<Person> persons)
        {
            // Count() returns the number of elements in the sequence.
            var resultSet = persons
                .Count();

            WriteLine($"Total number of elements in the list: {resultSet}");
        }

        private static void Count_Ovrld_02(List<Person> persons)
        {
            const int age = 40;

            // Count() Returns a number that represents how many elements in
            // the specified sequence satisfy a condition.
            var resultSet = persons
                .Count(person => person.Age > age);

            WriteLine($"Number of persons above the age of {age}: {resultSet}");
        }

        private static void ContainsOvrld_01(List<Person> persons)
        {
            /* Contains() determines whether a sequence contains a specified
             * element by using the default equality comparer. */

            Person p = new Person("Håkan", "Doe", 54, new ComplexKey(1, "B", false))
            {
                Employer = new Company()
            };

            var resultSet = persons
                .Contains<Person>(p);

            if (resultSet)
                WriteLine($"[{p}]: Exists in the list!");
            else
                WriteLine($"[{p}]: does NOT exist in the list!");
        }

        private static void ContainsOvrld_02(List<Person> persons)
        {
            /* Contains() determines whether a sequence contains a specified
             * element by using a specified IEqualityComparer<T>. */

            Person p = new Person("Emilie" /*Change to "Emelie"*/, null, 0, new ComplexKey(1, "B", false))
            {
                Employer = new Company()
            };

            p.Employer.CompanyName = "Academy AB";

            var resultSet = persons
                .Contains<Person>(p, new SpecialPersonComparer());

            if (resultSet)
                WriteLine($"[{p}]: exists in the list.");
            else
                WriteLine($"[{p}]: does NOT exist in the list.");
        }

        private static void Concat()
        {
            /* Concatenats two sequences without making any kind of
             * comparisons. */

            List<Car> garage1 = new List<Car>
            {
                new Car("Bumpy", 100, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Daisy", 95, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Speedy", 175, ConsoleColor.Gray, null)
            };

            List<Car> garage2 = new List<Car>
            {
                new Car("Creeper", 10, ConsoleColor.Blue, null),
                new Car("Rusty", 90, ConsoleColor.DarkCyan, null),
                new Car("Maestro", 195, ConsoleColor.DarkRed, null),
                new Car("Clonker", 75, ConsoleColor.DarkMagenta, null),
                new Car("Cutie", 175, ConsoleColor.DarkGreen, null)
            };

            var resultSet = garage1
                .Concat(garage2);

            foreach (Car car in resultSet)
                WriteLine(car);
        }

        private static void Cast(List<Person> persons)
        {
            // Casts the elements of an IEnumerable to the specified type.
            // May throw an InvalidCastException.

            var resultSet = persons
                .Cast<PersonBaseClass>();

            foreach (var item in resultSet)
            {
                WriteLine($"{item.LastName}, {item.FirstName}");
            }
        }

        private static void Average(List<Person> persons)
        {
            /* Computes the average of a sequence of numeric values.
             * Overloaded for decimal, double, float, int, long and their
             * nullable versions (such as decimal?).*/

            var resultSet =
                persons.Average(p => p.Age);

            Console.WriteLine($"The average age is: {resultSet}");
        }

        private static void AsReadOnly(List<Person> persons)
        {
            /* List<T> implements the interface IList<T>. The
             * ReadOnlyCollection<T> (retured by the .AsReadOnly() method)
             * also implements IList<T> but makes the list read-only. That
             * is, if we call any of the methodes of IList<T> which changes
             * the contents of the list an exception is thrown:
             * "System.NotSupportedException: Collection is read-only". Note
             * that the ReadOnlyCollection<T> does not contain any methods
             * that can change the contents of the list such as Add(),
             * Clear(), Insert() and so on. That's why the example uses
             * IList<T> to further demonstrate that the
             * ReadOnlyCollection<T> is actually read-only. */

            IList<Person> readOnlyPersons = persons
                .AsReadOnly();

            // readOnlyPersons.Add(new Person()); // NotSupportedException.
            // readOnlyPersons.Clear(); // NotSupportedException.
            // readOnlyPersons.Insert(0, new Person()); // NotSupportedException.
        }

        private static void AsQueryable(List<Person> persons)
        {
            var resultSet = persons
                .AsQueryable(); // Returns an IQueryable<Person> object.
        }

        private static void AsParallel(List<Person> persons)
        {
            // Enables parallelization of a query.

            var resultSet = persons
                .AsParallel()
                .Select(p =>
                {
                    WriteLine("Sleeping...");
                    Thread.Sleep(1000);
                    return p.Age;
                });

            foreach (var item in resultSet)
            {
                WriteLine(item);
            }

            WriteLine("\r\nDone!");
        }

        private static void AsEnumerable()
        {
            // SEE: https://msdn.microsoft.com/en-us/library/bb335435(v=vs.110).aspx
        }

        private static void Any_Ovrld_01(List<Person> persons)
        {
            // persons = null; // Try this...
            // persons.Clear(); // and try this.
            bool? resultSet; // Note! Nullable bool.

            resultSet = persons? // We can use ? to avoid calling Any() if persons is null.
                .Any();
            // Determines whether a collection contains any elements.

            if (resultSet == null)
                WriteLine("The collection is null.");
            else
                // Since resultSet is nullable we must explicitly compare it.
                if (resultSet == true)
                WriteLine("The collection contains at least one element.");
            else
                WriteLine("The collection is empty (but not null).");
        }

        private static void Any_Ovrld_02(List<Person> persons)
        {
            int ageLimit = 54;

            var resultSet = persons
                .Any(person => person.Age > ageLimit);
            // Determines whether at least one (ANY) element in the
            // collection meets a condition or not.

            if (resultSet)
                WriteLine($"At least one person is above {ageLimit} years old.");
            else
                WriteLine($"No one is above {ageLimit} years old.");
        }

        private static void All(IEnumerable<Person> persons)
        {
            int ageLimit = 40;

            var resultSet = persons
                .All(person => person.Age >= ageLimit);
            // Determines whether ALL elements in the collection meets a condition or not.

            if (resultSet)
                WriteLine($"All are {ageLimit} years old or above.");
            else
                WriteLine($"Some or all are below {ageLimit} years old.");
        }

        private static void Aggregate_Ovrld_01()
        {
            int e1 = 1;
            int e2 = -100;
            int e3 = 99;
            int e4 = 10;

            int[] arrOfInt = new int[] { e1, e2, e3, e4 };

            var resultSet = arrOfInt
                .Aggregate((i1, i2) => i1 + i2);

            // Initially, the 1st parameter (i1) holds the value of the 1:st element in the collection.
            // For each iteration the result is transfered to the first parameter (i1)
            // e = element, r = result
            // (e1=1, e2=-100) => r1=-99
            // (r1=-99, e3=99) => r2=0
            // (r2=0, e4=10) => r3=10
            // resultSet == r3=10

            WriteLine(resultSet);
        }

        private static void Aggregate_Ovrld_02()
        {
            int[] arrOfInt = new int[] { 2, 3, 4, 5 };

            var resultSet = arrOfInt
                .Aggregate(8, (s, i) => s * i);
            /* Initially (before the first iteration), the 1st parameter of
             * the lambda expression (s) is assigned the value (8) of the
             * 1st parameter of the .Aggregate method.
             * 
             * The function result is transfered to the 1st parameter of
             * the lambda expression (s) in each iteration.
             * 
             * In the 1st iteration s =   8 and i = 2. (  8 * 2 =  16)
             * In the 2nd iteration s =  16 and i = 3. ( 16 * 3 =  48)
             * In the 3rd iteration s =  48 and i = 4. ( 48 * 4 = 192)
             * In the 4th iteration s = 192 and i = 5. (192 * 5 = 960) */

            WriteLine(resultSet);
        }

        private static void Aggregate_Ovrld_03(IEnumerable<Person> persons)
        {
            var resultSet = persons
                .Aggregate(100, (ageSum, person) => ageSum + person.Age, ageSum => $"Total age: {ageSum} years");
            /* Param 1: Initial (ageSum) accumulator value.
             * Param 2: Accumulator operation. Result transfered to ageSum in each iteration.
             * Param 3: Final return value (resultSet). In this case a string. Called once after all iterations. */

            WriteLine(resultSet);
        }

        private static void ToArray(IEnumerable<Person> persons)
        {
            /* Creates an array of the same type as the IEnumerable<T>
             * parameter. */
            var resultSet = persons
                .ToArray();

            foreach (var item in resultSet)
                WriteLine(item);

            WriteLine();
        }

        private static void ToList(IEnumerable<Person> persons)
        {
            /* Creates a List<T> of the same type as the IEnumerable<T>
             * parameter. */

            var resultSet = persons
                .ToList();

            foreach (var item in resultSet)
                WriteLine(item);

            WriteLine();
        }

        private static void ToDictionary_Ovrld_01(IEnumerable<Person> persons)
        {
            int key = 1;

            /* Param 1:
             * Determines the key for each item in the Dictionary. Can be
             * anything but must be unique. */
            var resultSet = persons
                .ToDictionary(p => p.FirstName + " " + key++);

            foreach (var item in resultSet)
                WriteLine($"Key: {item.Key}\tValue: {item.Value}");

            WriteLine();
        }
        private static void ToDictionary_Ovrld_02(IEnumerable<Person> persons)
        {
            FirstNameAge key = new FirstNameAge("", 0);

            /* Param 1:
             * Determines the key for each item in the Dictionary. Can be
             * anything but must (should) be unique.
             * 
             * Param 2:
             * Instance that implements the IEqualityComparer<T> interface.
             * Determines how the keys generated by Param 1 should be
             * compared. T would typically be of the same type as the
             * generated keys. Only necessary if the compiler can't
             * determine how the keys can be compared. I.e. this parameter
             * isn't necessary if the key is a value type such as string,
             * int, etc.*/
            var resultSet = persons
                .ToDictionary(p => new FirstNameAge(p.FirstName, p.Age), key);
            /* Test this by changing the age of "Håkan Doe" to 54, which
             * generates an exception. Then comment out the second
             * parameter "key" which will accept the duplicate key. */

            foreach (var item in resultSet)
                WriteLine($"Key: {item.Key}\tValue: {item.Value}");

            WriteLine();
        }
        private static void ToDictionary_Ovrld_03(IEnumerable<Person> persons)
        {
            /* Param 1:
             * Determines the key for each item in the Dictionary. Can be
             * anything but must (should) be unique.
             * 
             * Param 2:
             * Specifies a value (transformation) for each key.
             */
            var resultSet = persons
                .ToDictionary(p => p.Age, p => p.Employer);

            foreach (var item in resultSet)
                WriteLine($"Key: {item.Key}\tValue: {item.Value}");

            WriteLine();
        }
        private static void ToDictionary_Ovrld_04(IEnumerable<Person> persons)
        {
            FirstNameAge key = new FirstNameAge("", 0);

            /* Param 1:
             * Determines the key for each item in the Dictionary. Can be
             * anything but must (should) be unique.
             * 
             * Param 2:
             * Specifies a value for each key.
             * 
             * Param 3:
             * Instance that implements the IEqualityComparer<T> interface.
             * Determines how the keys generated by Param 1 should be
             * compared. T would typically be of the same type as the
             * generated keys. Only necessary if the compiler can't
             * determine how the keys can be compared. I.e. this parameter
             * isn't necessary if the key is a value type such as string,
             * int, etc.*/
            var resultSet = persons
                .ToDictionary(p => new FirstNameAge(p.FirstName, p.Age), p => p.Employer, key);
            /* Test this by changing the age of "Håkan Doe" to 54, which
             * generates an exception. Then comment out the second
             * parameter "key" which will accept the duplicate key. */

            foreach (var item in resultSet)
                WriteLine($"Key: {item.Key}\tValue: {item.Value}");

            WriteLine();
        }
        private static void ToLookup_Ovrld_01(IEnumerable<Person> persons)
        {
            /* Param 1:
             * Determines the key for each item in the Lookup. Can be
             * anything and doesn't have to be unique. In this case the key
             * will be the first address of the person's employer if
             * available. I.e. in this case each key (string) will represent
             * a collection of Persons having the same address. */
            ILookup<string, Person> resultSet = persons
                .ToLookup(p =>
                {
                    if (p.Employer.Addresses.Count > 0)
                        return p.Employer.Addresses[0];
                    else
                        return "N/A";
                });

            foreach (IGrouping<string, Person> group in resultSet)
            {
                WriteLine($"{group.Key}:");

                foreach (Person person in group)
                    WriteLine($"{person}");

                WriteLine();
            }
        }
        private static void ToLookup_Ovrld_02(IEnumerable<Person> persons)
        {
            KeyClass keyClass = new KeyClass("");

            /* Param 1:
             * Determines the key for each item in the Lookup. Can be
             * anything and doesn't have to be unique. In this case the key
             * is based on the KeyClass class (which represents the length
             * of the person's FirstName). I.e. in this case each key of
             * type KeyClass will represent a collection of Persons having
             * the same FirstName length. */

            /* Param 2:
             * Instance that implements the IEqualityComparer<T> interface.
             * Determines how the keys generated by Param 1 should be
             * compared. T would typically be of the same type as the
             * generated keys. Only necessary if the compiler can't
             * determine how the keys can be compared. I.e. this parameter
             * isn't necessary if the key is a value type such as string,
             * int, etc.*/
            ILookup<KeyClass, Person> resultSet = persons
                .ToLookup(p =>
                {
                    var x = new KeyClass(p.FirstName);
                    return x;
                }, keyClass);

            foreach (IGrouping<KeyClass, Person> group in resultSet)
            {
                WriteLine($"{group.Key}:");

                foreach (Person person in group)
                    WriteLine($"{person}");

                WriteLine();
            }
        }
        private static void ToLookup_Ovrld_03(IEnumerable<Person> persons)
        {
            KeyClass keyClass = new KeyClass("");

            /* Param 1:
             * Determines the key for each item in the Lookup. Can be
             * anything and doesn't have to be unique. In this case the key
             * is based on length of each person's FirstName. I.e. in this
             * case each key of type int will represent a collection of
             * strings generated by param 2. */

            /* Param 2:
             * A transform function to produce a result element value from
             * each element. */

            ILookup<int, string> resultSet = persons
                .ToLookup(
                p => p.FirstName.Length,
                p => $"Namn: {p.FirstName + " " + p.LastName}, Företag: {p.Employer.CompanyName}");

            foreach (IGrouping<int, string> group in resultSet)
            {
                WriteLine($"{group.Key}:");

                foreach (string info in group)
                    WriteLine(info);

                WriteLine();
            }
        }
        private static void ToLookup_Ovrld_04(IEnumerable<Person> persons)
        {
            KeyClass keyClass = new KeyClass("");

            /* Param 1:
             * Determines the key for each item in the Lookup. Can be
             * anything and doesn't have to be unique. In this case the key
             * is based on the KeyClass class which represents the length
             * of the person's FirstName. I.e. in this case each key of
             * type KeyClass will represent a collection of strings
             * generated by Param 2. */

            /* Param 2:
             * A transform function to produce a result element value from
             * each element. */

            /* Param 3:
             * Instance that implements the IEqualityComparer<T> interface.
             * Determines how the keys generated by Param 1 should be
             * compared. T would typically be of the same type as the
             * generated keys. Only necessary if the compiler can't
             * determine how the keys can be compared. I.e. this parameter
             * isn't necessary if the key is a value type such as string,
             * int, etc.*/

            ILookup<KeyClass, string> resultSet = persons
                .ToLookup(p =>
                {
                    var x = new KeyClass(p.FirstName);
                    return x;
                },
                p => $"Namn: {p.FirstName + " " + p.LastName}, Företag: {p.Employer.CompanyName}",
                keyClass);

            foreach (IGrouping<KeyClass, string> group in resultSet)
            {
                WriteLine($"{group.Key}:");

                foreach (string info in group)
                    WriteLine(info);

                WriteLine();
            }
        }

        private static List<Person> CreateListOfPersons()
        {
            List<Person> persons = new List<Person>();

            persons.AddRange(new Person[]
            {
                    new Person("Håkan", "Johansson", 54, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "Keges Grosshandel AB",
                            YearFounded = 1974,
                            Country = "Sverige",
                            Addresses = new List<string> { "Visby" }
                        }
                    },
                    new Person("Patrik", "Jönsson", 43, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "Pattzor AB",
                            YearFounded = 1998,
                            Country = "Sverige",
                            Addresses = new List<string> { "Malmö" }
                        }
                    },
                    new Person("Pontus", "Wittenmark", 37, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "WarmKitten AB",
                            YearFounded = 1998,
                            Country = "Sverige",
                            Addresses = new List<string> { "Söder" }
                        }
                    },
                    new Person("Micael", "Holmström", 44, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "Academic Work AB",
                            YearFounded = 1996,
                            Country = "Tyskland",
                            Addresses = new List<string> { "Sthlm", "Göteborg", "Sundsvall" }
                        }
                    },
                   new Person("Carl", "Johansson", 55, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "Academy AB",
                            YearFounded = 2016,
                            Country = "Tyskland",
                            Addresses = new List<string> { "Kista" }
                        }
                    },
                    new Person("Emelie", "Bernhardsson", 36, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "Academy AB",
                            YearFounded = 2016,
                            Country = "Tyskland",
                            Addresses = new List<string> { "Kista" }
                        }
                    },
                    new Person("Frida", "Larsson", 38, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "Academy AB",
                            YearFounded = 2016,
                            Country = "Tyskland",
                            Addresses = new List<string> { "Kista" }
                        }
                    },
                    new Person("Håkan", "Doe", 54, new ComplexKey(1, "B", false))
                    {
                        Employer = new Company
                        {
                            CompanyName = "N/A",
                            Country = "Polen"
                        }
                    }
            });

            return persons;
        }
    }
}