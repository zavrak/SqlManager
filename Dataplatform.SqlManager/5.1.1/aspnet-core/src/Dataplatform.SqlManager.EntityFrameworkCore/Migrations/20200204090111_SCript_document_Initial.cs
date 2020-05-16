using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataplatform.SqlManager.Migrations
{
    public partial class SCript_document_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScriptDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScriptType = table.Column<byte>(nullable: false),
                    ScriptText = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    SqlVersion = table.Column<bool>(nullable: false),
                    AlwaysOnActive = table.Column<bool>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptDocuments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScriptDocuments");
        }
    }
}
