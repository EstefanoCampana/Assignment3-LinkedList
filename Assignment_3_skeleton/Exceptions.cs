﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_LinkedLists
{
    public class ListIndexOutOfRangeException : Exception
    {
        public ListIndexOutOfRangeException() : base("Target Index Out of Bounds For Linked List.") { }
    }

    public class EmptyListException : Exception
    {
        public EmptyListException() : base("The list is already empty.") { }
        public EmptyListException(int index) : base("The inputted value is out of range for the linked list.") { }
    }
}
