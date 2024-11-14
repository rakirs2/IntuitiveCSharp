using CSharpCookBook.MoqTests;

var program = new MyProgram();

Console.WriteLine(program.Hello("name"));

namespace CSharpCookBook.MoqTests
{
    public class MyProgram
    {

        public string Hello(string name)
        {
            string lastName = GetLastName();

            return string.Format("hello {0}", lastName);
        }

        public virtual string GetLastName()
        {
            return "xxx";
        }
    }
}

