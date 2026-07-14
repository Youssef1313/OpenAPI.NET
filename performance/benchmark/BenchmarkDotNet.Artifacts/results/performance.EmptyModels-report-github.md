```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3
  ShortRun : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Mean         | Error     | StdDev    | Gen0   | Allocated |
|---------------------------- |-------------:|----------:|----------:|-------:|----------:|
| EmptyApiCallback            |    17.678 ns | 13.077 ns | 0.7168 ns | 0.0019 |      32 B |
| EmptyApiComponents          |    11.304 ns | 13.155 ns | 0.7210 ns | 0.0067 |     112 B |
| EmptyApiContact             |    10.270 ns | 10.446 ns | 0.5726 ns | 0.0029 |      48 B |
| EmptyApiDiscriminator       |    15.856 ns |  8.317 ns | 0.4559 ns | 0.0029 |      48 B |
| EmptyDocument               | 1,223.217 ns | 11.843 ns | 0.6492 ns | 0.0668 |    1144 B |
| EmptyApiEncoding            |    12.311 ns |  8.307 ns | 0.4553 ns | 0.0048 |      80 B |
| EmptyApiExample             |    14.048 ns | 24.010 ns | 1.3160 ns | 0.0043 |      72 B |
| EmptyApiExternalDocs        |    10.245 ns |  7.940 ns | 0.4352 ns | 0.0024 |      40 B |
| EmptyApiHeader              |    10.560 ns | 19.134 ns | 1.0488 ns | 0.0048 |      80 B |
| EmptyApiInfo                |     8.466 ns |  1.395 ns | 0.0765 ns | 0.0048 |      80 B |
| EmptyApiLicense             |    16.528 ns | 11.501 ns | 0.6304 ns | 0.0029 |      48 B |
| EmptyApiLink                |     8.783 ns |  8.998 ns | 0.4932 ns | 0.0043 |      72 B |
| EmptyApiMediaType           |    13.536 ns | 13.134 ns | 0.7199 ns | 0.0048 |      80 B |
| EmptyApiOAuthFlow           |     8.344 ns |  4.089 ns | 0.2241 ns | 0.0038 |      64 B |
| EmptyApiOAuthFlows          |     7.705 ns |  1.329 ns | 0.0728 ns | 0.0038 |      64 B |
| EmptyApiOperation           |    78.306 ns |  4.707 ns | 0.2580 ns | 0.0224 |     376 B |
| EmptyApiParameter           |     9.789 ns |  7.225 ns | 0.3960 ns | 0.0057 |      96 B |
| EmptyApiPathItem            |     9.913 ns |  6.928 ns | 0.3797 ns | 0.0038 |      64 B |
| EmptyApiPaths               |    64.056 ns | 48.743 ns | 2.6718 ns | 0.0148 |     248 B |
| EmptyApiRequestBody         |    14.059 ns | 30.973 ns | 1.6978 ns | 0.0029 |      48 B |
| EmptyApiResponse            |    13.767 ns | 12.257 ns | 0.6718 ns | 0.0038 |      64 B |
| EmptyApiResponses           |    63.003 ns | 19.710 ns | 1.0804 ns | 0.0148 |     248 B |
| EmptyApiSchema              |    22.044 ns |  7.546 ns | 0.4136 ns | 0.0306 |     512 B |
| EmptyApiSecurityRequirement |    16.620 ns | 11.602 ns | 0.6359 ns | 0.0062 |     104 B |
| EmptyApiSecurityScheme      |    11.630 ns | 11.449 ns | 0.6276 ns | 0.0062 |     104 B |
| EmptyApiServer              |    10.503 ns |  9.372 ns | 0.5137 ns | 0.0033 |      56 B |
| EmptyApiServerVariable      |    14.193 ns |  8.986 ns | 0.4926 ns | 0.0029 |      48 B |
| EmptyApiTag                 |     9.851 ns |  2.196 ns | 0.1204 ns | 0.0043 |      72 B |
