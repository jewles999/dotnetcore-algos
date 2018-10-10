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
    }

}