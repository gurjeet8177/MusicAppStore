using MusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //craete alidt of genres using the genreal model
            var genres = new List<Genre>();
            for(int i=1; i < 11; i++)
            {
                genres.Add(new Genre { Name="Genre"+i.ToString()});


            }
            //pass genres to int the view bag
           
            return View(genres);
        }
        //GET: Store page
        public ActionResult Details(String genre)
        {
            if (genre == null) {
                return View("Error");
                //return View("Index");
               // return RedirectToAction("Contact","Home");
                //you should call the controler method instead of callin the view 
            }
            ViewBag.Genre = genre;
            var albums = new List<Album>();

            for(int i = 0; i < 4; i++)
            {
                albums.Add(new Album { Title = "Album" + i.ToString(), AlbumArtUrl = "/Content/Images/placeholder.gif" , Price=8.99});

            }
            return View(albums);
        }
    }
}