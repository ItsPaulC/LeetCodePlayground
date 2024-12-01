using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace LeetCode.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Summary summary = BenchmarkRunner.Run<LeetCode75Benchamarks>();
        }
    }
}