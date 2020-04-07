using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AudionApi.Models;
using Microsoft.EntityFrameworkCore;

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
    // [HttpGet]
    // public ActionResult<IEnumerable<Question>> Get()
    // {
    //   return _db.Questions.ToList();
    // }

    [HttpGet]
    public ActionResult<IEnumerable<Question>> Get(int questionId, string text)
    {
      var query = _db.Questions.AsQueryable();

      if (questionId != 0)
      {
        query = query.Where(entry => entry.QuestionId == questionId);
      }


      if (text != null)
      {
        query = query.Where(entry => entry.Text.Contains(text));
      }
      
      return query.ToList();
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

        // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Question question)
    {
      question.QuestionId = id;
      _db.Entry(question).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/questions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var questionToDelete = _db.Questions.FirstOrDefault(entry => entry.QuestionId == id);
      _db.Questions.Remove(questionToDelete);
      _db.SaveChanges();
    }
  }
}