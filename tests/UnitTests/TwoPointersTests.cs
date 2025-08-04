using CodingInterview;
using Shouldly;

namespace UnitTests;

public class TwoPointersTests
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

    public static readonly TheoryData<int[], int[]> MoveZeroesCases = new()
    {
        {
            [2, 3, 4, 0, 9],
            [2, 3, 4, 9, 0]
        },
        {
            [2, 0, 4, 0, 9],
            [2, 4, 9, 0, 0]
        },
    };

    [Theory]
    [MemberData(nameof(MoveZeroesCases))]
    public void MoveZeroes(int[] numbers, int[] expected)
    {
        // Arrange
        // Act
        var result = TwoPointers.MoveZeroes(numbers);

        // Assert
        result.ShouldBeEquivalentTo(expected);
    }
}