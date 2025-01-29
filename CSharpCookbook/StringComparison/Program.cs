﻿// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;

var lowerCase = "hello world";
var upperCase = "HELLO WORLD";
var initial = "isAutoGenerated";
var inProd = "isAutogenerated";

Console.WriteLine(lowerCase.Equals(upperCase, StringComparison.Ordinal));
Assert.IsTrue(lowerCase.Equals(upperCase, StringComparison.OrdinalIgnoreCase));
Assert.IsFalse(lowerCase.Equals(upperCase, StringComparison.Ordinal));
Assert.IsTrue(initial.Equals(inProd, StringComparison.OrdinalIgnoreCase));

HashSet<string> stringHashset = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
{
    "isAutoGenerated",
};

Assert.IsTrue(stringHashset.Contains(inProd));