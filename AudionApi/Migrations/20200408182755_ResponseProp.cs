using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AudionApi.Migrations
{
    public partial class ResponseProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioFile",
                table: "Responses");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Responses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ethnicity",
                table: "Responses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Responses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Parent",
                table: "Responses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Responses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 1, "What’s one thing you wish you knew how to do?" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 1,
                columns: new[] { "Age", "Ethnicity", "Gender", "Parent", "Region" },
                values: new object[] { 1, "White", "Male", true, "Northwest" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 2,
                columns: new[] { "Age", "Ethnicity", "Gender", "Parent", "Region" },
                values: new object[] { 2, "Black", "Male", true, "Southwest" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 3,
                columns: new[] { "Age", "Ethnicity", "Gender", "Parent", "Region" },
                values: new object[] { 2, "Latino", "Female", true, "Northwest" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 4,
                columns: new[] { "Age", "Ethnicity", "Gender", "Region" },
                values: new object[] { 2, "Latino", "Female", "Southwest" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 5,
                columns: new[] { "Age", "Ethnicity", "Gender", "Parent", "QuestionId", "Region", "Text" },
                values: new object[] { 2, "White", "Female", true, 3, "Southwest", "Test Response of Question 3" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ResponseId", "Age", "Ethnicity", "Gender", "Parent", "QuestionId", "Region", "Text", "Timestamp" },
                values: new object[,]
                {
                    { 6, 1, "Black", "Male", true, 3, "Southeast", "Test Response of Question 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, "Latino", "Female", true, 6, "Southwest", "Test Response of Question 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, "Asian", "Female", true, 6, "Northwest", "Test Response of Question 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, "Latino", "Female", true, 6, "Southeast", "Test Response of Question 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "Ethnicity",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Responses");

            migrationBuilder.AddColumn<byte[]>(
                name: "AudioFile",
                table: "Responses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "ResponseId",
                keyValue: 5,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 6, "Test Response of Question 6" });
        }
    }
}
