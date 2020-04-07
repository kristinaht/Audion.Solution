using System.Threading.Tasks;
using RestSharp;

namespace AudionClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllResponses()
    {
      RestClient client = new RestClient("http://localhost:5000/api/responses");
      RestRequest request = new RestRequest($"responses", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetAllQuestions()
    {
      RestClient client = new RestClient("http://localhost:5000/api/questions");
      RestRequest request = new RestRequest($"questions", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    // public static async Task<string> Get(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"reviews/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    // public static async Task Post(string newReview)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"reviews", Method.POST);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newReview);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Put(int id, string newReview)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"reviews/{id}", Method.PUT);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newReview);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Delete(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"reviews/{id}", Method.DELETE);
    //   request.AddHeader("Content-Type", "application/json");
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task<string> GetRandom()
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"reviews/random", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }
  }
}