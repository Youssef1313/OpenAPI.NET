```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
13th Gen Intel Core i7-13800H 2.90GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.301
  [Host]   : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3
  ShortRun : .NET 8.0.28 (8.0.28, 8.0.2826.26413), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Mean       | Error      | StdDev    | Gen0   | Allocated |
|---------------------------- |-----------:|-----------:|----------:|-------:|----------:|
| EmptyApiCallback            |   2.016 ns |  1.6110 ns | 0.0883 ns | 0.0025 |      32 B |
| EmptyApiComponents          |   4.183 ns |  9.1579 ns | 0.5020 ns | 0.0089 |     112 B |
| EmptyApiContact             |   2.791 ns |  4.7484 ns | 0.2603 ns | 0.0038 |      48 B |
| EmptyApiDiscriminator       |   2.346 ns |  1.1071 ns | 0.0607 ns | 0.0038 |      48 B |
| EmptyDocument               | 270.408 ns | 26.9028 ns | 1.4746 ns | 0.0911 |    1144 B |
| EmptyApiEncoding            |   3.026 ns |  2.4771 ns | 0.1358 ns | 0.0064 |      80 B |
| EmptyApiExample             |   3.072 ns |  0.6297 ns | 0.0345 ns | 0.0057 |      72 B |
| EmptyApiExternalDocs        |   2.335 ns |  0.4284 ns | 0.0235 ns | 0.0032 |      40 B |
| EmptyApiHeader              |   3.005 ns |  0.8443 ns | 0.0463 ns | 0.0064 |      80 B |
| EmptyApiInfo                |   2.918 ns |  1.6427 ns | 0.0900 ns | 0.0064 |      80 B |
| EmptyApiLicense             |   2.334 ns |  1.6677 ns | 0.0914 ns | 0.0038 |      48 B |
| EmptyApiLink                |   2.810 ns |  1.7468 ns | 0.0957 ns | 0.0057 |      72 B |
| EmptyApiMediaType           |   2.963 ns |  0.6735 ns | 0.0369 ns | 0.0064 |      80 B |
| EmptyApiOAuthFlow           |   2.688 ns |  0.9967 ns | 0.0546 ns | 0.0051 |      64 B |
| EmptyApiOAuthFlows          |   2.784 ns |  1.1457 ns | 0.0628 ns | 0.0051 |      64 B |
| EmptyApiOperation           |  37.361 ns | 22.7124 ns | 1.2449 ns | 0.0299 |     376 B |
| EmptyApiParameter           |   3.278 ns |  0.6752 ns | 0.0370 ns | 0.0077 |      96 B |
| EmptyApiPathItem            |   2.945 ns |  1.8221 ns | 0.0999 ns | 0.0051 |      64 B |
| EmptyApiPaths               |  54.316 ns | 12.6654 ns | 0.6942 ns | 0.0197 |     248 B |
| EmptyApiRequestBody         |   4.537 ns |  6.9345 ns | 0.3801 ns | 0.0038 |      48 B |
| EmptyApiResponse            |   5.012 ns | 19.7693 ns | 1.0836 ns | 0.0051 |      64 B |
| EmptyApiResponses           |  63.468 ns | 86.7506 ns | 4.7551 ns | 0.0197 |     248 B |
| EmptyApiSchema              |  25.155 ns | 10.1148 ns | 0.5544 ns | 0.0408 |     512 B |
| EmptyApiSecurityRequirement |  12.169 ns |  4.3886 ns | 0.2406 ns | 0.0083 |     104 B |
| EmptyApiSecurityScheme      |   7.607 ns |  4.7213 ns | 0.2588 ns | 0.0083 |     104 B |
| EmptyApiServer              |   5.248 ns |  1.2812 ns | 0.0702 ns | 0.0045 |      56 B |
| EmptyApiServerVariable      |   4.777 ns |  8.8010 ns | 0.4824 ns | 0.0038 |      48 B |
| EmptyApiTag                 |   6.922 ns | 12.6527 ns | 0.6935 ns | 0.0057 |      72 B |
