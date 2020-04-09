using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace AudionClient.Models
{
  public class UserResponse
  {
    public int ResponseId { get; set; }
    public DateTime Timestamp { get; set; }
    public string Text {get; set;}
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Region { get; set; }
    public string Ethnicity { get; set; }
    public bool Parent { get; set; }

    public int QuestionId { get; set; }
    public ApplicationUser User {get; set;}

    public static List<UserResponse> GetAllResponses()
    { 
      var apiCallTask = ApiHelper.GetAllResponses();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<UserResponse> responseList = JsonConvert.DeserializeObject<List<UserResponse>>(jsonResponse.ToString());

      return responseList;
    }
    public static UserResponse GetRandom()
    {
      var apiCallTask = ApiHelper.GetRandomResponse();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      UserResponse response = JsonConvert.DeserializeObject<UserResponse>(jsonResponse.ToString());

      return response;
    }

    public static UserResponse GetDetails(int responseId, int questionId )
    {
      var apiCallTask = ApiHelper.GetResponse(responseId, questionId);
      var result = apiCallTask.Result;

      JObject jsonResponse =JsonConvert.DeserializeObject<JObject>(result);
      UserResponse response = JsonConvert.DeserializeObject<UserResponse>(jsonResponse.ToString());

      return response;
    }

    public static void PostResponse(int questionId, UserResponse response)
    {
      string jsonResponse = JsonConvert.SerializeObject(response);
      var apiCallTask = ApiHelper.PostResponse(questionId,jsonResponse);
    }

    public static void Put(int responseId, int questionId, UserResponse response)
    {
      string jsonResponse = JsonConvert.SerializeObject(response);
      var apiCallTask = ApiHelper.PutResponse(questionId, response.ResponseId, jsonResponse);
    }

    public static void Delete(int responseId)
    {
      var apiCallTask = ApiHelper.DeleteResponse(responseId);
    }

    
  }
}