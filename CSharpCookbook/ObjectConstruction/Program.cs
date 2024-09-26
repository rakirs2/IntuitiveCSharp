using System;

SomeObject obj = new();
var someObject2 = (SomeObject)obj.Clone();

public class SomeObject : ICloneable
{
    public SomeObject()
    {
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}