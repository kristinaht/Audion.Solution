using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AudionApi.Models
{
  public class Question
  {
    public int QuestionId {get; set;}
    [Required]
    public string Text {get; set;}
    [Required]
    public ICollection<Response> Responses {get; set;}
    
    public Question()
    {
      this.Responses = new HashSet<Response>();
    }
  }
}