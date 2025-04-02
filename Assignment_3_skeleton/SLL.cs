using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_3_LinkedLists
{
    public class SLL : LinkedListADT
    {
        private Node head;
        private Node tail;
        private int listSize;

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }
        public int ListSize { get => listSize; set => listSize = value; }

        public void Append(object data)
        {
            listSize++;
            if (FixListNull(data) == true)
            {
                return;
            }
            tail.Next = new Node(data);
            tail = tail.Next;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Console.WriteLine("List cleared");
        }

        public bool Contains(object data)
        {
            Node current = head; //initialize "current"
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true; //data found
                }
                current = current.Next;
            }
            return false; //data not found
        }

        public void Delete(int targetIndex)
        {
            try
            {
                int index = 0;
                if (CheckListNull() is true)
                {
                    throw new EmptyListException();
                }
                if (targetIndex < 0 || targetIndex > ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
                {
                    if (targetIndex == 0)
                    {
                        head = head.Next;
                        return;
                    }

                    if (index + 1 == targetIndex)
                    {
                        if (tempNode.Next == tail)
                        {
                            tail = tempNode;
                            tail.Next = null;
                            return;
                        }
                        else
                        {
                            tempNode.Next = tempNode.Next.Next;
                            return;
                        }
                    }
                    index++;
                }
            }

            catch (ListIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int IndexOf(object target)
        {
            if (CheckListNull() is true)
            {
                return -1;
            }

            int index = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (tempNode.Data.ToString() == target.ToString())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public void Insert(object data, int targetIndex)
        {
            try
            {
                listSize++;
                if (CheckListNull() is true && targetIndex > 0)
                {
                    throw new ListIndexOutOfRangeException();
                }
                if (targetIndex > ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                if (targetIndex == 0)
                {
                    if (CheckListNull() is true)
                    {
                        head = tail = new Node(data);
                    }
                    else
                    { // no work
                        Node temp = head;
                        head = new Node(data, temp);
                    }
                }
                int index = 0;
                for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
                {
                    if (index + 1 == targetIndex)
                    {
                        if (tempNode.Next == tail)
                        {
                            Console.WriteLine("Here");
                            Append(tail.Data);
                            tempNode.Next = new Node(data, tail);
                        }
                        else
                        { // in between
                            Console.WriteLine("IN ELSE");
                            Node temp = tempNode.Next;
                            tempNode.Next = new Node(data, temp);
                        }
                    }
                    index++;
                }
            }
            catch (ListIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool IsEmpty()
        {
            if (head is null && tail is null)
            {
                Console.WriteLine("List is Empty.");
                return true;
            }
            return false;
        }

        public void Prepend(object data)
        {
            listSize++;
            if (FixListNull(data) == true)
            {
                return;
            }
            Node new_node = new Node(data);
            new_node.Next = head;
            head = new_node;
        }

        public void Replace(object data, int targetIndex)
        {
            try
            {
                int index = 0;
                if (CheckListNull() is true)
                {
                    throw new EmptyListException();
                }
                if (targetIndex < ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
                {
                    if (targetIndex == 0)
                    {
                        head = new Node(data, head.Next);
                        return;
                    }

                    if (index + 1 == targetIndex)
                    {
                        if (tempNode == tail)
                        {
                            tail = new Node(data);
                            return;
                        }
                        else
                        {
                            tempNode.Next = new Node(data, tempNode.Next.Next);
                            //tail = tempNode.Next;
                            return;
                        }
                    }
                    index++;
                }
            }
            catch (ListIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public object Retrieve(int targetIndex)
        {
            try
            {
                if (CheckListNull() is true)
                {
                    throw new EmptyListException();
                }
                if (targetIndex == 0)
                {
                    return head.Data;
                }
                if (targetIndex < 0 || targetIndex > ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                int index = 0;
                for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
                {
                    if (index + 1 == targetIndex)
                    {
                        if (tempNode.Next == tail)
                        {
                            return tail.Data;
                        }
                        else
                        {
                            return tempNode.Next.Data;
                        }
                    }
                    index++;
                }
                return -1;
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (ListIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int Size()
        {
            if (head is null)
            {
                return 0;
            }
            Console.Write(listSize);
            return listSize;
        }

        // EXTRA METHODS
        public void PrintList()
        {
            if (CheckListNull() is true)
            {
                return;
            }
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                Console.Write(tempNode.Data.ToString() + "  ");
            }
            Console.WriteLine();
        }

        public Node GetHead()
        {
            if (CheckListNull() is true)
            {
                return null;
            }
            return head;
        }

        public Node GetTail()
        {
            if (CheckListNull() is true)
            {
                return null;
            }
            return tail;
        }

        public void PrintData()
        {
            if (CheckListNull() is true)
            {
                return;
            }
            PrintList();
            Console.WriteLine("\nHEAD: " + GetHead().Data);
            Console.WriteLine("TAIL: " + GetTail().Data + "\n\n");
        }

        public bool CheckListNull()
        {
            if (head is null && tail is null)
            {
                Console.WriteLine("List was NULL\n\n");
                return true;
            }
            return false;
        }

        public bool FixListNull(object data)
        {
            if (Head is null && Tail is null)
            {
                Head = Tail = new Node(data);
                return true;
            }
            return false;
        }

        public void JoinList(SLL appendList)
        {
            try
            {
                if (Head == null && Tail == null)
                {
                    throw new EmptyListException();
                }
                else
                {
                    Node current = appendList.Head;
                    while(current != null)
                    {
                        this.Append(current.Data);
                        current = current.Next;
                    }
                }
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
