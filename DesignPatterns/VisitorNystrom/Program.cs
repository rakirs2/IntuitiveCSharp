Console.WriteLine("Hello, World!");

var b = new Beignet();
var c = new Cruller();
var visitor = new PastryDisplayVisitor();
b.Accept(visitor);
c.Accept(visitor);

public abstract class Pastry
{
    public abstract void Accept(PastryVisitor visitor);
}

public class Beignet : Pastry
{
    public override void Accept(PastryVisitor visitor)
    {
        Console.WriteLine("visiting beignet");
        visitor.VisitBeignet(this);
    }
}

public class Cruller : Pastry
{
    public override void Accept(PastryVisitor visitor)
    {
        Console.WriteLine("visiting cruller");
        visitor.VisitCruller(this);
    }
}

public interface PastryVisitor
{
    void VisitBeignet(Beignet beignet);
    void VisitCruller(Cruller cruller);
}


public class PastryDisplayVisitor : PastryVisitor
{
    public void VisitBeignet(Beignet beignet)
    {
        Console.WriteLine("Displaying a Beignet.");
    }

    public void VisitCruller(Cruller cruller)
    {
        Console.WriteLine("Displaying a Cruller.");
    }
}

// See https://aka.ms/new-console-template for more information


