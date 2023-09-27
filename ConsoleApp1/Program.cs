using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej sean, Hej Jing, Hej Niklas");
            Console.WriteLine("Are you a friend of mine? y or n");
            string friend=Console.ReadLine();
            Console.WriteLine("Whats your name?");
            string name=Console.ReadLine();
            if(friend == "y")
            {
                Console.WriteLine("tönt");
            }
            Console.WriteLine("Hej Jonny");
            Console.WriteLine("Jag är inte en tönt >:C");
            Console.WriteLine($"Hej {name}");
        }
        
    }
}