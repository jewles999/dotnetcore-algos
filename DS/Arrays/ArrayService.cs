using System;
using System.Collections.Generic;

namespace DS{
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

    public int SmallestNotIn(int[] A)
    {
        /*Codility: class Solution { public int solution(int[] A); }
            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
            For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            Given A = [1, 2, 3], the function should return 4.
            Given A = [−1, −3], the function should return 1.
            Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
        */
        Array.Sort(A);  //this is N log N
        int res = -1;
        //difference between current number and next number that is not 
        //the same should be > 1
        for (int i = 0; i < A.Length; i++)
        {
            if ((i + 1) < A.Length && A[i] != A[i + 1])
            {
                int diff = A[i + 1] - A[i];
                if (diff > 1)
                {
                    res = A[i] + 1;
                }
            }
        }
        if (res < 0)
        {
            //not found
            if (A[A.Length - 1] < 0) res = 1;

        }
        return res < 0 ? A[A.Length - 1] + 1 : res;
    }

    public int SmallestNotIn(int[] A, bool on)
    {
        /*Codility: class Solution { public int solution(int[] A); }
        that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
        For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
        Given A = [1, 2, 3], the function should return 4.
        Given A = [−1, −3], the function should return 1.
        Write an efficient algorithm for the following assumptions:
        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [−1,000,000..1,000,000].*/
        //solve above problem but with O(n)
        var hashSet = new HashSet<int>();
        foreach(var a in A) hashSet.Add(a);

        for(int i = 1; i <= A.Length + 1; i++){
            if(!hashSet.Contains(i)) return i;
        }

        return -1;
    }
}
}