using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAlbumsAndTracks();
        }

        private static void CreateAlbumsAndTracks()

        {
            var albums = new Album[]
            {
                new Album()
                {
                    AlbumId = 13,
                    AlbumName = "Life is Peachy",
                    Artist = "KoRn"
                },
                new Album()
                {
                    AlbumId = 1,
                    AlbumName = "Thriller",
                    Artist = "Micheal Jackson"
                }
            };
            var tracks = new Track[]
            {
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Twist",
                    Duration = new TimeSpan(0,0,49)
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Chi",
                    Duration = TimeSpan.ParseExact("03:54", @"mm\:ss", CultureInfo.InvariantCulture)
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Lost",
                    Duration = TimeSpan.Parse("0:2:55")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Swallow",
                    Duration = TimeSpan.Parse("0:3:38")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Porno Creep",
                    Duration=TimeSpan.Parse("0:2:01")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Good God",
                    Duration = TimeSpan.Parse("0:3:20")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Mr. Rogers",
                    Duration = TimeSpan.Parse("0:5:10")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "K@#Ø%!",
                    Duration = TimeSpan.Parse("0:3:02")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "No Place to Hide",
                    Duration = TimeSpan.Parse("0:3:31")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Wicked",
                    Duration = TimeSpan.Parse("0:3:58")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "A.D.I.D.A.S.",
                    Duration = TimeSpan.Parse("0:2:32")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Lowrider",
                    Duration = TimeSpan.Parse("0:0:58")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Ass Itch",
                    Duration = TimeSpan.Parse("0:3:39")
                },
                 new Track()
                {
                    AlbumId = 13,
                    TrackName = "Kill You",
                    Duration = TimeSpan.Parse("0:8:37")
                },
                 new Track()
                {
                    AlbumId = 1,
                    TrackName = "Wanna Be Startin’ Somethin’",
                    Duration = new TimeSpan(0,6,4)
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Baby Be Mine",
                    Duration = TimeSpan.ParseExact("04:21", @"mm\:ss", CultureInfo.InvariantCulture)
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "The Girl Is Mine",
                    Duration = TimeSpan.Parse("0:3:43")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Thriller",
                    Duration = TimeSpan.Parse("0:5:58")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Beat It",
                    Duration=TimeSpan.Parse("0:4:18")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Billie Jean",
                    Duration = TimeSpan.Parse("0:4:54")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Human Nature",
                    Duration = TimeSpan.Parse("0:4:07")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "P.Y.T. (Pretty Young Thing)",
                    Duration = TimeSpan.Parse("0:3:58")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "The Lady in My Life",
                    Duration = TimeSpan.Parse("0:4:59")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Someone in the Dark",
                    Duration = TimeSpan.Parse("0:2:18")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Billie Jean (Home Demo)",
                    Duration = TimeSpan.Parse("0:4:48")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Voice over Session from Thriller",
                    Duration = TimeSpan.Parse("0:2:04")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Carousel",
                    Duration = TimeSpan.Parse("0:2:20")
                }
            };


        }
    }
    internal class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
    }

    internal class Track
    {
        public int AlbumId { get; set; }
        public string TrackName { get; set; }
        public TimeSpan Duration { get; set; }
    }


}
    


