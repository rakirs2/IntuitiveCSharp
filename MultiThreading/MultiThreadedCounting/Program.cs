// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using MultiThreadedCounting;

Random random = new Random();
// int32.max is less than what I'm going for here;
int totalNumbers = 1000000000;
var allValues = NumberGeneration.GenerateIntegerArray(lowerBound: 0, upperBound: 5, count: totalNumbers, out long runningTotal);
int output = 0;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
foreach (var value in allValues)
{
    output += value;
}
stopwatch.Stop();

Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedTicks}, totalExpected: {runningTotal}, actual: {output}");

// Apparently there's a LINQ for this
stopwatch.Restart();
int totalOfArrayLinq = allValues
    .AsParallel()  // comment this out if you want sequential version
    .Sum();
stopwatch.Stop();
Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedTicks}, totalExpected: {runningTotal}, actual: {totalOfArrayLinq}");

// So this is actually less performant?
// OK, so it depends on size. What if we really max it out?