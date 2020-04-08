using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AudionApi.Migrations
{
    public partial class ResponseSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 31);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Responses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 2, "What is something that you would change about yourself spiritually or emotionally?" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ResponseId", "AudioFile", "QuestionId", "Text", "Timestamp" },
                values: new object[,]
                {
                    { 2, null, 5, "Test Response of Question 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, 5, "Test Response of Question 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, 3, "Test Response of Question 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, 6, "Test Response of Question 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ResponseId", "AudioFile", "QuestionId", "Text", "Timestamp" },
                values: new object[] { 1, null, 2, "Test Response of Question 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses");

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Responses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 31, "What is something that you would change about yourself spiritually or emotionally?" });

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
