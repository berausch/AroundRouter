using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AroundRouter.Models;
using Microsoft.EntityFrameworkCore;


namespace AroundRouter.Controllers
{
    public class LocationsController : Controller
    {

        private AroundRouterContext db = new AroundRouterContext();

        public IActionResult Index()
        {
            return View(db.Locations.Include(locations => locations.Route).ToList());
        }

        public IActionResult Details(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.LocationId == id);
            return View(thisLocation);
          
        }
        public IActionResult Create()
        {
            ViewBag.RouteId = new SelectList(db.Routes, "RouteId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");       
        }

        public IActionResult Edit(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.LocationId == id);
            ViewBag.RouteId = new SelectList(db.Routes, "RouteId", "Name");
            return View(thisLocation);
        }

        [HttpPost]
        public IActionResult Edit(Location location)
        {
            db.Entry(location).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.LocationId == id);
            return View(thisLocation);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.LocationId == id);
            db.Locations.Remove(thisLocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
