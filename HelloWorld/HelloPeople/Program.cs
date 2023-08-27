// create a new list of type string
// variable name names
// assign it default values
var names = new List<string>() { "Bin", "Srikar", "Dandre" };

// foreach
// for every value in names, take the value of "name" in order and run it through the loop
foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}");
}

