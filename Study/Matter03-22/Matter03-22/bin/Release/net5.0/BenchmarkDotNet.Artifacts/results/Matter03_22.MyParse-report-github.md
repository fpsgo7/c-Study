``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.400
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT AVX2


```
|       Method |     Mean |     Error |    StdDev | Allocated |
|------------- |---------:|----------:|----------:|----------:|
| MyParseStart | 2.204 ns | 0.0255 ns | 0.0239 ns |         - |
