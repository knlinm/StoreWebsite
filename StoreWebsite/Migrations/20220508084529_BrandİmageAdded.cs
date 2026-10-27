using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreWebsite.Migrations
{
    public partial class BrandİmageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Brands");

            
        }
    }
}
