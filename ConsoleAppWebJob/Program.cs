using static System.Console;
using static System.Threading.Thread;

namespace ConsoleAppWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Main executed");

            long i = 0;
            while (true)
            {
                WriteLine($"While loop at {++i} pass");
                Sleep(1000);
            }
        }
    }
}
