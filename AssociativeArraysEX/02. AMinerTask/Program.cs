using System;

namespace _02._AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQuantity = new();

            string resource = Console.ReadLine();
            
            // until we receive input "stop" we will loop and check if in the dictionary said resource exists and add it to the dictionary with its quantity. if it already exists we add to the already existing resource with the already existing resource
            while(resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourceQuantity.ContainsKey(resource))
                {
                    resourceQuantity.Add(resource, quantity);
                }
                else 
                {
                    resourceQuantity[resource] += quantity;
                }
                resource = Console.ReadLine();
            }

            foreach(var kvp in resourceQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
