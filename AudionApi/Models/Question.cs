using System.Collections.Generic;

namespace AudionApi.Models
{
  public class Question
  {
    public int QuestionId {get; set;}
    public string Text {get; set;}
    public ICollection<Response> Responses {get; set;}
    
    public Question()
    {
      this.Responses = new HashSet<Response>();
    }
  }
}