``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT AVX2


```
|                Method |           Mean |       Error |      StdDev | Allocated |
|---------------------- |---------------:|------------:|------------:|----------:|
|     SequentialSearch0 |      0.5289 ns |   0.0120 ns |   0.0094 ns |         - |
|  SequentialSearch1000 |    548.7115 ns |   0.2208 ns |   0.1724 ns |         - |
|  SequentialSearch5000 |  2,717.5652 ns |   2.6482 ns |   2.2114 ns |         - |
| SequentialSearch10000 |  5,459.4976 ns |  33.3293 ns |  31.1762 ns |         - |
| SequentialSearch20000 | 10,865.2203 ns |  27.8851 ns |  23.2854 ns |         - |
| SequentialSearch30000 | 16,526.5568 ns | 270.9489 ns | 253.4457 ns |         - |
| SequentialSearch40000 | 22,289.7858 ns | 378.7475 ns | 335.7498 ns |         - |
| SequentialSearch50000 | 27,922.5070 ns | 552.7004 ns | 614.3251 ns |         - |
| SequentialSearch60000 |      0.2694 ns |   0.0173 ns |   0.0162 ns |         - |
|         BinarySearch0 |     17.0473 ns |   0.2487 ns |   0.2327 ns |         - |
|      BinarySearch1000 |     16.7222 ns |   0.0942 ns |   0.0881 ns |         - |
|      BinarySearch5000 |     16.1982 ns |   0.0410 ns |   0.0342 ns |         - |
|     BinarySearch10000 |     17.8529 ns |   0.3738 ns |   0.3999 ns |         - |
|     BinarySearch20000 |     17.6555 ns |   0.0332 ns |   0.0310 ns |         - |
|     BinarySearch30000 |     14.8910 ns |   0.0619 ns |   0.0549 ns |         - |
|     BinarySearch40000 |     18.0951 ns |   0.0457 ns |   0.0382 ns |         - |
|     BinarySearch50000 |     16.9258 ns |   0.1315 ns |   0.1230 ns |         - |
|     BinarySearch60000 |      0.2600 ns |   0.0042 ns |   0.0039 ns |         - |
