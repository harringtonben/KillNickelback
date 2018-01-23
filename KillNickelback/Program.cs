using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<string>();
            var allSongs = new HashSet<Song>();

            allSongs.Add(new Song { Artist = "Nickelback", Name = "Photograph" });
            allSongs.Add(new Song { Artist = "Tom Petty", Name = "Free Fallin'" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "How You Remind Me" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "Someday" });
            allSongs.Add(new Song { Artist = "Bruce Springsteen", Name = "Born To Run" });
            allSongs.Add(new Song { Artist = "Graham Nash", Name = "Military Madness" });
            allSongs.Add(new Song { Artist = "Neil Young", Name = "Heart of Gold" });

        }
    }
}
