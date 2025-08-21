using CSharpCookBook.MoqTests;

var program = new MyProgram();

Console.WriteLine(program.Hello());

namespace CSharpCookBook.MoqTests
{
    public class MyProgram
    {

        public string Hello()
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

