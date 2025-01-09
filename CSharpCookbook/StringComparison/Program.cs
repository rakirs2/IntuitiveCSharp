// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;

var lowerCase = "hello world";
var upperCase = "HELLO WORLD";
Console.WriteLine(lowerCase.Equals(upperCase, StringComparison.Ordinal));
Assert.IsTrue(lowerCase.Equals(upperCase, StringComparison.OrdinalIgnoreCase));
Assert.IsFalse(lowerCase.Equals(upperCase, StringComparison.Ordinal));