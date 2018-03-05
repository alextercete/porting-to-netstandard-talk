namespace PortingToNetStandard.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person(args[0], args[1]);
            var printer = new PersonPrinter(System.Console.Out);
            printer.Print(person);
        }
    }
}
