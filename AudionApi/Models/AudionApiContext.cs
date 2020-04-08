using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AudionApi.Models
{
  public class AudionApiContext : DbContext
  {
    public AudionApiContext(DbContextOptions<AudionApiContext> options)
      : base(options)
    {

    }

    public DbSet<Response> Responses { get; set; }
    public DbSet<Question> Questions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Question>()
          .HasData(
              new Question { QuestionId = 2, Text = "What is something that you would change about yourself spiritually or emotionally?" },
              new Question { QuestionId = 3, Text = "What’s been your biggest mistake so far in life and what did you learn from it?" },
              new Question { QuestionId = 4, Text = "Which parent are you closer to and why?"},
              new Question { QuestionId = 5, Text = "What was your favorite pastime as a young child?" },
              new Question { QuestionId = 6, Text = "What is the first life changing moment that comes to your mind?" },
              new Question { QuestionId = 7, Text = "What was the best phase in your life?" },
              new Question { QuestionId = 8, Text = "What was the worst phase in your life?" },
              new Question { QuestionId = 9, Text = "Is what you’re doing now what you always wanted to do growing up? If not, then what did you always dream of doing as a child?" },
              new Question { QuestionId = 10, Text = "What is the best vacation you have ever been on?" },
              new Question { QuestionId = 11, Text = "What’s your favorite book/movie of all time and why did it speak to you so much?" },
              new Question { QuestionId = 12, Text = "What is a relationship deal breaker for you?" },
              new Question { QuestionId = 13, Text = "What is your favorite physical feature about people who you are attracted to?" },
              new Question { QuestionId = 14, Text = "Is forgiveness important to you, or do you think that it is better to hold grudges?" },
              new Question { QuestionId = 15, Text = "When do you think a person is ready for marriage?" },
              new Question { QuestionId = 16, Text = "Who is that one person you can talk to about just anything?" },
              new Question { QuestionId = 17, Text = "Where is your favorite place in the entire world to go?" },
              new Question { QuestionId = 18, Text = "Do you usually stay friends with your exes?" },
              new Question { QuestionId = 19, Text = "How many serious relationships have you had up until this point?" },
              new Question { QuestionId = 20, Text = "Have you ever lost someone close to you? If so , who and when?" },
              new Question { QuestionId = 21, Text = "If you are in a bad mood, do you prefer to be left alone or have someone to cheer you up?" },
              new Question { QuestionId = 22, Text = "What is the best way to cheer you up on a bad day?" },
              new Question { QuestionId = 23, Text = "What’s an ideal weekend for you?" },
              new Question { QuestionId = 24, Text = "What do you think of best friends of the opposite sex?" },
              new Question { QuestionId = 25, Text = "Do you judge a book by its cover?" },
              new Question { QuestionId = 26, Text = "What was your very first job?" },
              new Question { QuestionId = 27, Text = "What are your hobbies that you like to do alone?" },
              new Question { QuestionId = 28, Text = "Do you believe in second chances? Would you give a third chance? Where is your cut off on new chances?" },
              new Question { QuestionId = 29, Text = "What’s the one thing that people always misunderstand about you?" },
              new Question { QuestionId = 30, Text = "What did your past relationship teach you?" }
          );

      builder.Entity<Response>()
          .HasData(
              new Response { ResponseId = 1, Text = "Test Response of Question 2", QuestionId = 2 },
              new Response { ResponseId = 2, Text = "Test Response of Question 5", QuestionId = 5 },
              new Response { ResponseId = 3, Text = "Test Response of Question 5", QuestionId = 5 },
              new Response { ResponseId = 4, Text = "Test Response of Question 3", QuestionId = 3 },
              new Response { ResponseId = 5, Text = "Test Response of Question 6", QuestionId = 6 }
          );    
    }    
  }
}