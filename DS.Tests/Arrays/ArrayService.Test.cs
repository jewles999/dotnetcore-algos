using System;
using System.Linq;
using Xunit;
using DS;

namespace DS.Tests
{
    public class ArrayServiceTest
    {
        [Fact]
        public void MaxSumShouldReturn_CorrectValue()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int maxNum = 3;

            ArrayService ars = new ArrayService();
            int maxSum = ars.MaxSubarraySum(arr, maxNum);

            Assert.Equal(12, maxSum);
        }

        [Fact]
        public void SmallestNotExisting_InArray()
        {
            int[] arr = new int[] { 1, 3, 6, 4, 1, 2 };
            ArrayService ars = new ArrayService();
            int sm = ars.SmallestNotIn(arr);

            Assert.Equal(5, sm);
        }

        [Fact]
        public void SmallestNotExisting_NotInArray()
        {
            int[] arr = new int[] { 1, 2, 3 };
            ArrayService ars = new ArrayService();
            int sm = ars.SmallestNotIn(arr);

            Assert.Equal(4, sm);
        }
    }

}