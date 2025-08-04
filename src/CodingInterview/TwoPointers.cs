using System;
using System.Linq;

namespace CodingInterview;

public static class TwoPointers
{
    public static bool TwoSuns(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var currentSum = numbers[left] + numbers[right];
            if (currentSum == target)
            {
                return true;
            }

            if (currentSum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return false;
    }

    public static int[] MoveZeroes(int[] numbers)
    {
        var nextNonZero = 0;
        for (var i = 0; i < numbers.Length; i += 1)
        {
            if (numbers[i] == 0)
            {
                continue;
            }

            (numbers[nextNonZero], numbers[i]) = (numbers[i], numbers[nextNonZero]);
            nextNonZero++;
        }

        return numbers;
    }
}