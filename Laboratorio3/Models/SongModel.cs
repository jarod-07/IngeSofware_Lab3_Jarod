﻿namespace Laboratorio3.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
}
