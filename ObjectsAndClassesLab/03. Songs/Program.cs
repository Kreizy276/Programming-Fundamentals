using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new();
            int numberOfSongs = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                Song song = new()
                {
                    TypeList = data[0],
                    Name = data[1],
                    Time = data[2]
                };
                list.Add(song);
            }
            string typeList = Console.ReadLine();

            switch(typeList)
            {
                case "all":
                    foreach(Song song in list)
                    {
                        Console.WriteLine(song.Name);
                    }
                    break;
                default:
                    foreach(Song song in list)
                    {
                        if(song.TypeList == typeList)
                        {
                            Console.WriteLine(song.Name);
                        }
                    }
                    break;
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
