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

        public void AddBeginning(object data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
            }
            Head = newNode;
            ListSize++;
        }

        public void AddEnd(object data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            ListSize++;
        }

        public void RemoveAt(int index)
        {
            try
            {
                Node current = Head;
                if (ListSize == 0)
                {
                    throw new EmptyListException();
                }
                else if (index < 0 || index > (ListSize - 1))
                {
                    throw new ListIndexOutOfRangeException();
                }
                else
                {
                    if (index == 0)
                    {
                        RemoveStart();
                    }
                    else if (index == (ListSize - 1))
                    {
                        RemoveEnd();
                    }
                    else
                    {
                        for (int i = 0; i <= index; i++)
                        {
                            if (i == (index - 1))
                            {
                                current.Next = current.Next.Next;
                            }
                            current = current.Next;
                        }
                        ListSize--;
                    }
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

        public void RemoveStart()
        {
            try
            {
                if (Head != null)
                {
                    Head = Head.Next;
                    if (Head == null)
                    {
                        Tail = null;
                    }
                    ListSize--;
                }
                else
                {
                    throw new EmptyListException();
                }
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveEnd()
        {
            try
            {
                if (Head != null)
                {
                    if (Head.Next == null)
                    {
                        Head = null;
                        Tail = null;
                    }
                    else
                    {
                        Node current = Head;
                        while (current.Next.Next != null)
                        {
                            current = current.Next;
                        }
                        current.Next = null;
                        Tail = current;
                    }
                    ListSize--;
                }
                else
                {
                    throw new EmptyListException();
                }
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertAt(int index, object data)
        {
            try
            {
                Node newNode = new Node(data);
                Node current = Head;
                if (index < 0 || index > ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                else
                {
                    if (index == 0)
                    {
                        AddBeginning(data);
                    }
                    else if ((index == ListSize - 1) && (ListSize != 2))
                    {
                        AddEnd(data);
                    }
                    else
                    {
                        for (int i = 0; i <= index; i++)
                        {
                            if (i == index - 1)
                            {
                                newNode.Next = current.Next;
                                current.Next = newNode;
                            }
                            current = current.Next;
                        }
                    }
                    ListSize++;
                }
            }
            catch (ListIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            ListSize = 0;
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

        public bool IsEmpty()
        {
            if (head is null && tail is null)
            {
                Console.WriteLine("List is Empty.");
                return true;
            }
            return false;
        }

        //Sheeba changed 
        public void Replace(object data, int targetIndex)
        {
            try
            {
                if (Head == null)
                {
                    throw new EmptyListException();
                }

                if (targetIndex < 0) 
                {
                    throw new ListIndexOutOfRangeException();
                }

                int index = 0;
                Node currentNode = Head;

                // Special case: Replacing the head node
                if (targetIndex == 0)
                {
                    Head = new Node(data, Head.Next);
                    if (Head.Next == null)
                        Tail = Head; // If the list had only one element, update Tail
                    return;
                }

                // Traverse to the target index
                while (currentNode != null)
                {
                    if (index == targetIndex - 1)
                    {
                        if (currentNode.Next == null)
                            throw new ListIndexOutOfRangeException();

                        currentNode.Next = new Node(data, currentNode.Next.Next);

                        // Update Tail if replacing the last node
                        if (currentNode.Next.Next == null)
                            Tail = currentNode.Next;

                        return;
                    }
                    currentNode = currentNode.Next;
                    index++;
                }
            }
            catch(ListIndexOutOfRangeException ex)
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
                    return Head.Data;
                }
                if (targetIndex < 0 || targetIndex > ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                int index = 0;
                for (Node tempNode = Head; tempNode != null; tempNode = tempNode.Next)
                {
                    if (index + 1 == targetIndex)
                    {
                        if (tempNode.Next == Tail)
                        {
                            return Tail.Data;
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
            if (Head is null)
            {
                return 0;
            }
            Console.Write(ListSize);
            return ListSize;
        }

        // EXTRA METHODS
        public void PrintList()
        {
            if (CheckListNull() is true)
            {
                return;
            }
            for (Node tempNode = Head; tempNode != null; tempNode = tempNode.Next)
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
            return Head;
        }

        public Node GetTail()
        {
            if (CheckListNull() is true)
            {
                return null;
            }
            return Tail;
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
            if (Head is null && Tail is null)
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
                        this.AddEnd(current.Data);
                        current = current.Next;
                    }
                }
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Used to divide a list in two at a specified index.
        /// </summary>
        /// <param name="index">Index to separate the list in two.</param>
        /// <exception cref="EmptyListException">Thrown if trying split an empty list.</exception>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if the index specified is larger than the list size.</exception>
        /// <returns>The new list created from dividing another list.</returns>
        public SLL Divide(int index)
        {
            try
            {
                if (index > ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                if (Head == null && Tail == null)
                {
                    throw new EmptyListException();
                }
                else
                {
                    Node current = Head;
                    int count = 0;
                    SLL newList = new SLL();
                    while (current != null)
                    {
                        if (count == index)
                        {
                            //newList.Append(current.Data);
                            while (current != null)
                            {
                                this.RemoveAt(count);
                                newList.AddEnd(current.Data);
                                current = current.Next;
                            }
                            break;
                        }
                        count++;
                        current = current.Next;
                    }
                    return newList;
                }
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

        public void SortByName()
        {
            Node current = head;

            // Create a User List for store the object
            List<User> userList = new List<User>();

            while (current != null)
            {
                User currentUser = current.Data as User;
                if (currentUser != null)
                {
                    userList.Add(currentUser);
                }
                current = current.Next;
            }

            // Sort the User List by Name
            userList = userList.OrderBy(u => u.Name).ToList();

            // Delete the original object and add the sorted object at the end
            foreach (User user in userList)
            {
                RemoveStart();
                AddEnd(user);
            }
        }


        public string GetNameAt(int index)
        {
            try
            {
                Node current = head;
                User user = null;
                if (ListSize == 0)
                {
                    throw new EmptyListException();
                }
                else if (index < 0 || index >= ListSize)
                {
                    throw new ListIndexOutOfRangeException();
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    user = current.Data as User;
                }
                return user.getName();
            }
            catch (ListIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (EmptyListException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        // sheeba add
        public void Reverse()
        {
            Node prev = null;
            Node current = Head;
            Node next = null;

            Tail = Head; // Update Tail to the old Head

            while (current != null)
            {
                next = current.Next; // Store next node
                current.Next = prev; // Reverse the pointer
                prev = current;      // Move prev forward
                current = next;      // Move current forward
            }
            Head = prev; // Update Head to the new front
        }
    }
}


