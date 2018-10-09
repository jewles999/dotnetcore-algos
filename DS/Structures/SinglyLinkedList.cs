using System;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

public class SinglyLinkedList
{
    private Node first;
    private Node head;

    public bool IsEmpty()
    {
        return head == null;
    }

    public void Push(int val)
    {
        var n = new Node { Value = val, Next = null };
        if (head == null) head = n;
        else
        {
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = n;
        }
    }

    public void DisplayList()
    {
        Node current = head;
        while (current != null)
        {
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

}