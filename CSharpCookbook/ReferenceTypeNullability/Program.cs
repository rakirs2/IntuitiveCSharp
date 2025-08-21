static void SomeMethod(ref SomeClass? someClass)
{
    someClass = null;
}


static void SomeNullableMethod()
{
}

var thing = new SomeClass();


SomeMethod(ref thing);

Console.WriteLine(thing);

var thing2 = new SomeClass();

SomeNullableMethod();

Console.WriteLine(thing2);

class SomeClass
{
}

