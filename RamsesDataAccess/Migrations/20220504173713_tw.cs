using Microsoft.EntityFrameworkCore.Migrations;

namespace RamsesDataAccess.Migrations
{
    public partial class tw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "ID", "Description", "ImageUrl", "NameSurname", "Password", "Role", "Username" },
                values: new object[] { 1, " A adlı TV sisteminde yayımlandı. Dizi TV sisteminde yayımlandı.", "https://t3.ftcdn.net/jpg/00/07/32/48/360_F_7324855_mx4CEBWTr81XLOrlQccCROtP2uNR7xbk.jpg", "Bülent Karanfil", "111", "Admin", "bulent" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "ID", "Description", "ImageUrl", "NameSurname", "Password", "Role", "Username" },
                values: new object[] { 2, " A adlı TV sisteminde yayımlandı. Dizi TV sisteminde yayımlandı.", "https://t3.ftcdn.net/jpg/00/07/32/48/360_F_7324855_mx4CEBWTr81XLOrlQccCROtP2uNR7xbk.jpg", "Bülent Karanfil2", "111", "Admin2", "bulent2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
