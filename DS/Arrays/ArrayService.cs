public class ArrayService
{
    public int MaxSubarraySum(int[] arr, int maxNum)
    {
        /*
            given an array [1,2,3,4] and max int calculate largest consecutive sum of maxNum integers
            using slding window approach O(n)
        */
        if (arr.Length < maxNum) return 0;
        int maxSum, tempSum = 0;
        //calculate the sum of first maxNum numbers
        for (int i = 0; i < maxNum; i++)
        {
            tempSum += arr[i];
        }

        maxSum = tempSum;

        for (int i = maxNum; i < arr.Length; i++)
        {
            tempSum += arr[i] - arr[i - maxNum];

            if (tempSum > maxSum) maxSum = tempSum;
        }
        return maxSum;
    }
}
