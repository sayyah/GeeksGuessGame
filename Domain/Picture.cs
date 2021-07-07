using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Picture
    {
        public Picture( int id, Race.RaceType race, string path, int height=125, int width=90)
        {
            Path = path;
            Height = height;
            Width = width;
            Id = id;
            Race = race;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public string Path { get; set; }
        public int Id { get; set; }
        public Race.RaceType Race { get; set; }

    }
}
