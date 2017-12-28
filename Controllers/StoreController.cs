using MVC_MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities dbContext;
        
        // GET: Store
        public ActionResult Index()
        {
            //List<Genre> genre = new List<Genre>();
            //genre.Add(new Genre { Name = "Jazz" });
            //genre.Add(new Genre { Name = "Disco" });
            //genre.Add(new Genre { Name = "Rock" });
            //genre.Add(new Genre { Name = "Pop" });
            dbContext = new MusicStoreEntities();
            var genre = dbContext.Genres.ToList();
            return View(genre);
        }
        public ActionResult Details(int Id)
        {
            dbContext = new MusicStoreEntities();

            var album = dbContext.Genres.Include("Albums").ToList();
            return View(album);
        }
        public ActionResult Edit(string id)
        {
            return View("Details", new Album() { Title="F"});
        }
        public ActionResult Browse(string genre)
        {
            var Genre = new Genre { Name = "Genre " + genre };
            return View(Genre);
        }
    }
}