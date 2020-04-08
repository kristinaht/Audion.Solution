using System;

namespace AudionApi.Models
{
  public class Response
  {
    public int ResponseId { get; set; }
    public DateTime Timestamp { get; set; }
    public byte[] AudioFile { get; set; }
    public string Text {get; set;}

    public int QuestionId { get; set; }

    // public Question Question {get; set;}
    // public ApplicationUser User {get; set;}
  }
}