using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_LinkedLists
{
    public interface LinkedListADT
    {
        /// <summary>
        /// Prepends (adds to beginning) data to the list.
        /// </summary>
        /// <param name="data">Data to store inside element.</param>
        void AddBeginning(Object data);

        /// <summary>
        /// Adds to the end of the list.
        /// </summary>
        /// <param name="data">Data to append.</param>
        void AddEnd(Object data);

        /// <summary>
        /// Remove an item at an index in the linked list.
        /// </summary>
        /// <param name="index">Position of the removed item</param>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        /// <exception cref="EmptyListException">Thrown if trying to remove a value in an empty list.</exception>
        void RemoveAt(int index);

        /// <summary>
        /// Remove an item from the start of the linked list.
        /// </summary>
        void RemoveStart();

        /// <summary>
        /// Remove an item from the end of the linked list.
        /// </summary>
        void RemoveEnd();

        /// <summary>
        /// Adds a new element at a specific position.
        /// </summary>
        /// <param name="data">Data that element is to contain.</param>
        /// <param name="index">Index to add new element at.</param>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if index is negative or past the size of the list.</exception>
        void InsertAt(int index, Object data);


        /// <summary>
        /// Checks if the list is empty.
        /// </summary>
        /// <returns>True if it is empty.</returns>
        bool IsEmpty();

        ///<summary>Clears the list.</summary>
        void Clear();

        /// <summary>
        /// Replaces the data at index.
        /// </summary>
        /// <param name="data">Data to replace.</param>
        /// <param name="index">Index of element to replace.</param>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        /// <exception cref="EmptyListException">Thrown if trying to replace a value in an empty list.</exception>
        void Replace(Object data, int index);

        /// <summary>
        /// Gets the number of elements in the list.
        /// </summary>
        /// <returns>Size of list (0 meaning empty).</returns>
        int Size();

        /// <summary>
        /// Removes element at index from list, reducing the size.
        /// </summary>
        /// <param name="index">Index of element to remove.</param>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if index is negative or past the size - 1.</exception>
        /// <exception cref="EmptyListException">Thrown if trying to delete a value in an empty list.</exception>
        void Delete(int index);

        /// <summary>
        /// Gets the data at the specified index.
        /// </summary>
        /// <param name="index">Index of element to get.</param>
        /// <returns> Data in element or null if it was not found.</returns>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of the list.</exception>
        /// <exception cref="EmptyListException">Thrown if trying to retrieve a value from an empty list.</exception>
        Object Retrieve(int index);

        /// <summary>
        /// Gets the first index of element containing data.
        /// </summary>
        /// <param name="data">Data object to find the first index of.</param>
        /// <returns>First of index of element with matching data or -1 if not found.</returns>
        int IndexOf(Object data);

        /// <summary>
        /// Goes through elements and check if we have one with data.
        /// </summary>
        /// <param name="data">Data object to search for.</param>
        /// <returns>True if element exists with value.</returns>
        bool Contains(Object data);
        /// <summary>
        /// Prints all of the items inside the linked list.
        /// </summary>
        void PrintList();
        /// <summary>
        /// Gets the node and its data in the head of the linked list.
        /// </summary>
        Node GetHead();
        /// <summary>
        /// Gets the node and its data in the tail of the linked list.
        /// </summary>
        Node GetTail();
        /// <summary>
        /// Combination of printing the list, and getting the values in the head and tail of the linked list.
        /// </summary>
        void PrintData();
        /// <summary>
        /// Checks if the list is empty.
        /// </summary>
        /// <returns>False if it is not null and True if it is empty.</returns>
        bool CheckListNull();
        /// <summary>
        /// Used when a list is empty to restore its head node.
        /// </summary>
        /// <param name="data">Data for the head.</param>
        /// <returns>False if neither of the head and tail is null and True when a new head node has been created. </returns>
        bool FixListNull(object data);
        /// <summary>
        /// Used to join two or more lists.
        /// </summary>
        /// <param name="appendList">The list to append.</param>
        /// <exception cref="EmptyListException">Thrown if trying to append to an empty/non-existent list.</exception>
        void JoinList(SLL appendList);
        /// <summary>
        /// Sort the nodes in the linked list into ascending order based on the names of the users.
        /// </summary>
        void SortByName();
        /// <summary>
        /// Get the name of the specify users in the linked list by getting the position of users. 
        /// </summary>
        /// <param name="index">The position of users in the linked list</param>
        /// <exception cref="ListIndexOutOfRangeException">Thrown if index is negative or larger than or equal to size of the list.</exception>
        /// <exception cref="EmptyListException">Thrown if the list size is empty.</exception>
        string GetNameAt(int index);

    }
}
