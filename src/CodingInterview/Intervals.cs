using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview;

public static class Intervals
{
    /// <summary>
    /// Write a function to check if a person can attend all the meetings scheduled without any time conflicts.
    /// Given an array intervals, where each element [s1, e1] represents a meeting starting at time s1 and ending at time e1,
    /// determine if there are any overlapping meetings. If there is no overlap between any meetings, return true; otherwise, return false.
    /// Note that meetings ending and starting at the same time, such as (0,5) and (5,10), do not conflict.
    /// </summary>
    public static bool CanAttendMeetings((int Start, int End)[] intervals)
    {
        var sortedIntervals = intervals.OrderBy(x => x.Start).ToArray();

        var end = sortedIntervals[0].End;

        for (var i = 1; i < sortedIntervals.Length; i++)
        {
            if (end > sortedIntervals[i].Start)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Given a list of intervals and an interval newInterval, write a function to insert newInterval into a list of existing,
    /// non-overlapping, and sorted intervals based on their starting points. The function should ensure that after the new interval is added,
    /// the list remains sorted without any overlapping intervals, merging them if needed.
    /// </summary>
    public static (int Start, int End)[] InsertInterval((int Start, int End)[] intervals, (int Start, int End) newInterval)
    {
        List<(int Start, int End)> merged = [];
        var i = 0;

        for (; i < intervals.Length && intervals[i].End < newInterval.Start; i++)
        {
            merged.Add(intervals[i]);
        }

        for (; i < intervals.Length && intervals[i].Start <= newInterval.End; i += 1)
        {
            newInterval.Start = Math.Min(intervals[i].Start, newInterval.Start);
            newInterval.End = Math.Max(intervals[i].End, newInterval.End);
        }

        merged.Add(newInterval);

        for (; i < intervals.Length; i++)
        {
            merged.Add(intervals[i]);
        }

        return merged.ToArray();
    }
}