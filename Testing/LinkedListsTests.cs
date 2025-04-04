using Assignment3_LinkedList;
using NUnit.Framework;

namespace Testing;

public class LinkedListTests
{
    private LinkedListsADT linkedList;

    [SetUp]
    public void Setup()
    {
        // Create your concrete linked list class and assign to to linkedList.
        this.linkedList = new SLL();
    }

    [TearDown]
    public void TearDown()
    {
        this.linkedList.Clear();
    }

    //Test the linked list is empty.
    [Test]
    public void TestIsEmpty()
    {
        Assert.True(this.linkedList.IsEmpty());
        Assert.AreEqual(0, this.linkedList.Size());
    }

    //Tests appending elements to the linked list.
    [Test]
    public void TestAppendNode()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        /**
         * Linked list should now be:
         * 
         * a -> b -> c -> d
         */

        // Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());

        // Test the size is 4
        Assert.AreEqual(4, this.linkedList.Size());

        // Test the first node value is a
        Assert.AreEqual("a", this.linkedList.Retrieve(0));

        // Test the second node value is b
        Assert.AreEqual("b", this.linkedList.Retrieve(1));

        // Test the third node value is c
        Assert.AreEqual("c", this.linkedList.Retrieve(2));

        // Test the fourth node value is d
        Assert.AreEqual("d", this.linkedList.Retrieve(3));
    }

    //Tests prepending nodes to linked list.
    [Test]
    public void testPrependNodes()
    {
        this.linkedList.AddBeginning("a");
        this.linkedList.AddBeginning("b");
        this.linkedList.AddBeginning("c");
        this.linkedList.AddBeginning("d");

        /**
         * Linked list should now be:
         * 
         * d -> c -> b -> a
         */

        // Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());

        // Test the size is 4
        Assert.AreEqual(4, this.linkedList.Size());

        // Test the first node value is a
        Assert.AreEqual("d", this.linkedList.Retrieve(0));

        // Test the second node value is b
        Assert.AreEqual("c", this.linkedList.Retrieve(1));

        // Test the third node value is c
        Assert.AreEqual("b", this.linkedList.Retrieve(2));

        // Test the fourth node value is d
        Assert.AreEqual("a", this.linkedList.Retrieve(3));
    }

    //Tests inserting node at valid index.
    [Test]
    public void TestInsertNode()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        this.linkedList.InsertAt(2, "e");

        /**
         * Linked list should now be:
         * 
         * a -> b -> e -> c -> d
         */

        //Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());

        // Test the size is 4
        Assert.AreEqual(5, this.linkedList.Size());

        // Test the first node value is a
        Assert.AreEqual("a", this.linkedList.Retrieve(0));

        //// Test the second node value is b
        Assert.AreEqual("b", this.linkedList.Retrieve(1));

        // Test the third node value is e
        Assert.AreEqual("e", this.linkedList.Retrieve(2));

        // Test the third node value is c
        Assert.AreEqual("c", this.linkedList.Retrieve(3));

        // Test the fourth node value is d
        Assert.AreEqual("d", this.linkedList.Retrieve(4));
    }

    //Tests replacing existing nodes data.
    [Test]
    public void TestReplaceNode()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        this.linkedList.Replace("e", 2);

        /**
         * Linked list should now be:
         * 
         * a -> b -> e -> d
         */

        // Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());

        // Test the size is 4
        Assert.AreEqual(4, this.linkedList.Size());

        // Test the first node value is a
        Assert.AreEqual("a", this.linkedList.Retrieve(0));

        // Test the second node value is b
        Assert.AreEqual("b", this.linkedList.Retrieve(1));

        // Test the third node value is e
        Assert.AreEqual("e", this.linkedList.Retrieve(2));

        // Test the fourth node value is d
        Assert.AreEqual("d", this.linkedList.Retrieve(3));
    }

    // was mising added by sheeba
    [Test]
    public void TestRemoveStart()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");
        this.linkedList.RemoveStart();
        /**
         * Linked list should now be:
         * 
         * b -> c -> d
         */
        // Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());
        // Test the size is 3
        Assert.AreEqual(3, this.linkedList.Size());
        // Test the first node value is b
        Assert.AreEqual("b", this.linkedList.Retrieve(0));
        // Test the second node value is c
        Assert.AreEqual("c", this.linkedList.Retrieve(1));
        // Test the third node value is d
        Assert.AreEqual("d", this.linkedList.Retrieve(2));
    }
    // was missing added by sheeba 
    [Test]
    public void TestRemoveEnd()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");
        this.linkedList.RemoveEnd();
        /**
         * Linked list should now be:
         * 
         * a -> b -> c
         */
        // Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());
        // Test the size is 3
        Assert.AreEqual(3, this.linkedList.Size());
        // Test the first node value is a
        Assert.AreEqual("a", this.linkedList.Retrieve(0));
        // Test the second node value is b
        Assert.AreEqual("b", this.linkedList.Retrieve(1));
        // Test the third node value is c
        Assert.AreEqual("c", this.linkedList.Retrieve(2));
    }

    //Tests deleting node from linked list. An item is deleted from middle of list.
    [Test]
    public void TestDeleteNode()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        this.linkedList.Delete(2);

        /**
         * Linked list should now be:
         * 
         * a -> b -> d
         */

        // Test the linked list is not empty.
        Assert.False(this.linkedList.IsEmpty());

        // Test the size is 4
        Assert.AreEqual(4, this.linkedList.Size());

        // Test the first node value is a
        Assert.AreEqual("a", this.linkedList.Retrieve(0));

        // Test the second node value is b
        Assert.AreEqual("b", this.linkedList.Retrieve(1));

        // Test the fourth node value is d
        Assert.AreEqual("d", this.linkedList.Retrieve(2));
    }

    //Tests finding and retrieving node in linked list.
    [Test]
    public void TestFindNode()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        /**
         * Linked list should now be:
         * 
         * a -> b -> c -> d
         */

        bool contains = this.linkedList.Contains("b");
        Assert.True(contains);

        // Checks to see if index 1 is the same as the index of "b"
        int index = this.linkedList.IndexOf("b");
        Assert.AreEqual(1, index);

        // Checks to see if the value of index 1 is the same as the value of "b"
        string value = (string)this.linkedList.Retrieve(1);
        Assert.AreEqual("b", value);
    }

    [Test]
    public void TestGetIndex()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        // Check to see if list is empty
        Assert.False(this.linkedList.IsEmpty());

        // Test if IndexOf Works
        this.linkedList.IndexOf('a');
    }

    [Test]
    public void TestListHasItem()
    {
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        // Tests if linked list is not empty
        Assert.False(this.linkedList.IsEmpty());

        // Clears list if it has stuff
        this.linkedList.Clear();

        Assert.False(!this.linkedList.IsEmpty());
    }


    ////sheeba reverse
    [Test]
    public void TestReverse()
    {
        // Arrange: Create a linked list and add elements
        this.linkedList.AddEnd("a");
        this.linkedList.AddEnd("b");
        this.linkedList.AddEnd("c");
        this.linkedList.AddEnd("d");

        /**
         * Initial linked list:
         * a -> b -> c -> d
         */

        // Act: Reverse the linked list
        this.linkedList.Reverse();

        /**
         * Expected linked list after reversing:
         * d -> c -> b -> a
         */

        // Assert: Check if the list is still non-empty
        Assert.False(this.linkedList.IsEmpty());

        // Assert: Check if the size remains unchanged
        Assert.AreEqual(4, this.linkedList.Size());

        // Assert: Verify the reversed order
        Assert.AreEqual("d", this.linkedList.Retrieve(0)); // First node should now be 'd'
        Assert.AreEqual("c", this.linkedList.Retrieve(1)); // Second node should be 'c'
        Assert.AreEqual("b", this.linkedList.Retrieve(2)); // Third node should be 'b'
        Assert.AreEqual("a", this.linkedList.Retrieve(3)); // Fourth node should be 'a'
    }

    [Test]
    public void TestSortByName()
    {
        // Arrange: Create a linked list and add elements
        User user1 = new User(1, "Peter", "peter@gmail.com", "password");
        this.linkedList.AddEnd(user1);
        User user2 = new User(2, "Mary", "mary@gmail.com", "password");
        this.linkedList.AddEnd(user2);
        User user3 = new User(3, "Abby", "abby@gmail.com", "password");
        this.linkedList.AddEnd(user3);

        /**
         * Initial linked list:
         * Perter -> Mary -> Abby
         */

        // Act: Sort the linked list by Name
        this.linkedList.SortByName();

        /**
         * Expected linked list after sorting:
         * Abby -> Mary -> Peter
         */

        // Assert: Check if the list is still non - empty
        Assert.False(this.linkedList.IsEmpty());

        // Assert: Check if the size remains unchanged
        Assert.AreEqual(3, this.linkedList.Size());

        // Assert: Verify the reversed order
        Assert.AreEqual("Abby", this.linkedList.GetNameAt(0)); // First node should now be 'Abby'
        Assert.AreEqual("Mary", this.linkedList.GetNameAt(1)); // Second node should be 'Mary'
        Assert.AreEqual("Peter", this.linkedList.GetNameAt(2)); // Third node should be 'Peter'
    }


    [Test]
    public void TestGetNameAt()
    {
        // Arrange: Create a linked list and add elements
        User user1 = new User(1, "Peter", "peter@gmail.com", "password");
        this.linkedList.AddEnd(user1);
        User user2 = new User(2, "Mary", "mary@gmail.com", "password");
        this.linkedList.AddEnd(user2);
        User user3 = new User(3, "Abby", "abby@gmail.com", "password");
        this.linkedList.AddEnd(user3);

        /**
         * Initial linked list:
         * Perter -> Mary -> Abby
         */

        // Assert: Test if GetNameAt Works
        this.linkedList.GetNameAt(0);
        this.linkedList.GetNameAt(1);
        this.linkedList.GetNameAt(2);

        // Assert: Check to see if list is empty
        Assert.False(this.linkedList.IsEmpty());

        // Assert: Check if the size remains unchanged
        Assert.AreEqual(3, this.linkedList.Size());

        // Assert: Verify the GetNameAt method
        Assert.AreEqual("Peter", this.linkedList.GetNameAt(0)); // First node should now be 'Peter'
        Assert.AreEqual("Mary", this.linkedList.GetNameAt(1)); // Second node should be 'Mary'
        Assert.AreEqual("Abby", this.linkedList.GetNameAt(2)); // Third node should be 'Abby'
    }
}
