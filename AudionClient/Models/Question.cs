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
    public ICollection<Response> Responses {get; set;}
    
    public Question()
    {
      this.Responses = new HashSet<Response>();
    }


    
  }
}