// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkSamples;

//BenchmarkRunner.Run<BenchmarkLinqFirst>();
//BenchmarkRunner.Run<BenchmarkRecord>();

BenchmarkRunner.Run<BenchmarkDictionaries>();
