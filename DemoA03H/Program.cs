using DemoA03H.Dictionary;
using DemoA03H.Hashset;
using DemoA03H.HashTable;
using DemoA03H.SortedDictionary;
using DemoA03H.Sortedset;
using System.Collections;
using System.Reflection.Metadata;

namespace DemoA03H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region non-generic[Hash Table]
            /*
             * key must unique and not null
             * value can be null
             * hash table pair value 
             * default size =3
             */

            //  Hashtable ht = new Hashtable(new StringEqualityCompare()) {
            //{ "fady", 1233 },{ "aymem", 1563 }
            //using indexer
            //["fady"]=454,
            // ["aymen"]=154,
            // ["maged"]=354   };
            // ht.Add("fady", 124);
            //ht.Add("Aymen", 236);
            //ht.Add("maged", 134);


            //foreach (object i in ht) {
            //Console.WriteLine(i);
            // }
            //print specified data =>Dictionary entry
            #region Using indexer
            //Use indexer for get value
            // Console.WriteLine(ht["fady"]);
            //Use indexer for set value 
            // ht["fady"] = 1235845;
            //Console.WriteLine(ht["fady"]);
            //Use indexer for Add new  value 
            //ht["Ali"] = 452454;
            //Console.WriteLine(ht["Ali"]);
            #endregion
            //  if (!ht.Contains("fady"))
            //    ht.Add("fady", 45544);
            // else
            //      Console.WriteLine("Already exist ");
            // ht.Add("Fady",4546);


            //   foreach (DictionaryEntry i in ht)
            //  {
            //      Console.WriteLine($"Name : {i.Key} , Number : {i.Value}");
            //
            //   }





            #endregion

            #region Generic Collection
            #region Example 1
            //   Dictionary<string ,int> ht2 = new Dictionary<string, int>()
            //   {   {"Hossam",111 }
            //       ,{"Salma",222},
            //      {"ali",333}  };

            #region Indexer
            //Use indexer for get value
            // Console.WriteLine(ht2["Hossam"]);
            //Use indexer for set value 
            // ht2["ali"] = 1235845;
            // Console.WriteLine(ht2["ali"]);
            //Use indexer for Add new  value 
            // ht2["Ali"] = 452454;
            // Console.WriteLine(ht2["Ali"]);
            #endregion
            #region pass as array
            // KeyValuePair<string, int>[] arr =
            // {
            //   new ("osama",1551),
            //  new ("Fady",1455)
            // };
            //ht2=new Dictionary<string, int> (arr ,new StringEqualityCompare());
            #endregion
            #region Try To Add

            //ht2.Add("Hossam", 4545);
            //Console.WriteLine(ht2["fady"]);
            // bool result = ht2.TryGetValue("fady", out int number);
            // Console.WriteLine(result);
            // Console.WriteLine(number);

            #endregion

            // foreach (KeyValuePair<string, int> item in ht2)
            // {
            //   Console.WriteLine($" Name :{item.Key} ,Number : {item.Value}");

            //}
            #endregion
            #region Example 2
            //   Employee emp1 = new Employee(10 ,"Hossam",10000); 
            //  Employee emp2 = new Employee(20 ,"Ali",5000); 
            //   Employee emp3 = new Employee(30 ,"Menna",7000); 

            //  Dictionary<Employee ,string > employees = new Dictionary<Employee ,string>()
            // {
            //   [emp1]="1st",
            //  [emp2]="2ed",
            //  [emp3]="3rd"

            // };
            // Employee emp4 = new Employee(30, "Menna", 7000);
            // employees.Add(emp4, "4h");

            // foreach (var item in employees)
            // {
            //     Console.WriteLine(item);
            //}



            #endregion
            #endregion
            #region Generic Collection [sorted Dictionary]
            #region Eample 1
            // SortedDictionary<string ,int > sd= new SortedDictionary<string, int>(new StringCompare())
            //  {
            ///    ["salma"]=111,
            //    ["menna"]=222,
            //    ["karem"]=333,
            //  ["ahmed"]=444,
            // ["bassent"]=444,
            //  ["ali"]=444,
            //  };
            //  foreach (var item in sd)
            //  {
            //   Console.WriteLine(item);
            //  }
            #endregion
            #region example 2
            // Employee e1 = new Employee(10, "Hossam", 10000);
            //  Employee e2 = new Employee(20, "Ali", 5000);
            // Employee e3 = new Employee(30, "Menna", 7000);
            // SortedDictionary<Employee , string >sortedemps = new SortedDictionary<Employee , string>()
            // {
            //   [e1]="1st",
            //  [e2]="2ed",
            //  [e3]="3rd",
            //};
            // foreach (var item in sortedemps)
            //{
            //   Console.WriteLine(item);
            //}
            #endregion
            #region Generic collection [sorted list]
            //   SortedList<string , int> pho = new SortedList<string, int>() 
            // {
            //   ["salma"]=111,  
            // ["omer"]=222,
            //  ["maya"]=333,  
            //  ["mohamed"]=444,  
            // ["ali"]=555,  
            // ["aya"]=666 
            //  };

            //access any element using 
            /// Console.WriteLine(pho.GetValueAtIndex(0));
            // Console.WriteLine(pho.GetValueAtIndex(0));

            //  foreach (var s in pho) 
            //  {
            //     Console.WriteLine(s);
            // }

            #endregion
            #region Generic collection [hashset]
            #region EXAMPLE 1
            // HashSet<int > keys = new HashSet<int>();
            //keys.Add(1);
            //  keys.Add(2);
            // keys.Add(3);
            // keys.Add(1);
            //foreach (var item in keys)
            //{
            //  Console.WriteLine(item);   
            //}
            #endregion
            #region example 2
            //HashSet<Series> series = new HashSet<Series>() {
            //    new  Series(100,"GAme Of throuns",1000),
            //    new  Series(100,"GAme Of throuns",1000),
            //    new  Series(100,"GAme Of throuns",1000),
            //    new  Series(100,"GAme Of throuns",1000),
            //    new Series(200, "Vikings", 100),
            //    new  Series(300,"Dexter",100),
            //    new  Series(300,"Dexter",100)
            //};
            //foreach (var item in series)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region HashSet methods
            //HashSet <int> set01= new HashSet<int>() { 1,2,3,4,5};
            //HashSet <int> set02= new HashSet<int>() { 1,2,3,4,5,6,7,8,9,10};
            //set02.ExceptWith (set01);
            //foreach (var item in set02)
            //{
            //    Console.WriteLine(item);
            //}
            //set02.IntersectWith(set01);
            //set01.SymmetricExceptWith(set02);

            //Console.WriteLine(set01.IsSubsetOf(set02));

            #endregion
            #endregion
            #region Generic collection [sortedset]
            //SortedSet<int> numbers = new SortedSet<int>(new IntCompare());
            //numbers.Add(4);
            //numbers.Add(8);
            //numbers.Add(2);
            //numbers.Add(6);
            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

        }
    }
}