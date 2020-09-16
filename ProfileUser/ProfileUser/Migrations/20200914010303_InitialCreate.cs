using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileUser.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    PID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Gender = table.Column<string>(type: "varchar(16)", nullable: false),
                    Contact = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Website = table.Column<string>(type: "varchar(500)", nullable: false),
                    About = table.Column<string>(type: "varchar(500)", nullable: false),
                    CV = table.Column<string>(type: "varchar(100)", nullable: false),
                    ProfilePic = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.PID);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "PID", "About", "CV", "Contact", "Email", "Gender", "Name", "ProfilePic", "SurName", "Website" },
                values: new object[,]
                {
                    { 1, "A mosotho young men who is inlove with software development", " ", "57090909", "stseki@gmail.com", "male", "Tsekiso", " ", "Thokoana", "www.stseki.com" },
                    { 2, "A mosotho young men who is inlove with software development", " ", "57133124", "stseki@gmail.com", "male", "Setumo", " ", "Semakela", "www.stseki.com" },
                    { 3, "A mosotho young men who is inlove with software development", " ", "57133124", "stseki@gmail.com", "male", "Thabo", " ", "Majoro", "www.stseki.com" },
                    { 4, "A mosotho young men who is inlove with software development", " ", "57133124", "stseki@gmail.com", "male", "Khauta", " ", "Maliehe", "www.stseki.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
