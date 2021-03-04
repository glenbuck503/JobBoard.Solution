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
 [HttpGet("/pets/{id}/play")]
    public ActionResult PetPlay(int Id)
    {
      Pet foundPet = Pet.Find(Id);
      //logic to change food up and others down
      foundPet.Play();
      return RedirectToAction("Show", new { foundPet.Id });
    }
    
    [HttpGet("/pets/{id}/sleep")]
    public ActionResult PetSleep(int Id)
    {
      Pet foundPet = Pet.Find(Id);
      //logic to change food up and others down
      foundPet.Rest();
      return RedirectToAction("Show", new { foundPet.Id });
    }

    [HttpGet("/pets/{id}/attention")]
    public ActionResult PetLove(int Id)
    {
      Pet foundPet = Pet.Find(Id);
      //logic to change food up and others down
      foundPet.Love();
      return RedirectToAction("Show", new { foundPet.Id });
    }
    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet myPet = new Pet(name);
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