using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Show(int Id)
    {

      Job foundJob = Job.Find(Id);
      return View(foundJob);
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string email)
    {
      Job myJob = new Job(title, email);
      return RedirectToAction("Index");
    }

    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      Job.ClearAll();
      return View();
    }
  }
}