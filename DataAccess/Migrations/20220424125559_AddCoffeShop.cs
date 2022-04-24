using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "CoffeeShops",
            columns: new[] { "id","Name", "OpeningHours", "Address" },
            values: new object[] {"1009a70a-c3d3-11ec-9d64-0242ac120002","Strada", "9-5 sousse" , "Tunisie" });
            migrationBuilder.InsertData(
            table: "CoffeeShops",
            columns: new[] { "id", "Name", "OpeningHours", "Address" },
            values: new object[] { "20eff39e-c3d3-11ec-9d64-0242ac120002", "chyeb", "9-5 mestir", "Tunisie" });
        }
            
        

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
