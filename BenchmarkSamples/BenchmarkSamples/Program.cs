// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkSamples;


BenchmarkRunner.Run<BenchmarkSbVsConcat>();
//BenchmarkRunner.Run<BenchmarkTwoSum>();
//BenchmarkRunner.Run<BenchmarkTwoSumLarge>();
//BenchmarkRunner.Run<BenchmarkAllocations>();

