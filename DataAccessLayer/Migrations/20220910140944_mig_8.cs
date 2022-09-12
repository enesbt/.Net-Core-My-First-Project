using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PetPosts_PetBreedId",
                table: "PetPosts");

            migrationBuilder.CreateIndex(
                name: "IX_PetPosts_PetBreedId",
                table: "PetPosts",
                column: "PetBreedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PetPosts_PetBreedId",
                table: "PetPosts");

            migrationBuilder.CreateIndex(
                name: "IX_PetPosts_PetBreedId",
                table: "PetPosts",
                column: "PetBreedId",
                unique: true);
        }
    }
}
