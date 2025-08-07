using CodingInterview;
using Shouldly;

namespace UnitTests;

public class SlidingWindowTests
{
    public static readonly TheoryData<int[], int> ContainerWithMostWaterCases = new()
    {
        {
            [3, 3, 2, 1, 2, 1, 0],
            4
        },
    };

    [Theory]
    [MemberData(nameof(ContainerWithMostWaterCases))]
    public void ContainerWithMostWater(int[] lines, int expected)
    {
        // Arrange
        // Act
        var result = SlidingWindow.FruitIntoBaskets(lines);

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [InlineData("eghghhgg", 3)]
    [InlineData("substring", 8)]
    public void LongestSubstringWithoutRepeatingCharacters(string s, int expected)
    {
        // Arrange
        // Act
        var result = SlidingWindow.LongestSubstringWithoutRepeatingCharacters(s);

        // Assert
        result.ShouldBe(expected);
    }
}