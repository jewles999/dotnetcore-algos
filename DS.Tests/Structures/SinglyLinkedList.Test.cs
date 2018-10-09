using System;
using System.Linq;
using Xunit;
using DS;

namespace DS.Tests
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void Three_Nodes_Should_Return_Length_Of_3()
        {
            var l = new SinglyLinkedList();
            l.Push(1);
            l.Push(2);
            l.Push(3);

            var result = l.GetListLength();

            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void AfterNodeInsert_Count_Should_Match(int nodeNumber)
        {
            var l = new SinglyLinkedList();

            for (int i = 0; i < nodeNumber; i++)
            {
                l.Push(i);
            }
            l.DisplayList();

            var count = l.GetListLength();

            Assert.Equal(nodeNumber, count);
        }

        [Fact]
        public void Odd_MiddleNodeShould_Return_Correctly()
        {
            var l = new SinglyLinkedList();
            //[1,2,3,4,5] - should return first middle per leetcode
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 1; i <= arr.Length; i++)
            {
                l.Push(i);
                l.DisplayList();
            }

            var middle = l.MiddleNode(l.GetHead());

            Assert.Equal(3, middle.Value);
        }

        [Fact]
        public void Even_MiddleNodeShould_Return_Correctly()
        {
            var l = new SinglyLinkedList();
            //[1,2,3,4,5,6] - should return second middle per leetcode
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 1; i <= arr.Length; i++)
            {
                l.Push(i);
                l.DisplayList();
            }

            var middle = l.MiddleNode(l.GetHead());

            Assert.Equal(4, middle.Value);
        }
    }
}