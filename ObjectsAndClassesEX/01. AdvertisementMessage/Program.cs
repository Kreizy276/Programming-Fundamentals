using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _01._AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Phrase myPhrase = new();
            Event myEvent = new();
            Author myAuthor = new();
            City myCity = new();

            GetSentence(myPhrase, myEvent, myAuthor, myCity, n);
        }
        
        static void GetSentence(Phrase myPhrase, Event myEvent, Author myAuthor, City myCity, int n)
        {
            Random random = new();

            for(int i = 1 ; i <= n ; i++)
            {
                string phrase = myPhrase.Phrases[random.Next(myPhrase.Phrases.Count)];
                string eventDesc = myEvent.Events[random.Next(myEvent.Events.Count)];
                string author = myAuthor.Authors[random.Next(myAuthor.Authors.Count)];
                string city = myCity.Cities[random.Next(myCity.Cities.Count)];

                Console.WriteLine($"{phrase} {eventDesc} {author} - {city}.");
            }
        }
    }

    class Phrase
    {
        public List<string> Phrases = new()
        { 
            "Excellent product.",          
            "Such a great product.",          
            "I always use that product.",          
            "Best product of its category.",          
            "Exceptional product.",         
            "I can't live without this product." 
        };
    }

    class Event
    {
        public List<string> Events = new()
        {
            "Now I feel good.", 
            "I have succeeded with this product.", 
            "Makes miracles. I am happy of the results!", 
            "I cannot believe but now I feel awesome.", 
            "Try it yourself, I am very satisfied.", 
            "I feel great!"
        };
        
    }

    class Author
    {
        public List<string> Authors = new()
        {
            "Diana", 
            "Petya", 
            "Stella", 
            "Elena", 
            "Katya", 
            "Iva", 
            "Annie",
            "Eva"
        };
    }

    class City
    {
        public List<string> Cities = new()
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };
    }
}
