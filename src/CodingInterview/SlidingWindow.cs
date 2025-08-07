using System;
using System.Collections.Generic;

namespace CodingInterview;

public static class SlidingWindow
{
    public static int FruitIntoBaskets(int[] fruits)
    {
        var start = 0;
        var end = 0;
        var maximumOfFruits = 0;
        Dictionary<int, int> state = new();

        while (end < fruits.Length)
        {
            if (state.ContainsKey(fruits[end]))
            {
                state[fruits[end]] += 1;
                end += 1;
            }
            else if (state.Count < 2)
            {
                state[fruits[end]] = 1;
                end += 1;
            }
            else
            {
                state[fruits[start]] -= 1;
                if (state[fruits[start]] == 0)
                {
                    state.Remove(fruits[start]);
                    state[fruits[end]] = 1;
                    end += 1;
                }

                start += 1;
            }

            maximumOfFruits = Math.Max(maximumOfFruits, end - start + 1);
        }

        return maximumOfFruits;
    }

    /// <summary>
    /// Write a function to return the length of the longest substring in a provided string s where all characters in the substring are distinct.
    /// </summary>
    public static int LongestSubstringWithoutRepeatingCharacters(string s)
    {
        var start = 0;
        var end = 0;
        var longestSubstring = 0;
        Dictionary<char, int> state = new();

        while (end < s.Length)
        {
            if (state.ContainsKey(s[end]))
            {
                while (s[start] != s[end])
                {
                    state.Remove(s[start]);
                    start += 1;
                }

                start += 1;
            }
            else
            {
                state[s[end]] = 1;
            }

            end += 1;

            longestSubstring = Math.Max(longestSubstring, end - start);
        }

        return longestSubstring;
    }
}