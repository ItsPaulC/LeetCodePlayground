using System;
using System.Text;

namespace LeetCode;

public class LeetCode75
{
    /// <summary>
    /// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns>The merged string</returns>
    public string MergeAlternately1(string word1, string word2) {
        var sb = new StringBuilder();
        int i = 0, j = 0;

        while(i < word1.Length || j < word2.Length)
        {
            if(i < word1.Length)
            {
                sb.Append(word1[i]);
                i++;
            }

            if(j <word2.Length)
            {
                sb.Append(word2[j]);
                j++;
            }
        }

        return sb.ToString();
    }

    public string MergeAlternately2(string word1, string word2) {
        var sb = new StringBuilder();
        int maxLength = Math.Max(word1.Length, word2.Length);

        for (int i = 0; i < maxLength; i++) {
            if (i < word1.Length) {
                sb.Append(word1[i]);
            }
            if (i < word2.Length) {
                sb.Append(word2[i]);
            }
        }

        return sb.ToString();
    }

    public string MergeAlternately3(string word1, string word2) {
        int maxLength = Math.Max(word1.Length, word2.Length);
        Span<char> result = stackalloc char[word1.Length + word2.Length];
        int index = 0;

        for (int i = 0; i < maxLength; i++) {
            if (i < word1.Length) {
                result[index++] = word1[i];
            }
            if (i < word2.Length) {
                result[index++] = word2[i];
            }
        }

        return new string(result.Slice(0, index));
    }
}