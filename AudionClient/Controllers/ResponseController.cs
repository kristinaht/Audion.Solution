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
    public IActionResult Index(UserResponse response)
    {
      UserResponse.PostResponse(response);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var response = UserResponse.GetDetails(id);
      return View(response);
    }


    [HttpPost]
    public IActionResult Details(int id, UserResponse response)
    {
      response.ResponseId = id;
      UserResponse.Put(response);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      UserResponse.Delete(id);
      return RedirectToAction("Index");
    }
    

  }
}