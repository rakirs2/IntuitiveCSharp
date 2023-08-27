var numbers = new List<int>() { 1, 2, 3 };

var sum = 0;
foreach (var number in numbers)
{
    sum += number;
}
Console.WriteLine(sum);

Console.WriteLine(numbers.Sum());

sum = 0;
for (int i = 0; i < numbers.Count; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);
int j = 0;
sum = 0;
while (j < numbers.Count)
{
    sum += numbers[j];
    j++;
}

Console.WriteLine(sum);