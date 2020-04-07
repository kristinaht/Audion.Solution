using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace AudionClient.Models
{
  public class Response
  {
    public int ResponseId { get; set; }
    public DateTime Timestamp { get; set; }
    public byte[] AudioFile { get; set; }
    public string Text {get; set;}

    public Question Question {get; set;}
    // public ApplicationUser User {get; set;}

    public static List<Response> GetAllResponses()
    { 
      var apiCallTask = ApiHelper.GetAllResponses();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Response> responseList = JsonConvert.DeserializeObject<List<Response>>(jsonResponse.ToString());

      return responseList;
    }

    public static Response GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetResponse(id);
      var result = apiCallTask.Result;

      JObject jsonResponse =JsonConvert.DeserializeObject<JObject>(result);
      Response response = JsonConvert.DeserializeObject<Response>(jsonResponse.ToString());

      return response;
    }

    public static void PostResponse(Response response)
    {
      string jsonResponse = JsonConvert.SerializeObject(response);
      var apiCallTask = ApiHelper.PostResponse(jsonResponse);
    }

    public static void Put(Response response)
    {
      string jsonResponse = JsonConvert.SerializeObject(response);
      var apiCallTask = ApiHelper.PutResponse(response.ResponseId, jsonResponse);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.DeleteResponse(id);
    }
    



  }
}