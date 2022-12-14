# Advent of Code 2022

    A  D  V  E  N  T    O  F    C  O  D  E    '2  2
       *        *        *        __o    *       *
    *      *       *        *    /_| _     *
       K  *     K      *        O'_)/ \  *    *
      <')____  <')____    __*   V   \  ) __  *
       \ ___ )--\ ___ )--( (    (___|__)/ /*     *
     *  |   |    |   |  * \ \____| |___/ /  *
        |*  |    |   | aos \____________/       *       
(art shamelessly stolen from [www.asciiart.eu](https://www.asciiart.eu/holiday-and-events/christmas/santa-claus))

Hi everyone and welcome to this year's [Advent of Code](https://adventofcode.com). This is where I'll be keeping track of my progress, trying new things and maybe learning a thing or two.

## Goals

This year's objectives are (as of Nov 21st, 2022):

* Try my hand at writing tests (and maybe even Test Driven Development, if I can find the time).
* Maybe branching languages a bit. So far I've attempted AoC with C#, maybe I'll add other languages into the mix this time around, let's see.
* Learning some of the features recently introduced in C# 11/.NET 7
* (Optional:) Implement a "framework" I can use in future AoC's to achieve my goals faster.

## Results

### Remarks

I am fully aware that a benchmark like this is in itself useless in terms of information, as my code might perform differently on your machine, even my machine under a different OS or base load. This is just my personal "how much time would this realistically be wasting/how does it scale when run multiple times?" fun metric. I also have to cut some corners in implementations as e.g. BenchmarkDotNet seems to run through IEnumerable inputs starting with an empty input. Therefore, runs might be measured than they actually are faster as I'll essentially be skipping the entire algorithm if certain conditions aren't met.

### Relevant execution parameters (as far as BenchmarkDotNet is concerned)
```
BenchmarkDotNet=v0.13.2, OS=manjaro 
AMD FX(tm)-8300, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.109
  [Host] : .NET 6.0.9 (6.0.922.46401), X64 RyuJIT AVX DEBUG  [AttachedDebugger]
```

### Day 1

|  Method |     Mean |   Error |  StdDev |
|-------- |---------:|--------:|--------:|
| PartOne | 132.0 us | 2.39 us | 2.94 us |
| PartTwo | 137.1 us | 2.72 us | 6.36 us |

### Day 2

|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
| PartOne | 1.185 ms | 0.0232 ms | 0.0423 ms |
| PartTwo | 1.156 ms | 0.0231 ms | 0.0487 ms |

### Day 3

|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
| PartOne | 1.315 ms | 0.0101 ms | 0.0089 ms |
| PartTwo | 1.446 ms | 0.0086 ms | 0.0076 ms |

### Day 4

|  Method |     Mean |    Error |   StdDev |
|-------- |---------:|---------:|---------:|
| PartOne | 965.2 us | 18.71 us | 27.43 us |
| PartTwo | 978.4 us | 19.43 us | 23.13 us |

### Day 5

|  Method |     Mean |   Error |  StdDev |
|-------- |---------:|--------:|--------:|
| PartOne | 678.1 us | 1.73 us | 1.62 us |
| PartTwo | 839.6 us | 4.44 us | 3.71 us |

### Day 6

|  Method |       Mean |    Error |   StdDev |
|-------- |-----------:|---------:|---------:|
| PartOne |   634.6 us |  1.25 us |  0.97 us |
| PartTwo | 5,191.0 us | 29.21 us | 25.89 us |

### Day 7

|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
| PartOne | 1.059 ms | 0.0135 ms | 0.0119 ms |
| PartTwo | 1.053 ms | 0.0031 ms | 0.0026 ms |