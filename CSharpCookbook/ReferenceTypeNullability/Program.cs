static void SomeMethod(ref SomeClass someClass)
{
    someClass = null;
}

var thing = new SomeClass();


SomeMethod(ref thing);

Console.WriteLine(thing);

class SomeClass{
}

