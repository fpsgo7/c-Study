``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.400
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT AVX2


```
|        Method |      Mean |     Error |    StdDev | Allocated |
|-------------- |----------:|----------:|----------:|----------:|
|  MyParseStart |  3.260 ns | 0.0789 ns | 0.1181 ns |         - |
| TryParseStart |  9.461 ns | 0.2107 ns | 0.1971 ns |         - |
|    ParseStart | 10.311 ns | 0.0558 ns | 0.0466 ns |         - |
