using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetBreedId",
                table: "PetPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PetPosts_PetBreedId",
                table: "PetPosts",
                column: "PetBreedId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PetPosts_PetBreeds_PetBreedId",
                table: "PetPosts",
                column: "PetBreedId",
                principalTable: "PetBreeds",
                principalColumn: "PetBreedId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetPosts_PetBreeds_PetBreedId",
                table: "PetPosts");

            migrationBuilder.DropIndex(
                name: "IX_PetPosts_PetBreedId",
                table: "PetPosts");

            migrationBuilder.DropColumn(
                name: "PetBreedId",
                table: "PetPosts");
        }
    }
}
