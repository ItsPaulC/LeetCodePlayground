using BenchmarkDotNet.Attributes;
using LeetCode;

[ShortRunJob]
[MemoryDiagnoser]
public class LeetCode75Benchamarks
{
    private LeetCode75 _leetCode75 = null!;
    private string _word1 = null!;
    private string _word2 = null!;

    [GlobalSetup]
    public void Setup()
    {
        _leetCode75 = new LeetCode75();
        _word1 = "abc";
        _word2 = "def";
    }

    [Benchmark]
    public string BenchmarkMergeAlternately1()
    {
        return _leetCode75.MergeAlternately1(_word1, _word2);
    }

    [Benchmark]
    public string BenchmarkMergeAlternately2()
    {
        return _leetCode75.MergeAlternately2(_word1, _word2);
    }

    [Benchmark]
    public string BenchmarkMergeAlternately3()
    {
        return _leetCode75.MergeAlternately3(_word1, _word2);
    }

    [Benchmark]
    public IList<bool> BenchmarkKidsWithCandies1()
    {
        return _leetCode75.KidsWithCandies1([2, 3, 5, 1, 3], 3);
    }
}