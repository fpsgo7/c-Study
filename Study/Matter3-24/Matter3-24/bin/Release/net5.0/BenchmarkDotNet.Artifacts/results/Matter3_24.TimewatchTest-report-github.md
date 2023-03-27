``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2


```
|                      Method |    Mean |    Error |   StdDev | Allocated |
|---------------------------- |--------:|---------:|---------:|----------:|
|        TimeWatchString10000 | 1.145 s | 0.0157 s | 0.0146 s | 630.28 KB |
| TimeWatchStringBuilder10000 | 1.161 s | 0.0229 s | 0.0377 s | 735.91 KB |
