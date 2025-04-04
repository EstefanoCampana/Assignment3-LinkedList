using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_LinkedList
{
    internal class Program
    {
        public static SLL list = new SLL();
        public static SLL list2 = new SLL();
        public static SLL list3 = new SLL();
        public static SLL list4 = new SLL();

        public static SLL users = new SLL();

        static void Main(string[] args)
        {
            Console.WriteLine("Function [PRINT]");
            list.PrintData();


            Console.WriteLine("Function [Append] 'a'");
            list.AddEnd('a');
            list.PrintList();

            Console.WriteLine("Function [Append] 'b'");
            list.AddEnd('b');
            list.PrintList();

            Console.WriteLine("Function [Append] 'c'");
            list.AddEnd('c');
            list.PrintData();

            list2.JoinList(list);

            Console.WriteLine("Function [Append] 'a'");
            list2.AddEnd('d');
            list2.PrintList();

            Console.WriteLine("Function [Append] 'b'");
            list2.AddEnd('e');
            list2.PrintList();

            Console.WriteLine("Function [Append] 'c'");
            list2.AddEnd('f');
            list2.PrintData();

            Console.WriteLine("Function [Append] 'a'");
            list3.AddEnd('g');
            list3.PrintList();

            Console.WriteLine("Function [Append] 'b'");
            list3.AddEnd('h');
            list3.PrintList();

            Console.WriteLine("Function [Append] 'c'");
            list3.AddEnd('i');
            list3.PrintData();

            list.JoinList(list2);
            list.JoinList(list3);
            list.PrintList();
            SLL list5 = list.Divide(4);

            list.PrintData();
            list5.PrintData();
            SLL list6 = list5.Divide(2);
            list.PrintData();
            list5.PrintData();
            list6.PrintData();

            Console.WriteLine("\nFunction [AddBeginning] '1'");
            list4.AddBeginning('1');
            list4.PrintList();

            Console.WriteLine("\nFunction [AddEnd] '2'");
            list4.AddEnd('2');
            list4.PrintList();

            Console.WriteLine("\nFunction [RemoveAt] Position 1");
            list4.RemoveAt(1);
            list4.PrintList();

            Console.WriteLine("\nFunction [InsertAt]");
            list4.InsertAt(1, '3');
            list4.InsertAt(1, '2');
            list4.InsertAt(3, '4');
            list4.PrintList();
            list4.InsertAt(0, 'a');
            list4.PrintList();

            Console.WriteLine("\nFunction [RemoveStart]");
            list4.RemoveStart();
            list4.PrintList();

            Console.WriteLine("\nFunction [RemoveEnd]");
            list4.RemoveEnd();
            list4.PrintList();

            Console.WriteLine("\nException throw for RemoveAt method and InsertAt method");
            list4.RemoveAt(6);
            list4.InsertAt(7, '4');
            list4.Clear();
            Console.WriteLine("\nEmpty list Exception throw for RenmoveStart, RemoveEnd and RemoveAt");
            list4.RemoveStart();
            list4.RemoveEnd();
            list4.RemoveAt(0);

            Console.WriteLine("\nFunction [InsertAt] in Empty list");
            list4.InsertAt(0, '1');
            list4.PrintList();


            User user1 = new User(1, "Peter", "peter@gmail.com", "password");
            users.AddEnd(user1);
            User user2 = new User(2, "Mary", "mary@gmail.com", "password");
            users.AddEnd(user2);
            User user3 = new User(3, "Abby", "abby@gmail.com", "password");
            users.AddEnd(user3);
            users.SortByName();
            Console.WriteLine("\nAfter sort (users):");
            Console.WriteLine($"This List Size is: {users.ListSize}");
            Console.WriteLine(users.GetNameAt(0));
            Console.WriteLine(users.GetNameAt(1));
            Console.WriteLine(users.GetNameAt(2));
            Console.WriteLine("\nThrow Exceptiion of out of boundary for GetNameAt method");
            Console.WriteLine(users.GetNameAt(3));
            users.Clear();
            Console.WriteLine("\nThrow Exceptiion of empty list for GetNameAt method");
            Console.WriteLine(users.GetNameAt(0));
        }
    }
}
