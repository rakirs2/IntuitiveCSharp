static void SomeMethod(ref SomeClass someClass)
{
    someClass = null;
}


static void SomeNullableMethod(SomeClass? someClass)
{
    someClass = null;
}

var thing = new SomeClass();


SomeMethod(ref thing);

Console.WriteLine(thing);

var thing2 = new SomeClass();

SomeNullableMethod(thing2);

Console.WriteLine(thing2);

class SomeClass{
}

