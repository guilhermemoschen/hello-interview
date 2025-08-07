using CodingInterview;
using Shouldly;

namespace UnitTests;

public class IntervalsTests
{
    public static readonly TheoryData<(int Start, int End)[], bool> CanAttendMeetingsCases = new()
    {
        {
            [(1, 5), (3, 9), (6, 8)],
            false
        },
        {
            [(10, 12), (6, 9), (13, 15)],
            true
        },
    };

    [Theory]
    [MemberData(nameof(CanAttendMeetingsCases))]
    public void CanAttendMeetings((int Start, int End)[] intervals, bool expected)
    {
        // Arrange
        // Act
        var result = Intervals.CanAttendMeetings(intervals);

        // Assert
        result.ShouldBe(expected);
    }
}