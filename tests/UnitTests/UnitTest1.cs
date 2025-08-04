using System.Diagnostics.CodeAnalysis;
using CodingInterview;
using Shouldly;

namespace UnitTests;

public class UnitTest1
{
    public static readonly TheoryData<int[], int, bool> TwoSunsCases = new()
    {
        {
            [1, 3, 4, 6, 8, 10, 13],
            13,
            true
        },
        {
            [1, 3, 4, 6, 8, 10, 13],
            15,
            false
        },
    };

    [Theory]
    [MemberData(nameof(TwoSunsCases))]
    public void TwoSuns_SeveralCases(int[] numbers, int target, bool expected)
    {
        // Arrange
        // Act
        var result = TwoPointers.TwoSuns(numbers, target);

        // Assert
        result.ShouldBe(expected);
    }
}