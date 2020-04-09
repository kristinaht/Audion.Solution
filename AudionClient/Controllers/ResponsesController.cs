using System.Net;
using Microsoft.AspNetCore.Mvc;
using AudionClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace AudionClient.Controllers
{
  public class ResponsesController : Controller
  {
    public IActionResult Index()
    {
      var allResponses = UserResponse.GetAllResponses();
      return View(allResponses);
    }

    [HttpPost]
    public IActionResult Index(int questionId, UserResponse response)
    {
      UserResponse.PostResponse(questionId, response);
      return RedirectToAction("Index");
    }
    public IActionResult Create(int questionId)
    {
      ViewBag.questionId = questionId;
      return View();
    }
    [HttpPost]
    public IActionResult Create(int questionId, UserResponse response)
    {
      UserResponse.PostResponse(questionId, response);
      return RedirectToAction("Details", "Questions", new {id = questionId});
    }

    public IActionResult Details(int responseId, int questionId)
    {
      var thisResponse = UserResponse.GetDetails(responseId, questionId);
      return View(thisResponse);
    }    
    [HttpPost]
    public IActionResult Details(int id, int questionId, UserResponse response)
    {
      response.ResponseId = id;
      UserResponse.Put(id, questionId, response);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int responseId, int questionId)
    {
      var thisResponse = UserResponse.GetDetails(responseId, questionId);
      return View(thisResponse);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int responseId, int questionId)
    {
      UserResponse.Delete(responseId, questionId);
      return RedirectToAction("Details", "Question", new {id = questionId});
    }

    //  public ActionResult Delete(int id)
    // {
    //   var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
    //   return View(thisClient);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
    //   _db.Clients.Remove(thisClient);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index", "Stylists");
    // }

    public IActionResult Random()
    {
      var response = UserResponse.GetRandom();
      return View(response);
    }
    

  }
}