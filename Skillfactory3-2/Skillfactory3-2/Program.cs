namespace Skillfactory3_2
{
    internal class Program
    {
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");
            Console.WriteLine($"Red is {(int)Semaphore.Red}");
            Console.WriteLine($"Yellow is {((int)Semaphore.Yellow)}");
            Console.WriteLine($"Green is {((int)Semaphore.Green)}");
        }
    }
}