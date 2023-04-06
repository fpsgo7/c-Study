``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2


```
|               Method |        Mean |     Error |    StdDev | Allocated |
|--------------------- |------------:|----------:|----------:|----------:|
|   SequentialSearch10 |   5.9077 ns | 0.0459 ns | 0.0430 ns |         - |
| SequentialSearch1000 | 541.6304 ns | 4.0965 ns | 3.6314 ns |         - |
|       BinarySearch10 |   0.7746 ns | 0.0299 ns | 0.0279 ns |         - |
|    BinarySearch10000 |   0.7725 ns | 0.0064 ns | 0.0060 ns |         - |
