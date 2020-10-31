using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OrdersApi.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Orders");

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Orders",
                table: "Orders",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { 1, 844m, "order1" },
                    { 73, 61612m, "order73" },
                    { 72, 60768m, "order72" },
                    { 71, 59924m, "order71" },
                    { 70, 59080m, "order70" },
                    { 69, 58236m, "order69" },
                    { 68, 57392m, "order68" },
                    { 67, 56548m, "order67" },
                    { 66, 55704m, "order66" },
                    { 65, 54860m, "order65" },
                    { 64, 54016m, "order64" },
                    { 63, 53172m, "order63" },
                    { 62, 52328m, "order62" },
                    { 61, 51484m, "order61" },
                    { 60, 50640m, "order60" },
                    { 59, 49796m, "order59" },
                    { 58, 48952m, "order58" },
                    { 57, 48108m, "order57" },
                    { 56, 47264m, "order56" },
                    { 55, 46420m, "order55" },
                    { 54, 45576m, "order54" },
                    { 53, 44732m, "order53" },
                    { 74, 62456m, "order74" },
                    { 52, 43888m, "order52" },
                    { 75, 63300m, "order75" },
                    { 77, 64988m, "order77" },
                    { 98, 82712m, "order98" },
                    { 97, 81868m, "order97" },
                    { 96, 81024m, "order96" },
                    { 95, 80180m, "order95" },
                    { 94, 79336m, "order94" },
                    { 93, 78492m, "order93" },
                    { 92, 77648m, "order92" },
                    { 91, 76804m, "order91" },
                    { 90, 75960m, "order90" },
                    { 89, 75116m, "order89" },
                    { 88, 74272m, "order88" },
                    { 87, 73428m, "order87" },
                    { 86, 72584m, "order86" },
                    { 85, 71740m, "order85" },
                    { 84, 70896m, "order84" },
                    { 83, 70052m, "order83" },
                    { 82, 69208m, "order82" },
                    { 81, 68364m, "order81" },
                    { 80, 67520m, "order80" },
                    { 79, 66676m, "order79" },
                    { 78, 65832m, "order78" },
                    { 76, 64144m, "order76" },
                    { 51, 43044m, "order51" },
                    { 50, 42200m, "order50" },
                    { 49, 41356m, "order49" },
                    { 22, 18568m, "order22" },
                    { 21, 17724m, "order21" },
                    { 20, 16880m, "order20" },
                    { 19, 16036m, "order19" },
                    { 18, 15192m, "order18" },
                    { 17, 14348m, "order17" },
                    { 16, 13504m, "order16" },
                    { 15, 12660m, "order15" },
                    { 14, 11816m, "order14" },
                    { 13, 10972m, "order13" },
                    { 12, 10128m, "order12" },
                    { 11, 9284m, "order11" },
                    { 10, 8440m, "order10" },
                    { 9, 7596m, "order9" },
                    { 8, 6752m, "order8" },
                    { 7, 5908m, "order7" },
                    { 6, 5064m, "order6" },
                    { 5, 4220m, "order5" },
                    { 4, 3376m, "order4" },
                    { 3, 2532m, "order3" },
                    { 2, 1688m, "order2" },
                    { 23, 19412m, "order23" },
                    { 24, 20256m, "order24" },
                    { 25, 21100m, "order25" },
                    { 26, 21944m, "order26" },
                    { 48, 40512m, "order48" },
                    { 47, 39668m, "order47" },
                    { 46, 38824m, "order46" },
                    { 45, 37980m, "order45" },
                    { 44, 37136m, "order44" },
                    { 43, 36292m, "order43" },
                    { 42, 35448m, "order42" },
                    { 41, 34604m, "order41" },
                    { 40, 33760m, "order40" },
                    { 39, 32916m, "order39" },
                    { 99, 83556m, "order99" },
                    { 38, 32072m, "order38" },
                    { 36, 30384m, "order36" },
                    { 35, 29540m, "order35" },
                    { 34, 28696m, "order34" },
                    { 33, 27852m, "order33" },
                    { 32, 27008m, "order32" },
                    { 31, 26164m, "order31" },
                    { 30, 25320m, "order30" },
                    { 29, 24476m, "order29" },
                    { 28, 23632m, "order28" },
                    { 27, 22788m, "order27" },
                    { 37, 31228m, "order37" },
                    { 100, 84400m, "order100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                schema: "Orders",
                table: "Orders",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders",
                schema: "Orders");
        }
    }
}
