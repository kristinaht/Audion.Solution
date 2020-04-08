using System.Net;
using Microsoft.AspNetCore.Mvc;
using AudionClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AudionClient.Controllers
{
  public class QuestionsController : Controller
  {
    [Authorize]
    [AllowAnonymous]
     public IActionResult Index()
    {
      var allquestions = Question.GetAll();
      return View(allquestions);
      // var thisQuestion = Question.GetRandom();
      // return View(thisQuestion);
    }

    //[Authorize(Roles = Role.Admin)]
    [HttpPost]
    public IActionResult Index(Question question)
    {
      Question.Post(question);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var question = Question.GetDetails(id);
      return View(question);
    }

    //[Authorize(Roles = Role.Admin)]
    public IActionResult Edit(int id)
    {
      var question = Question.GetDetails(id);
      return View(question);
    }

    [HttpPost]
    public IActionResult Edit(int id, Question question)
    {
      question.QuestionId = id;
      Question.Put(question);
      return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Details(int id, Question question)
    {
      question.QuestionId = id;
      Question.Put(question);
      return RedirectToAction("Details", id);
    }

    //[Authorize(Roles = Role.Admin)]
    public IActionResult Delete(int id)
    {
      Question.Delete(id);
      return RedirectToAction("Index");
    }

    public IActionResult Search(string searchStr)
    {
      var searchResults = Question.Search(searchStr);
      return View("Index", searchResults);
    }
  }
}