using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AudionApi.Models;

namespace AudionApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionsController : ControllerBase
  {
    private AudionApiContext _db;

    public QuestionsController(AudionApiContext db)
    {
      _db = db;
    }

    // GET api/questions
    [HttpGet]
    public ActionResult<IEnumerable<Question>> Get()
    {
      return _db.Questions.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Question> Get(int id)
{
    return _db.Questions.FirstOrDefault(entry => entry.QuestionId == id);
}

    // POST api/questions
    [HttpPost]
    public void Post([FromBody] Question question)
    {
      _db.Questions.Add(question);
      _db.SaveChanges();
    }
  }
}