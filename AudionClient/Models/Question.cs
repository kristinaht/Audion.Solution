using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace AudionClient.Models
{
    public class Question
  {
    public int QuestionId {get; set;}
    public string Text {get; set;}
    public ApplicationUser User {get; set;}
    public ICollection<UserResponse> Responses {get; set;}
    
    public Question()
    {
      this.Responses = new HashSet<UserResponse>();
    }

    public static List<Question> GetAll()
    {
      var apiCallTask = ApiHelper.GetAllQuestions();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Question> questionList = JsonConvert.DeserializeObject<List<Question>>(jsonResponse.ToString());

      return questionList;
    }
    public static Question GetRandom()
    {
      var apiCallTask = ApiHelper.GetRandomQuestion();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Question question = JsonConvert.DeserializeObject<Question>(jsonResponse.ToString());

      return question;
    }

    public static Question GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetQuestion(id);
      var result = apiCallTask.Result;

      JObject jsonResponse =JsonConvert.DeserializeObject<JObject>(result);
      Question question = JsonConvert.DeserializeObject<Question>(jsonResponse.ToString());

      return question;
    }

    public static void Post(Question question)
    {
      string jsonQuestion = JsonConvert.SerializeObject(question);
      var apiCallTask = ApiHelper.PostQuestion(jsonQuestion);
    }

    public static void Put(Question question)
    {
      string jsonQuestion = JsonConvert.SerializeObject(question);
      var apiCallTask = ApiHelper.PutQuestion(question.QuestionId, jsonQuestion);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.DeleteQuestion(id);
    }

    public static List<Question> Search(string searchStr)
    {
      var apiCallTask = ApiHelper.Search(searchStr);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Question> questionList = JsonConvert.DeserializeObject<List<Question>>(jsonResponse.ToString());

      return questionList;
    }
  }
}