using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A plain lady");
            Console.WriteLine("Walked in to a plain grocery store");
            Console.WriteLine("With a plain dress");
            Console.WriteLine("Walking around the store to pick out her favorite items");
            Console.WriteLine("She notice a girl with beautiful eyes");
            Console.WriteLine("Where had she seen those beautiful eyes before,");
            Console.WriteLine("she wondered...");
            Console.WriteLine("on her way back to the car she sees the girl with beautiful eyes");
            Console.WriteLine("walking to her car");
            Console.WriteLine("Look at all of those grocieres she thinks to her self");
            Console.WriteLine("Those are so many groceries...");
            Console.WriteLine("She screamed out");
            Console.WriteLine("Oh Dear, would you like some help with your groceries?");
            string response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Whats your Name?");
            }
            
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.WriteLine("I have never met you before.");
            Console.WriteLine("This is such a small town.");
            Console.WriteLine("People never come to visit,");
            Console.WriteLine("Where are you from?");

            string home = Console.ReadLine();

            Console.WriteLine("HHHmmmmm, I went to " + home + " once");
            Console.WriteLine("a long long time ago");
            Console.WriteLine("I remember there was beautiful live music,);
            Console.WriteLine("and even more hansome men!");
            Console.WriteLine("I would love to grab coffee with you some time?");
            Console.ReadLine();
            if



        }
    }
}
