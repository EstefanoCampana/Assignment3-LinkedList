using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_LinkedLists
{
    internal class Program
    {
        public static SLL list = new SLL();
        public static SLL list2 = new SLL();
        public static SLL list3 = new SLL();
        public static SLL list4 = new SLL();

        static void Main(string[] args)
        {
            Console.WriteLine("Function [PRINT]");
            list.PrintData();

            Console.WriteLine("Function [Append] 'a'");
            list.Append('a');
            list.PrintList();

            Console.WriteLine("Function [Append] 'b'");
            list.Append('b');
            list.PrintList();

            Console.WriteLine("Function [Append] 'c'");
            list.Append('c');
            list.PrintData();

            Console.WriteLine("Function [Append] 'a'");
            list2.Append('a');
            list2.PrintList();

            Console.WriteLine("Function [Append] 'b'");
            list2.Append('b');
            list2.PrintList();

            Console.WriteLine("Function [Append] 'c'");
            list2.Append('c');
            list2.PrintData();

            Console.WriteLine("Function [Append] 'a'");
            list3.Append('a');
            list3.PrintList();

            Console.WriteLine("Function [Append] 'b'");
            list3.Append('b');
            list3.PrintList();

            Console.WriteLine("Function [Append] 'c'");
            list3.Append('c');
            list3.PrintData();

            list.JoinList(list2);
            list.JoinList(list3);
            list.PrintList();

            Console.WriteLine("Function Add Beginning '1'");
            list4.AddBeginning('1');
            list4.PrintList();

            Console.WriteLine("Function Add End '2'");
            list4.AddEnd('2');
            list4.PrintList();

            Console.WriteLine("Function Remove At Position 1");
            list4.RemoveAt(1);
            list4.PrintList();

            Console.WriteLine("Function Insert At");
            list4.InsertAt(1, '3');
            list4.InsertAt(1, '2');
            list4.InsertAt(3, '4');
            list4.PrintList();
            list4.InsertAt(0,'a');
            list4.PrintList(); 

            Console.WriteLine("Function Remove Start");
            list4.RemoveStart();
            list4.PrintList();

            Console.WriteLine("Function Remove End");
            list4.RemoveEnd();
            list4.PrintList();

            Console.WriteLine("Exception throw");
            list4.RemoveAt(6);
            list4.InsertAt(7, '4');
            list4.Clear();
            Console.WriteLine("Empty list Exception throw");
            list4.RemoveStart();
            list4.RemoveEnd();
            list4.RemoveAt(0);

            Console.WriteLine("Insert At Empty list");
            list4.InsertAt(0, '1');
            list4.PrintList();




            //Console.WriteLine("Function [Retrieve] '0' ");
            //Console.WriteLine(list.Retrieve(0));

            //Console.WriteLine("Function [Retrieve] '1' ");
            //Console.WriteLine(list.Retrieve(1));

            //Console.WriteLine("Function [Retrieve] '2' ");
            //Console.WriteLine(list.Retrieve(2));
            //list.PrintData();

            //Console.WriteLine("\n\nFunction [Insert] 'd' at '0'");
            //list.Insert('d', 0);
            //list.PrintList();

            //Console.WriteLine("Function [Insert] '1' at '1'");
            //list.Insert('1', 1);
            //list.PrintList();

            //Console.WriteLine("Function [Insert] '2' at '2'");
            //list.Insert('2', 2);
            //list.PrintData();

            //Console.WriteLine("Function [Replace] 'c' with 'e'");
            //list.Replace('e', 2);
            //list.PrintData();

            //Console.WriteLine("Function [Delete] at index 2");
            //list.Delete(2);
            //list.PrintData();


            //Console.WriteLine("Function [FindIndexOf] 'b'");
            //Console.WriteLine("Index found: " + list.IndexOf('b') + "\n\n");


            //Console.WriteLine("Function [Clear]");
            //list.Clear();
            //list.PrintData();

            //Console.WriteLine("Function [Size]");
            //list.Size();
            //list.PrintData();



            //Console.ReadKey();
        }
    }
}
