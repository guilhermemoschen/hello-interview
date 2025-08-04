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
}