int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
    83, 23, 87, 435, 67, 12, 19 };

int first = numbers.First(number => number > 80);
int fail = numbers.FirstOrDefault(number => number > 1000, 300);
Console.WriteLine(first);
Console.WriteLine(fail);