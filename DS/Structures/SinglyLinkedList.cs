using System;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

public class SinglyLinkedList
{
    private Node head;

    public bool IsEmpty()
    {
        return head == null;
    }

    public Node Push(int val)
    {
        var n = new Node { Value = val, Next = null };
        var current = head;

        if (head == null) head = n;
        else
        {
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = n;
        }
        return current;
    }

    public void DisplayList()
    {
        System.Console.WriteLine("Displaying List");
        Node current = head;
        while (current != null)
        {
            System.Console.WriteLine($"Value: {current.Value}, Next: {current.Next}");
            current = current.Next;
        }
    }

    public void DisplayList(Node n)
    {
        System.Console.WriteLine("Displaying List");
        Node current = n;
        while (current != null)
        {
            System.Console.WriteLine($"Value: {current.Value}, Next: {current.Next}");
            current = current.Next;
        }
    }

    public Node GetHead()
    {
        return this.head;
    }
    public int GetListLength()
    {
        int count = 0;
        Node n = this.head;
        while (n != null)
        {
            count++;
            n = n.Next;
        }
        return count;
    }

    //Leetcode Middle of the Linked List
    public Node MiddleNode(Node head)
    {
        var length = GetListLength();
        var middleIndex = length % 2 == 0 ? length / 2 + 1 : Math.Ceiling((double)length / 2);

        var currentNode = head;
        Node middleNode = null;
        int counter = 1;

        while (middleNode == null)
        {
            if (counter == middleIndex)
            {
                middleNode = currentNode;
                break;
            }

            currentNode = currentNode.Next;
            counter++;
        }
        return middleNode;
    }
    /*Leetcode Reverse list 
        Input: 1->2->3->4->5->NULL
        Output: 5->4->3->2->1->NULL
    */
    public Node ReverseList(Node head)
    {
        /*
            1. Create prev, current, and next
            2. Start loop from head
            3. Store next in current
            4. Assign current.next to prev
            5. Advance one node: prev = current, current = next
         */
        if (head == null || head.Next == null) return head;

        Node prev = null;
        var current = head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

}