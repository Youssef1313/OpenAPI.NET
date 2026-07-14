```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3
  ShortRun : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | Mean           | Error         | StdDev       | Gen0       | Gen1       | Gen2      | Allocated    |
|------------- |---------------:|--------------:|-------------:|-----------:|-----------:|----------:|-------------:|
| PetStoreYaml |       491.4 μs |      73.39 μs |      4.02 μs |    15.6250 |          - |         - |    313.49 KB |
| PetStoreJson |       200.1 μs |      21.63 μs |      1.19 μs |     9.7656 |     1.9531 |         - |    175.35 KB |
| GHESYaml     |   950,426.0 μs | 464,029.55 μs | 25,435.03 μs | 18000.0000 | 17000.0000 | 3000.0000 | 254631.61 KB |
| GHESJson     |   275,862.0 μs |  85,329.99 μs |  4,677.22 μs |  6000.0000 |  5000.0000 | 1000.0000 | 111800.16 KB |
| GHESNextYaml | 1,122,298.9 μs |  42,624.26 μs |  2,336.38 μs | 30000.0000 | 18000.0000 | 3000.0000 | 450734.59 KB |
| GHESNextJson |   565,764.5 μs | 112,806.34 μs |  6,183.30 μs | 20000.0000 | 10000.0000 | 2000.0000 | 312494.39 KB |
