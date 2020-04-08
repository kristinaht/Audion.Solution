using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using AudionApi.Models;

namespace AudionApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ResponsesController : Controller
  {
    private readonly AudionApiContext _db;

    public ResponsesController(AudionApiContext db)
    {
      _db = db;
    } 

    [HttpGet]
    public ActionResult<ICollection<Response>> Get(int questionId)
    {
      var query = _db.Responses.AsQueryable();

      if (questionId != 0)
      {
        query = query.Where(entry => entry.QuestionId == questionId);
      }

      return query.ToList();
    }

    public ActionResult Index()
    {
      return View();
    }
    
    public ActionResult Create()
    {
      ViewBag.QuestionId = new SelectList(_db.Questions, "QuestionId", "Location");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Response response)
    {
      _db.Responses.Add(response);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}