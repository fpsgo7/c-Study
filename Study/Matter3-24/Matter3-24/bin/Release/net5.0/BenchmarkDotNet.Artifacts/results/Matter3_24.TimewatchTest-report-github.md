``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2


```
|                       Method |     Mean |     Error |    StdDev |     Gen0 |   Gen1 | Allocated |
|----------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
|         TimeWatchString10000 | 2.578 ms | 0.0143 ms | 0.0127 ms | 132.8125 |      - | 624.33 KB |
| TimeWatchStringBuilder10000A | 3.292 ms | 0.0553 ms | 0.0700 ms |  82.0313 | 3.9063 | 384.02 KB |
| TimeWatchStringBuilder10000B | 2.352 ms | 0.0039 ms | 0.0031 ms |  50.7813 |      - | 234.48 KB |
| TimeWatchStringBuilder10000C | 2.349 ms | 0.0220 ms | 0.0206 ms |  78.1250 | 7.8125 |  377.8 KB |
