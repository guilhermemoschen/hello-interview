using System;

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

    public static int[] SortColors(int[] numbers)
    {
        var nextRed = 0;
        var nextWhite = 0;

        for (var i = 0; i < numbers.Length; i += 1)
        {
            if (numbers[i] == 0)
            {
                (numbers[nextRed], numbers[i]) = (numbers[i], numbers[nextRed]);
                nextRed += 1;
            }

            if (numbers[i] == 1)
            {
                (numbers[nextWhite], numbers[i]) = (numbers[i], numbers[nextWhite]);
                nextWhite += 1;
            }
        }

        return numbers;
    }

    public static int ContainerWithMostWater(int[] lines)
    {
        var left = 0;
        var right = lines.Length - 1;
        var biggestArea = 0;

        while (left < right)
        {
            var width = right - left;
            var height = Math.Min(lines[left], lines[right]);
            var currentArea = width * height;
            biggestArea = Math.Max(biggestArea, currentArea);

            if (lines[left] < lines[right])
            {
                left += 1;
            }
            else
            {
                right -= 1;
            }
        }

        return biggestArea;
    }
}