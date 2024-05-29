// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkSamples;

//BenchmarkRecord benchmarkRecord = new();
//benchmarkRecord.Run();

var summary = BenchmarkRunner.Run<BenchmarkLinqFirst>();
Console.WriteLine(summary);
