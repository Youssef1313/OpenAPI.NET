```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
13th Gen Intel Core i7-13800H 2.90GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3
  ShortRun : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | Mean         | Error           | StdDev       | Gen0       | Gen1       | Gen2      | Allocated    |
|------------- |-------------:|----------------:|-------------:|-----------:|-----------:|----------:|-------------:|
| PetStoreYaml |     247.3 μs |        51.94 μs |      2.85 μs |    25.3906 |     5.8594 |         - |    314.57 KB |
| PetStoreJson |     100.1 μs |        58.29 μs |      3.20 μs |    14.1602 |     4.3945 |         - |    176.71 KB |
| GHESYaml     | 564,400.6 μs |    83,066.13 μs |  4,553.14 μs | 23000.0000 | 15000.0000 | 3000.0000 | 256736.07 KB |
| GHESJson     | 221,686.5 μs |   166,335.47 μs |  9,117.41 μs |  9000.0000 |  8000.0000 | 2000.0000 | 113905.62 KB |
| GHESNextYaml | 760,454.1 μs |   289,817.12 μs | 15,885.85 μs | 40000.0000 | 17000.0000 | 4000.0000 | 452771.45 KB |
| GHESNextJson | 693,815.3 μs | 1,252,956.17 μs | 68,678.76 μs | 26000.0000 |  9000.0000 | 2000.0000 | 314531.37 KB |
