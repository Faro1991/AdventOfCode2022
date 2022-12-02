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