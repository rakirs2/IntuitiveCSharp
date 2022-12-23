# Strings

## What is a string?

> “It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of light, it was the season of darkness, it was the spring of hope, it was the winter of despair.”

This is the opening to a tale of two cities, arguably the best opening of any book ever. That's really not that important. Here, what I want to focus on is the way we capture "a block of text" that we are saying has a given value.

So in this case, there are two quotes at the beginning and the end of the "string of characters." 

In English, if we use quotes, we are generally marking that "someone is saying something." To a computer, the same quotes mean that "the contents between the quotes are the value we want"

### Hello World

Your very first program, as is tradition, was to print hello world. 

We are using Top level statements so all you had to write was 

```C#
Console.WriteLine("Hello World");
```

So here we are calling a function and telling it to "print" the value of whatever is inside of the '()' to the console.

In this case, that value is a string with the value of Hello World.

## What can we do with this?

Strings by themselves are quite powerful. We can actually make fully functional apps that are, at the end of the day, just strings. If you are old enough to know what AOL was, you'll know that social media/texting etc. all started with string communication.

## Assignment to a variable

```C#
String a = "apple";
Console.WriteLine(a);
```

The output of this will be apple as we have use the assignment operator =  to set the value of type string with the name "a" to apple.

Then when we call Console.WriteLine(a);, we are saying print the value of a to the consolue which, in this case is apple.

## Reading in external strings to a variable

```C#
String a = Console.ReadLine();
Console.WriteLine(a);
```

This is the classic "echo" program. it will return whatever the user types in.


## HW

### Project 1
Create a program that communicates with a user. It should ask the user their name, birthday, favorite animal and then print out some summarizing statement that looks something like 
```
What's your name? Name
What's your birthday? __/__/__
What's your favorite animal? donkey

Hello Name, it's nice to meet you. Your birthday is __/__/__ Wow, mine too. Your favorite animal is a donkey, so is mine. What can I say, we're both asinine.
```
It should work for any input and must query the user with questions. So 

