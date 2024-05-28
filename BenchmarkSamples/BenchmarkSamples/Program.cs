// See https://aka.ms/new-console-template for more information

using BenchmarkSamples;

BenchmarkRecord benchmarkRecord = new();
benchmarkRecord.Run();

BenchmarkLinqFirst benchmarkLinqFirst = new();
benchmarkLinqFirst.Run();

Console.WriteLine("Hello, World!");
