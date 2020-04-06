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
  }
}