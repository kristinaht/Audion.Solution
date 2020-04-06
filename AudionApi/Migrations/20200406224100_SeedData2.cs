using Microsoft.EntityFrameworkCore.Migrations;

namespace AudionApi.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Text" },
                values: new object[,]
                {
                    { 31, "What is something that you would change about yourself spiritually or emotionally?" },
                    { 28, "Do you believe in second chances? Would you give a third chance? Where is your cut off on new chances?" },
                    { 27, "What are your hobbies that you like to do alone?" },
                    { 26, "What was your very first job?" },
                    { 25, "Do you judge a book by its cover?" },
                    { 24, "What do you think of best friends of the opposite sex?" },
                    { 23, "What’s an ideal weekend for you?" },
                    { 22, "What is the best way to cheer you up on a bad day?" },
                    { 21, "If you are in a bad mood, do you prefer to be left alone or have someone to cheer you up?" },
                    { 20, "Have you ever lost someone close to you? If so , who and when?" },
                    { 19, "How many serious relationships have you had up until this point?" },
                    { 18, "Do you usually stay friends with your exes?" },
                    { 17, "Where is your favorite place in the entire world to go?" },
                    { 29, "What’s the one thing that people always misunderstand about you?" },
                    { 16, "Who is that one person you can talk to about just anything?" },
                    { 14, "Is forgiveness important to you, or do you think that it is better to hold grudges?" },
                    { 13, "What is your favorite physical feature about people who you are attracted to?" },
                    { 12, "What is a relationship deal breaker for you?" },
                    { 11, "What’s your favorite book/movie of all time and why did it speak to you so much?" },
                    { 10, "What is the best vacation you have ever been on?" },
                    { 9, "Is what you’re doing now what you always wanted to do growing up? If not, then what did you always dream of doing as a child?" },
                    { 8, "What was the worst phase in your life?" },
                    { 7, "What was the best phase in your life?" },
                    { 6, "What is the first life changing moment that comes to your mind?" },
                    { 5, "What was your favorite pastime as a young child?" },
                    { 4, "Which parent are you closer to and why?" },
                    { 3, "What’s been your biggest mistake so far in life and what did you learn from it?" },
                    { 15, "When do you think a person is ready for marriage?" },
                    { 30, "What did your past relationship teach you?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 31);
        }
    }
}
