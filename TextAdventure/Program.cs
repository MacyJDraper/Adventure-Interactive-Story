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
            Console.WriteLine("Look at all of those groceries she thinks to her self");
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
            Console.WriteLine("I remember there was beautiful live music,");
            Console.WriteLine("and even more beautiful men!");
            Console.WriteLine("I would love to grab coffee with you some time?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Great we will meet tomorrow at ten");
            }
            else
            {
                Console.WriteLine("Are you sure, I would really love getting to know you");
            }
            string answer1 = Console.ReadLine();
            if (answer1 == "yes")
            {
                Console.WriteLine("Great we will meet tomorrow at ten"); 
            }
            Console.WriteLine("The very next day the plain women was waiting");
            Console.WriteLine("to meet " + name + " at the coffee shop.");
            Console.WriteLine("For some reason she was so intrigued by this beautiful girl.");
            Console.WriteLine("She grabbed them two coffees as she waited on " + name);
            Console.WriteLine(name + " finally walked in");
            Console.WriteLine("Hey " + name + " come sit over here.");
            Console.WriteLine("They started to talk about life in " + home + " the music, the culture and the history");
            Console.WriteLine("How old are you the plain women asked?");
            string age = Console.ReadLine();
            Console.WriteLine("Wooowww the last time I visited " + home + " was " + age + " years ago!");
            Console.WriteLine("It's a very sad story i don't normally talk about,");
            Console.WriteLine("but if you would like to hear it I will tell you?");

            string hearStory = Console.ReadLine();
            if ( hearStory == "yes")
            {
                Console.WriteLine(age + " years ago i visited " + home + " and met a very beautiful man,");
                Console.WriteLine("with very beautiful eyes.");
                Console.WriteLine("Actually they were very similar to yours.");
                Console.WriteLine("His name was Rafale.");
            }
            Console.WriteLine("Wooww thats my fathers name said " + name);
            Console.WriteLine("Thats interesting said the plain lady");
            Console.WriteLine("We met one summer night.");
            Console.WriteLine("He told me about his lavished life");
            Console.WriteLine("I was so intrigued....");
            Console.WriteLine("We drank, we danced we laughed, we spent all night together");
            Console.WriteLine("9 months later I had a beautiful girl");
            Console.WriteLine("At that time I was only 18 years old");
            Console.WriteLine("with no job no money and no way to support her");
            Console.WriteLine("I made the decision to leave her with her father");
            Console.WriteLine("I had no business raising a child");
            Console.WriteLine("When I was still a child myself");
            Console.WriteLine("I never spoke to him again but i still think about");
            Console.WriteLine("The beautiful girl I gave up every day.");
            
        }
    }
}
