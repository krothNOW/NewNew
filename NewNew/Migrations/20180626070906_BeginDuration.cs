using Microsoft.EntityFrameworkCore.Migrations;

namespace NewNew.Migrations
{
    public partial class BeginDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BeginDuration",
                table: "FormSubmission",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginDuration",
                table: "FormSubmission");
        }
    }
}
