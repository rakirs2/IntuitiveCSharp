// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool? something;

something = null;
if (something.HasValue)
{
    Console.WriteLine("Can we get here");
}