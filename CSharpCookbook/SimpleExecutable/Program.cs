// See https://aka.ms/new-console-template for more information

using SimpleExecutable;

Console.WriteLine("Hello, World!");
Console.WriteLine("Creating a dummy class");

var dummyClass = new DummyClass();
if (dummyClass is not null)
{
    Console.WriteLine("Dummy class created successfully.");
}
else
{
    Console.WriteLine("Failed to create dummy class.");
}