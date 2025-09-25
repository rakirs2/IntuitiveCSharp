
using Microsoft.SqlServer.TransactSql.ScriptDom;

public class SelectStatementVisitor : TSqlFragmentVisitor
{
    public List<SelectStatement> SelectStatements { get; } = new List<SelectStatement>();

    public override void Visit(SelectStatement node)
    {
        SelectStatements.Add(node);
        base.Visit(node); // Continue visiting child nodes
    }
}

class Program
{
    static void Main()
    {
        string sqlScript = "SELECT * FROM Employees; SELECT Name FROM Departments;";
        TSql150Parser parser = new(false);
        IList<ParseError> errors;

        using (StringReader reader = new(sqlScript))
        {
            TSqlFragment fragment = parser.Parse(reader, out errors);

            if (errors.Count > 0)
            {
                Console.WriteLine("Errors in SQL script:");
                foreach (var error in errors)
                {
                    Console.WriteLine(error.Message);
                }
                return;
            }

            // Use the custom visitor
            SelectStatementVisitor visitor = new();
            fragment.Accept(visitor);

            Console.WriteLine("Found SELECT statements:");
            foreach (var select in visitor.SelectStatements)
            {
                Console.WriteLine(select.ToString());
            }
        }
    }
}