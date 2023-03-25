``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2


```
|                Method |           Mean |      Error |     StdDev | Allocated |
|---------------------- |---------------:|-----------:|-----------:|----------:|
|     SequentialSearch0 |      0.5200 ns |  0.0045 ns |  0.0035 ns |         - |
|  SequentialSearch1000 |    538.0838 ns |  0.9343 ns |  0.8282 ns |         - |
|  SequentialSearch5000 |  2,659.4518 ns |  4.8621 ns |  4.3102 ns |         - |
| SequentialSearch10000 |  5,317.6078 ns |  4.3263 ns |  3.6126 ns |         - |
| SequentialSearch20000 | 10,619.1245 ns | 16.9004 ns | 14.9818 ns |         - |
| SequentialSearch30000 | 15,913.4705 ns | 19.4233 ns | 17.2183 ns |         - |
| SequentialSearch40000 | 21,254.5803 ns | 42.7362 ns | 37.8845 ns |         - |
| SequentialSearch50000 | 26,568.2509 ns | 54.1313 ns | 50.6345 ns |         - |
|         BinarySearch0 |     16.4451 ns |  0.0175 ns |  0.0164 ns |         - |
|      BinarySearch1000 |     16.3082 ns |  0.0201 ns |  0.0168 ns |         - |
|      BinarySearch5000 |     15.8653 ns |  0.0401 ns |  0.0355 ns |         - |
|     BinarySearch10000 |     17.1317 ns |  0.0288 ns |  0.0255 ns |         - |
|     BinarySearch20000 |     17.4925 ns |  0.2006 ns |  0.1778 ns |         - |
|     BinarySearch30000 |     14.5544 ns |  0.0661 ns |  0.0586 ns |         - |
|     BinarySearch40000 |     17.7270 ns |  0.0443 ns |  0.0414 ns |         - |
|     BinarySearch50000 |     16.5218 ns |  0.0169 ns |  0.0150 ns |         - |
