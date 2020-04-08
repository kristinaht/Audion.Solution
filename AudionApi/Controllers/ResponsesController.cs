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

    // GET /api/responses
    [HttpGet]
    public ActionResult<ICollection<Response>> Get(int questionId, string text, int age, string gender, string region, string ethnicity, bool parent)
    {
      var query = _db.Responses.AsQueryable();

      if (questionId != 0)
      {
        query = query.Where(entry => entry.QuestionId == questionId);
      }

      if (text != null)
      {
        query = query.Where(entry => entry.Text.Contains(text));
      }



      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender.Contains(gender));
      }

      if (region != null)
      {
        query = query.Where(entry => entry.Region == region);
      }

      if (ethnicity != null)
      {
        query = query.Where(entry => entry.Ethnicity.Contains(ethnicity));
      }


      return query.ToList();
    }

    // GET api/responses/5
    [HttpGet("{id}")]
    public ActionResult<Response> Get(int questionId, int id)
    {
      var thisResponse = _db.Responses.FirstOrDefault(entry => entry.ResponseId == id);
      return thisResponse;
    }

    // POST api/responses
    [HttpPost]
    public void Post(int questionId, [FromBody] Response response)
    {
      //response.QuestionId = questionId;
      response.Timestamp = DateTime.Now;
      _db.Responses.Add(response);
      _db.SaveChanges();
    }

    // PUT api/responses/5
    [HttpPut("{id}")]
    public void Put(int id, int questionId, [FromBody] Response response)
    {
      response.ResponseId = id;
      //response.QuestionId = questionId;
      response.Timestamp = DateTime.Now;
      _db.Entry(response).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/responses/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var thisResponse = _db.Responses.FirstOrDefault(entry => entry.ResponseId == id);
      _db.Responses.Remove(thisResponse);
      _db.SaveChanges();
    }

    // GET /api/responses/random
    [HttpGet("random")]
    public ActionResult<Response> Random ()
    {
      List<Response> response = _db.Responses.ToList();
      var rnd = new Random();
      int rndIdx = rnd.Next(0, response.Count);
      return response[rndIdx];
    }
  }
}