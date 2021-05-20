using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurant.Controllers
{
  public class DishesController : Controller
  {
    private readonly BestRestaurantContext _db;

    public DishesController(BestRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Restaurants = _db.Restaurants.ToList();
      List<Dish> model = _db.Dishes.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Dish dish)
    {
      _db.Dishes.Add(dish);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Dish thisDish = _db.Dishes.FirstOrDefault(dish => dish.DishId == id);
      return View(thisDish);
    }

    public ActionResult Edit(int id)
    {
      var thisDish = _db.Dishes.FirstOrDefault(dish => dish.DishId == id);
      ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View(thisDish);
    }

    [HttpPost]
    public ActionResult Edit(Dish dish)
    {
      _db.Entry(dish).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisDish = _db.Dishes.FirstOrDefault(dish => dish.DishId == id);
      return View(thisDish);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDish = _db.Dishes.FirstOrDefault(dish => dish.DishId == id);
      _db.Dishes.Remove(thisDish);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}