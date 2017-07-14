using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a List, named goodSongs, that will hold tuples consisting of two strings.
            List <(string, string)> goodSongs = new List<(string, string)>();

            // Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
            HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>()
            {
                ("Prince", "Red Corvette"), ("Elvis", "Love me Tender"), ("NickelBack", "star"), ("NickelBack", "Figured You Out"),
                ("Creed", "Ow, My butt hurts"), ("Sonic Youth", "Dirty Boots"), ("Tom Waits", "Going Out West")
            };

            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback"

            foreach ((string artist, string song) item in allSongs)
            {
                // Console.WriteLine($"These be some songs and stuff by {item.artist} : {item.song}");
                if(item.artist != "NickelBack" & item.artist != "Creed") {
                    goodSongs.Add(item);
                    Console.WriteLine($"{item.artist} : {item.song} nice music man");
                }else{
                    Console.WriteLine("Eww, go away");
                }
            }

            foreach ((string, string) item in goodSongs)
            {
                Console.WriteLine($"Your music {item}");
            }

        }
    }
}
