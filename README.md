# Introduction
I created this repository to try out BenchmarkDotnet. I compared System.Text.Serialization vs Newtonsoft.

# How to
- Add BenchmarkDotnet package to your solution.
- Add *[Benchmark]* attribute to your methods that you want to bechmark
- Run bechmark in Program. `NewtonsoftVsSystemText` is your class containing `Benchmark` methods.
`BenchmarkRunner.Run<NewtonsoftVsSystemText>();`
- Run your console application in Release mode
`dotnet run -c Release`

# Result
The result of the comparison is as below.

|                  Method |     Mean |     Error |    StdDev |
|------------------------ |---------:|----------:|----------:|
|     NewtonSerialization | 6.833 us | 0.0554 us | 0.0463 us |
| SystemTextSerialization | 3.249 us | 0.0280 us | 0.0248 us |

System.Text.Serialization performs almost two times better than Newtonsoft.Json.

# Conclusion
BenchmarkDotnet is a simple package for making benchmarks.
