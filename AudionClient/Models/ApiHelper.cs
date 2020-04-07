using System.Threading.Tasks;
using RestSharp;

namespace AudionClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllResponses()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"responses", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetAllQuestions()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"questions", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetResponse(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"responses/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetQuestion(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"questions/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task PostResponse(string newResponse)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"responses", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newResponse);
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task PostQuestion(string newQuestion)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"questions", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newQuestion);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task PutResponse(int id, string newResponse)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"responses/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newResponse);
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task PutQuestion(int id, string newQuestion)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"questions/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newQuestion);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task DeleteResponse(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"responses/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task DeleteQuestion(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"questions/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

    // public static async Task<string> GetRandom()
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"reviews/random", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }
  }
}