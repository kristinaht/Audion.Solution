using System;

namespace AudionApi.Models
{
  public class Response
  {
    public int ResponseId { get; set; }
    public DateTime Timestamp { get; set; }
    // public byte[] AudioFile { get; set; }
    public string Text {get; set;}
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Region { get; set; }
    public string Ethnicity { get; set; }
    public bool Parent { get; set; }

    public int QuestionId { get; set; }
    // public ApplicationUser User {get; set;}

    // public int QuestionId { get; set; }
  }
}