using System;
using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var songs = GetModelOfSong();
            ViewBag.MainTitle = "Mi cancion preferida";
            return View(songs);
        }

        private SongModel GetModelOfSong()
        {
            var song = new SongModel
            {
                Id = 1,
                Name = "Perdido",
                Genre = "Pop",
                Artist = "Nicki Nicole",
                Album = "Parte de mi",
                ReleasedDate = new DateTime(2021, 10, 28)
            };
            return song;
        }


    }
}
