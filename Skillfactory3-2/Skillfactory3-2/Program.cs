namespace Skillfactory3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = checked((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine($"Your name is {name} and age is {age}");
            Console.Write("Enter your birthdate: ");
            var birthdate = DateTime.Parse(Console.ReadLine()).ToString("dd.MM.yyyy");
            Console.WriteLine($"Your birthdate is {birthdate}");
            Console.ReadKey();
        }
    }
}