// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkSamples;


//BenchmarkRunner.Run<BenchmarkTwoSum>();
//BenchmarkRunner.Run<BenchmarkTwoSumLarge>();
//BenchmarkRunner.Run<BenchmarkSbVsConcat>();
BenchmarkRunner.Run<BenchmarkAllocations>();