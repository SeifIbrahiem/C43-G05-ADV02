using System.Collections;
using System.Collections.Generic;

namespace C43_G05_ADV02
{
    internal class Program
    {
        public static void printArrayList(ArrayList arrayList) 
        {
            Console.WriteLine();
            foreach (int i in arrayList)
            {
                Console.Write($" {i} ");
            }
           Console.WriteLine();
        }

        
        public static int SumArrayList(ArrayList List)
        {
           int sum = 0;
            if (List is not null)
            {
                for (int i = 0; i < List.Count; i++)  // unboxing reference type to value type un safe 

                {
                    sum += (int)List[i];

               }
            }
            return sum;
        } 
        

        public static void PrintList <T>(List<T> values)
        {
           Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($" { item }  ");
            }
            Console.WriteLine();
        }

        //generic list
        public static int SumList(List <int> List)
        {
            int sum = 0;
            if (List is not null)
            {
                for (int i = 0; i < List.Count; i++)  

                {
                    sum += List[i];

                }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            #region what is the ds / non generic lists

            //Collection : built in ds in C#
            //*Array :container
            //Data structure : Araaybased  or  nodebased 
            //Hash table 
            //collection in c# (lists or hashtable)
            //lists (generic or no generic )
            //generic lists (list - linkedlist - stack - queue )
            //non generic lists (arraylist - stack - qeue)
            //Hashtables
            //nongrneric (hashtable)
            //generic     (dictionary/sorteddictionary)
            //----------------------------------------//
            //lists
            //non generic lists : array list
            //arraylist like array 
            //arraybased 
            //index
            //array indexcollection:fixedsize
            //arraylist indexcollection:dynamicsize
            //Index:0 1 2 3 4 5 6 
            //itemes:4 5 6 7 8 9 1
            //size:1
            //Arr[1]=5
            //int[] number = { 1, 2, 3, 4, 5, };
            //Console.WriteLine(number[1]);
            //number[2] = 8;
            //Console.WriteLine(number[2]);
            //ArrayList list = new ArrayList();
            //Console.WriteLine($"cont:{list.Count}");
            //Console.WriteLine($"cont:{list.Count} , {list.Capacity}");
            //list.Add(1);
            //Console.WriteLine($"cont:{list.Count} , {list.Capacity}");
            //ArrayList list = new ArrayList(new int [] { 1,2,3,4,5});
            //Console.WriteLine($"cont:{list.Count} , {list.Capacity}");
            //list.Add(10);
            //Console.WriteLine($"cont:{list.Count} , {list.Capacity}");
            //list.Add(11);
            //Console.WriteLine($"cont:{list.Count} , {list.Capacity}");
            //list.Add(11);
            //list.Add(18);
            //list.Add(19);
            //list.Add(17);
            //Console.WriteLine($"cont:{list.Count} , {list.Capacity}");
            //Console.WriteLine(Array.MaxLength);
            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //int[] number = { 1, 2, 3, 4, 5, };
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(5);
            //list.AddRange(new [] {1,2,3,4});
            //printArrayList(list);
            //int Index = list.BinarySearch(2);
            //Console.WriteLine(Index);
            //Employee EO1 = new Employee() { Id=1 ,Name="seif",salary=1000 ,age = 29 };
            //Employee EO2 = new Employee() { Id=1, Name="samy",salary=1000, age = 29 };
            //Employee EO3 = new Employee() { Id=1, Name="ali", salary=1000, age = 29 };
            //Employee EO4 = new Employee() { Id=1, Name="omar",salary=1000, age = 29 };

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] { EO1, EO2, EO3, EO4 });
            //int Index = list.BinarySearch(EO4);
            //Console.WriteLine($"index: {Index}");
            //Console.WriteLine("=================================");
            //foreach (Employee i in list) 
            //{

            //    Console.WriteLine(i);
            //}


            #endregion


            #region problemwithgenericlist
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add("hello");
            //int sum = SumArrayList(list);
            //Console.WriteLine(sum); 
            #endregion

            #region genericlist
            //List<int> list = new List<int>(new int[] {1,2,3,4});
            //PrintList(list);
            //list.Add(11);
            //list.Add(12);
            //PrintList(list);
            List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //PrintList(list);
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //PrintList(list);
            //int sum = SumList (list);
            //Console.WriteLine(sum);
            //list.AddRange(new List<int>() { 10, 20, 30 });
            //PrintList(list);
            //list.AsReadOnly();
            //PrintList(list);

            //int i = list.BinarySearch(20);
            //Console.WriteLine($"i: {i}  ");

            // Employee EO1 = new Employee() { Id=1 ,Name="seif",salary=1000 ,age = 29 };
            // Employee EO2 = new Employee() { Id=1, Name="samy",salary=1000, age = 29 };
            // Employee EO3 = new Employee() { Id=1, Name="ali", salary=1000, age = 29 };
            // Employee EO4 = new Employee() { Id=1, Name="omar",salary=1000, age = 29 };
            // List<Employee> employees = new List<Employee> {EO1, EO2 ,EO3 , EO4 };
            //int i =  employees.BinarySearch(EO1);
            // Console.WriteLine(i);

            //Console.WriteLine($"count: {list.Count} , capacity: {list.Capacity}");
            //         list.EnsureCapacity(list.Count);
            //Console.WriteLine($"count: {list.Count} , capacity: {list.Capacity}");
            //list.EnsureCapacity(10);
            //Console.WriteLine($"count: {list.Count} , capacity: {list.Capacity}");

            //List<int>result = list.GetRange(0, 2);
            //PrintList(result);
            #endregion


        }
    }
}
