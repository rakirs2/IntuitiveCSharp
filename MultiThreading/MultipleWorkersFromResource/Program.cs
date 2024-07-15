using System.Collections.Concurrent;
using System.Diagnostics;

var numbers = new ConcurrentQueue<long>();

for (long i = 0; i < 1000000000; i++)
{
    if (i % 1000000 == 0)
    {
        Console.WriteLine(i);
    }
    
    numbers.Enqueue(i);
}

Console.WriteLine("Finished queuing");

long output = 0;

Action addEmUp = () =>
{
    long localSum = 0;
    long localValue;
    Thread.Sleep(5);
    while (numbers.TryDequeue(out localValue)) localSum += localValue;
    Interlocked.Add(ref output, localSum);
} ;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Parallel.Invoke(addEmUp);
stopWatch.Stop();
// 29029 with 1 worker
// 77458 with 2 workers
// 

Console.WriteLine($"output: {output}, time: {stopWatch.ElapsedMilliseconds}");