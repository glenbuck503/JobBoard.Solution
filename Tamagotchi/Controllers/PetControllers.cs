using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {

    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> allPets = Pet.GetAll();
      return View(allPets);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/pets/{id}")]
    public ActionResult Show(int Id)
    {

      Pet foundPet = Pet.Find(Id);
      return View(foundPet);
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name, int food, int attention, int rest)
    {
      Pet myPet = new Pet(name, food, attention, rest);
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/delete")]
    public ActionResult DeleteAll()
    {
      Pet.ClearAll();
      return View();
    }
  }
}