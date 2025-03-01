// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Random random = new Random();
// int32.max is less than what I'm going for here;
int totalNumbers = 1000000;

long runningTotal = 0;
long output = 0;
var allValues = new int[totalNumbers];
for (int i = 0; i < totalNumbers; i++)
{
    var number = random.Next(0, 100);
    allValues[i]= number;
    runningTotal += number;
}

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
