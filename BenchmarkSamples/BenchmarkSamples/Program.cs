// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkSamples;

//BenchmarkRecord benchmarkRecord = new();
//benchmarkRecord.Run();

//BenchmarkRunner.Run<BenchmarkLinqFirst>();
BenchmarkRunner.Run<BenchmarkRecord>();
