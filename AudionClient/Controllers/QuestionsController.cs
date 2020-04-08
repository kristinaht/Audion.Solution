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
     public IActionResult Index()
    {
      var allQuestions = Question.GetAll();
      return View(allQuestions);
    }
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

    public IActionResult Delete(int id)
    {
      Question.Delete(id);
      return RedirectToAction("Index");
    }
    
  }

}