﻿using FluentAssertions;

namespace LeetCode.Tests;

public class LeetCode75Tests
{
    readonly LeetCode75 _leetCode75 = new ();

    #region MergeAlternately

    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void MergeAlternately1(string word1, string word2, string expected)
    {
        // Act
        string actual = _leetCode75.MergeAlternately1(word1, word2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void MergeAlternately2(string word1, string word2, string expected)
    {
        // Act
        string actual = _leetCode75.MergeAlternately2(word1, word2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void MergeAlternately3(string word1, string word2, string expected)
    {
        // Act
        string actual = _leetCode75.MergeAlternately3(word1, word2);

        // Assert
        Assert.Equal(expected, actual);
    }

    #endregion MergeAlternately1

    #region Greatest Common Divisor of Strings

    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    public void GcdOfStrings(string str1, string str2, string expected)
    {
        // Act
        string actual = _leetCode75.GcdOfStrings(str1, str2);

        // Assert
        actual.Should().Be(expected);
    }

    #endregion Greatest Common Divisor of Strings

}