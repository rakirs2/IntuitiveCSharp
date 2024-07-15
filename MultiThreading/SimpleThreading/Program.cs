using System.Collections.Concurrent;

ConcurrentQueue<int> numbers = new ConcurrentQueue<int>();

for (var i = 0; i < 10000; i++)
{
    numbers.Enqueue(i);
}

