using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWT_Implementation.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cost", "name" },
                values: new object[] { 500.78881695214614, "Handmade Granite Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cost", "name" },
                values: new object[] { 554.39363664145981, "Refined Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cost", "name" },
                values: new object[] { 190.55440269419398, "Generic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cost", "name" },
                values: new object[] { 296.0436820342378, "Intelligent Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cost", "name" },
                values: new object[] { 884.66912324160171, "Ergonomic Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cost", "name" },
                values: new object[] { 118.149493592952, "Awesome Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.99004100031107, "Gorgeous Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cost", "name" },
                values: new object[] { 251.72144726830379, "Generic Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cost", "name" },
                values: new object[] { 870.80633851704067, "Gorgeous Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cost", "name" },
                values: new object[] { 14.926837657490079, "Rustic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cost", "name" },
                values: new object[] { 351.31898678518934, "Incredible Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.1239644004321, "Ergonomic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.590022143209978, "Rustic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cost", "name" },
                values: new object[] { 258.20144716962892, "Refined Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.74421051784202, "Intelligent Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cost", "name" },
                values: new object[] { 426.76799223454543, "Rustic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.83243615966552, "Ergonomic Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cost", "name" },
                values: new object[] { 255.96901167000922, "Incredible Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.696717108534003, "Handmade Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.61178865675288, "Refined Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cost", "name" },
                values: new object[] { 751.95575527364122, "Awesome Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cost", "name" },
                values: new object[] { 611.92465181886166, "Generic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cost", "name" },
                values: new object[] { 400.47960554419012, "Licensed Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.62758075954093, "Tasty Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.46702586922247, "Refined Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "cost", "name" },
                values: new object[] { 542.238617109438, "Sleek Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "cost", "name" },
                values: new object[] { 725.09028800966996, "Incredible Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "cost", "name" },
                values: new object[] { 915.6679941915902, "Sleek Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "cost", "name" },
                values: new object[] { 595.103507999523, "Fantastic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "cost", "name" },
                values: new object[] { 485.220608992047, "Refined Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.36070281639957, "Tasty Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.330158995014926, "Handcrafted Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "cost", "name" },
                values: new object[] { 225.1113926071709, "Awesome Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "cost", "name" },
                values: new object[] { 944.00729418229628, "Sleek Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "cost", "name" },
                values: new object[] { 897.86559440976282, "Ergonomic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "cost", "name" },
                values: new object[] { 151.05231117352906, "Incredible Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "cost", "name" },
                values: new object[] { 873.78129268316366, "Practical Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "cost", "name" },
                values: new object[] { 974.5625274392313, "Generic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "cost", "name" },
                values: new object[] { 750.04452167506031, "Practical Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "cost", "name" },
                values: new object[] { 19.488610635690048, "Small Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "cost", "name" },
                values: new object[] { 259.05160969612115, "Practical Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "cost", "name" },
                values: new object[] { 175.28005851254278, "Generic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.68202003831743, "Tasty Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "cost", "name" },
                values: new object[] { 990.13009844138344, "Incredible Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "cost", "name" },
                values: new object[] { 645.25786280052785, "Incredible Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "cost", "name" },
                values: new object[] { 849.39708497132835, "Generic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.4901314688434, "Handmade Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "cost", "name" },
                values: new object[] { 283.00232810034953, "Practical Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "cost", "name" },
                values: new object[] { 655.60184200146978, "Small Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.608702518161692, "Intelligent Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "cost", "name" },
                values: new object[] { 385.98315093780843, "Awesome Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "cost", "name" },
                values: new object[] { 973.74853852210072, "Awesome Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "cost", "name" },
                values: new object[] { 770.25571028527588, "Tasty Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "cost", "name" },
                values: new object[] { 572.6689450062421, "Refined Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "cost", "name" },
                values: new object[] { 923.62929694530658, "Small Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "cost", "name" },
                values: new object[] { 720.52104206844899, "Ergonomic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "cost", "name" },
                values: new object[] { 203.94047095176145, "Ergonomic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "cost", "name" },
                values: new object[] { 304.54635848801291, "Awesome Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "cost", "name" },
                values: new object[] { 866.29500885935965, "Handmade Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.5175525781965, "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "cost", "name" },
                values: new object[] { 184.78983256578439, "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "cost", "name" },
                values: new object[] { 539.64043902418268, "Incredible Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "cost", "name" },
                values: new object[] { 67.523680053697632, "Small Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.30548684770761, "Ergonomic Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "cost", "name" },
                values: new object[] { 76.71527716558073, "Intelligent Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "cost", "name" },
                values: new object[] { 239.96741530676809, "Incredible Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.515988910872053, "Tasty Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "cost", "name" },
                values: new object[] { 751.23313858497363, "Refined Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "cost", "name" },
                values: new object[] { 928.22888085448756, "Awesome Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.20899469527299, "Incredible Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "cost", "name" },
                values: new object[] { 206.05229674618283, "Small Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.69862871966077, "Intelligent Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.25460701426977, "Small Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.16227566769174, "Intelligent Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "cost", "name" },
                values: new object[] { 309.9479511049019, "Sleek Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "cost", "name" },
                values: new object[] { 683.67654302581172, "Refined Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "cost", "name" },
                values: new object[] { 640.45175921032035, "Practical Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "cost", "name" },
                values: new object[] { 430.41931314885926, "Handcrafted Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "cost", "name" },
                values: new object[] { 759.1038501542065, "Unbranded Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "cost", "name" },
                values: new object[] { 520.35222385427949, "Generic Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "cost", "name" },
                values: new object[] { 357.28070494454295, "Intelligent Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "cost", "name" },
                values: new object[] { 561.10717763937487, "Gorgeous Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "cost", "name" },
                values: new object[] { 307.4817124365232, "Unbranded Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.2229452890752, "Awesome Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "cost", "name" },
                values: new object[] { 949.16647935328535, "Small Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "cost", "name" },
                values: new object[] { 892.92469704142229, "Generic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "cost", "name" },
                values: new object[] { 898.3756636978984, "Sleek Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "cost", "name" },
                values: new object[] { 952.75378770790439, "Sleek Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "cost", "name" },
                values: new object[] { 102.99224920125172, "Incredible Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "cost", "name" },
                values: new object[] { 9.1582109777828951, "Incredible Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "cost", "name" },
                values: new object[] { 333.29096823730998, "Handmade Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "cost", "name" },
                values: new object[] { 91.247947917779342, "Gorgeous Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "cost", "name" },
                values: new object[] { 546.27795154563876, "Handcrafted Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "cost", "name" },
                values: new object[] { 817.09718521569698, "Incredible Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "cost", "name" },
                values: new object[] { 311.25073631961459, "Refined Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "cost", "name" },
                values: new object[] { 281.78171626734303, "Rustic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.75747883052111, "Tasty Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "cost", "name" },
                values: new object[] { 590.65787929460714, "Handmade Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "cost", "name" },
                values: new object[] { 37.520824969342449, "Small Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "cost", "name" },
                values: new object[] { 602.97056188842839, "Practical Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "cost", "name" },
                values: new object[] { 465.51434755585541, "Refined Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "cost", "name" },
                values: new object[] { 704.2078480813816, "Intelligent Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.44679591429133, "Ergonomic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "cost", "name" },
                values: new object[] { 34.802722023910519, "Gorgeous Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "cost", "name" },
                values: new object[] { 988.84241905754027, "Rustic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "cost", "name" },
                values: new object[] { 538.75674955922602, "Generic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.70622777573637, "Practical Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.78693982558104, "Ergonomic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "cost", "name" },
                values: new object[] { 217.24054268515138, "Ergonomic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "cost", "name" },
                values: new object[] { 701.7072929562911, "Sleek Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.57964584828983, "Fantastic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "cost", "name" },
                values: new object[] { 615.94645944562103, "Rustic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.58349758212512, "Gorgeous Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "cost", "name" },
                values: new object[] { 731.613922274488, "Rustic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.63182925345427, "Tasty Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "cost", "name" },
                values: new object[] { 793.29703797846014, "Intelligent Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.04674725671708, "Refined Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.862167202762606, "Rustic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "cost", "name" },
                values: new object[] { 98.378595749615144, "Ergonomic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "cost", "name" },
                values: new object[] { 417.8838622384705, "Unbranded Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "cost", "name" },
                values: new object[] { 67.23461327698783, "Rustic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "cost", "name" },
                values: new object[] { 520.43663159390474, "Handcrafted Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "cost", "name" },
                values: new object[] { 318.22777631223863, "Generic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.76378393131678, "Licensed Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "cost", "name" },
                values: new object[] { 519.12141525764366, "Sleek Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.29926476205873, "Incredible Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "cost", "name" },
                values: new object[] { 229.94700511864227, "Handcrafted Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "cost", "name" },
                values: new object[] { 518.65997718521862, "Generic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "cost", "name" },
                values: new object[] { 644.17856605719544, "Sleek Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.34301423084514, "Fantastic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "cost", "name" },
                values: new object[] { 339.51015500728948, "Licensed Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "cost", "name" },
                values: new object[] { 34.163993591076597, "Licensed Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "cost", "name" },
                values: new object[] { 548.30488797076248, "Rustic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "cost", "name" },
                values: new object[] { 953.8676885354547, "Ergonomic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.48790249682048, "Practical Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "cost", "name" },
                values: new object[] { 976.77538093086844, "Tasty Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "cost", "name" },
                values: new object[] { 946.55020564419317, "Intelligent Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "cost", "name" },
                values: new object[] { 461.06409235267478, "Generic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "cost", "name" },
                values: new object[] { 596.99996461599471, "Unbranded Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "cost", "name" },
                values: new object[] { 869.3949901971406, "Incredible Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "cost", "name" },
                values: new object[] { 645.14770623171489, "Intelligent Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "cost", "name" },
                values: new object[] { 413.24835676963448, "Ergonomic Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "cost", "name" },
                values: new object[] { 263.60406822115243, "Licensed Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.65610955349177, "Generic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.33748799408716, "Sleek Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "cost", "name" },
                values: new object[] { 122.1922487199033, "Refined Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "cost", "name" },
                values: new object[] { 773.74400087242748, "Fantastic Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.55650919511993, "Tasty Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "cost", "name" },
                values: new object[] { 418.08009575433078, "Rustic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "cost", "name" },
                values: new object[] { 359.40752305731024, "Unbranded Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "cost", "name" },
                values: new object[] { 908.11429256640383, "Intelligent Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "cost", "name" },
                values: new object[] { 524.52830356091408, "Generic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "cost", "name" },
                values: new object[] { 664.00754932725181, "Unbranded Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "cost", "name" },
                values: new object[] { 554.18221837236865, "Gorgeous Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.93694496507658, "Fantastic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.00228011358934, "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "cost", "name" },
                values: new object[] { 62.445900121353517, "Practical Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "cost", "name" },
                values: new object[] { 140.15661781500611, "Licensed Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.42293097693249, "Practical Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "cost", "name" },
                values: new object[] { 28.588985353808223, "Sleek Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "cost", "name" },
                values: new object[] { 31.573626003355237, "Gorgeous Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "cost", "name" },
                values: new object[] { 605.01384574171516, "Intelligent Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.00948234781151, "Intelligent Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.60961363394233, "Handmade Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.77401999361524, "Gorgeous Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "cost", "name" },
                values: new object[] { 187.9762839701107, "Gorgeous Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.375188564804972, "Incredible Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "cost", "name" },
                values: new object[] { 798.42065712428314, "Refined Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "cost", "name" },
                values: new object[] { 369.72628158476726, "Handmade Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "cost", "name" },
                values: new object[] { 129.06100128130589, "Generic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "cost", "name" },
                values: new object[] { 219.28336337634607, "Ergonomic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "cost", "name" },
                values: new object[] { 455.40481151076909, "Fantastic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "cost", "name" },
                values: new object[] { 42.174585658152623, "Practical Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "cost", "name" },
                values: new object[] { 472.13932395627717, "Tasty Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "cost", "name" },
                values: new object[] { 467.10684198596294, "Gorgeous Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.51876448785873, "Handcrafted Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.32351892757322, "Tasty Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.72510783924497, "Practical Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "cost", "name" },
                values: new object[] { 554.58975387770431, "Generic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "cost", "name" },
                values: new object[] { 497.33943322047452, "Generic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "cost", "name" },
                values: new object[] { 932.52803499507399, "Tasty Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.83701137253968, "Gorgeous Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "cost", "name" },
                values: new object[] { 103.66314901789966, "Generic Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "cost", "name" },
                values: new object[] { 404.86227906300223, "Intelligent Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "cost", "name" },
                values: new object[] { 257.85008909577761, "Awesome Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "cost", "name" },
                values: new object[] { 300.44533790031278, "Handcrafted Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.92180518124405, "Generic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "cost", "name" },
                values: new object[] { 760.00620170895104, "Handmade Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.75314979549603, "Practical Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "cost", "name" },
                values: new object[] { 957.61650647428576, "Awesome Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "cost", "name" },
                values: new object[] { 514.49977121960978, "Refined Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.1105918736655, "Sleek Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.84687201157499, "Generic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "cost", "name" },
                values: new object[] { 491.33242404962544, "Unbranded Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "cost", "name" },
                values: new object[] { 866.45623881711981, "Awesome Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "cost", "name" },
                values: new object[] { 945.61994580478893, "Ergonomic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "cost", "name" },
                values: new object[] { 337.90349110257745, "Ergonomic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.55626005118947, "Awesome Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.03005763225326, "Handcrafted Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.61113065678501, "Refined Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "cost", "name" },
                values: new object[] { 95.449061305514149, "Tasty Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "cost", "name" },
                values: new object[] { 400.43043425964663, "Tasty Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "cost", "name" },
                values: new object[] { 104.39048910693154, "Sleek Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.787362503253789, "Sleek Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "cost", "name" },
                values: new object[] { 370.94541216301292, "Fantastic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.89295172160951, "Fantastic Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "cost", "name" },
                values: new object[] { 254.86291555499619, "Generic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "cost", "name" },
                values: new object[] { 684.86637285281802, "Refined Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "cost", "name" },
                values: new object[] { 805.91356924708248, "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "cost", "name" },
                values: new object[] { 709.36040956274405, "Intelligent Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "cost", "name" },
                values: new object[] { 992.29599682660898, "Licensed Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "cost", "name" },
                values: new object[] { 977.8811208308199, "Awesome Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "cost", "name" },
                values: new object[] { 911.14124422908571, "Sleek Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.60539251469663, "Awesome Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "cost", "name" },
                values: new object[] { 764.21094990988036, "Generic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "cost", "name" },
                values: new object[] { 312.76506890272867, "Rustic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "cost", "name" },
                values: new object[] { 815.98265638735279, "Tasty Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "cost", "name" },
                values: new object[] { 10.04833030610569, "Small Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "cost", "name" },
                values: new object[] { 61.223412980537127, "Ergonomic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "cost", "name" },
                values: new object[] { 906.48029147156501, "Practical Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "cost", "name" },
                values: new object[] { 932.84083201505223, "Rustic Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "cost", "name" },
                values: new object[] { 794.17652953059871, "Practical Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "cost", "name" },
                values: new object[] { 181.28745054363921, "Awesome Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "cost", "name" },
                values: new object[] { 381.11119305666921, "Small Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "cost", "name" },
                values: new object[] { 459.88478619871751, "Gorgeous Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "cost", "name" },
                values: new object[] { 849.37316824056234, "Generic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.8291521633556, "Handmade Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.08727759039238, "Generic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "cost", "name" },
                values: new object[] { 413.1168895986558, "Incredible Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "cost", "name" },
                values: new object[] { 381.42812355264954, "Sleek Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "cost", "name" },
                values: new object[] { 390.30210330428474, "Gorgeous Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "cost", "name" },
                values: new object[] { 560.89349437216686, "Handmade Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "cost", "name" },
                values: new object[] { 100.05697900759584, "Tasty Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.99978747634282, "Intelligent Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "cost", "name" },
                values: new object[] { 953.5422750776695, "Licensed Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.25726193310481, "Handcrafted Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "cost", "name" },
                values: new object[] { 254.9039926980324, "Incredible Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "cost", "name" },
                values: new object[] { 379.33768526732922, "Unbranded Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "cost", "name" },
                values: new object[] { 261.90081435260805, "Ergonomic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.56757910670882, "Rustic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "cost", "name" },
                values: new object[] { 448.92714310633289, "Handmade Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "cost", "name" },
                values: new object[] { 807.26304847790493, "Sleek Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "cost", "name" },
                values: new object[] { 612.07358392843685, "Unbranded Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "cost", "name" },
                values: new object[] { 316.25592510077166, "Licensed Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "cost", "name" },
                values: new object[] { 753.30969046476969, "Handmade Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.33865375138865, "Small Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "cost", "name" },
                values: new object[] { 162.00632930241628, "Handmade Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "cost", "name" },
                values: new object[] { 789.39933483524726, "Handmade Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "cost", "name" },
                values: new object[] { 507.26005747804419, "Handmade Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "cost", "name" },
                values: new object[] { 583.75551239307254, "Generic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "cost", "name" },
                values: new object[] { 645.75090499456496, "Awesome Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "cost", "name" },
                values: new object[] { 432.33591830703978, "Gorgeous Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "cost", "name" },
                values: new object[] { 116.01680339427548, "Fantastic Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "cost", "name" },
                values: new object[] { 836.9231798350412, "Small Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "cost", "name" },
                values: new object[] { 251.35427852938494, "Handcrafted Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "cost", "name" },
                values: new object[] { 163.82444442340949, "Unbranded Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "cost", "name" },
                values: new object[] { 334.74439821717061, "Unbranded Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.10796129401558, "Handcrafted Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "cost", "name" },
                values: new object[] { 890.70557461725718, "Fantastic Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "cost", "name" },
                values: new object[] { 608.22837945118476, "Handmade Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "cost", "name" },
                values: new object[] { 136.05869580381969, "Tasty Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "cost", "name" },
                values: new object[] { 228.94744980531414, "Ergonomic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "cost", "name" },
                values: new object[] { 163.18150142236217, "Unbranded Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.94557728081304, "Generic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "cost", "name" },
                values: new object[] { 57.202049956651038, "Licensed Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "cost", "name" },
                values: new object[] { 792.36388187833552, "Incredible Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.63374268698226, "Unbranded Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "cost", "name" },
                values: new object[] { 833.19500764502448, "Generic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "cost", "name" },
                values: new object[] { 166.36655391369058, "Ergonomic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "cost", "name" },
                values: new object[] { 637.04337528287476, "Handcrafted Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "cost", "name" },
                values: new object[] { 79.478903455523891, "Generic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.14283020416565, "Ergonomic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "cost", "name" },
                values: new object[] { 52.561921135367008, "Intelligent Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "cost", "name" },
                values: new object[] { 626.29553316899137, "Handcrafted Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.77122655403275, "Unbranded Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "cost", "name" },
                values: new object[] { 412.30649404606316, "Small Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "cost", "name" },
                values: new object[] { 159.11645108247276, "Tasty Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "cost", "name" },
                values: new object[] { 823.65450414697818, "Tasty Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.58394594981098, "Handmade Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "cost", "name" },
                values: new object[] { 767.69513820013026, "Generic Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "cost", "name" },
                values: new object[] { 705.69722789675814, "Licensed Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "cost", "name" },
                values: new object[] { 145.85985060804754, "Tasty Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "cost", "name" },
                values: new object[] { 816.84953955826427, "Small Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.99677857168786, "Rustic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.03873265430488, "Licensed Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "cost", "name" },
                values: new object[] { 615.38618526492826, "Small Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.71655678711988, "Gorgeous Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "cost", "name" },
                values: new object[] { 78.540137602771622, "Rustic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "cost", "name" },
                values: new object[] { 831.47518549528525, "Handmade Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "cost", "name" },
                values: new object[] { 163.2322405134791, "Ergonomic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "cost", "name" },
                values: new object[] { 522.71395852790545, "Practical Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "cost", "name" },
                values: new object[] { 324.84429395266659, "Sleek Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "cost", "name" },
                values: new object[] { 961.97266629834724, "Incredible Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "cost", "name" },
                values: new object[] { 590.16512440447968, "Tasty Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "cost", "name" },
                values: new object[] { 526.32653737033343, "Generic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.46587751793538, "Handmade Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "cost", "name" },
                values: new object[] { 84.550690667958136, "Handmade Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "cost", "name" },
                values: new object[] { 835.44168892688538, "Tasty Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.09202590640314, "Awesome Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "cost", "name" },
                values: new object[] { 379.09405266904565, "Generic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "cost", "name" },
                values: new object[] { 120.41725900902485, "Ergonomic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.59433187368177, "Generic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.73874766900343, "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "cost", "name" },
                values: new object[] { 126.22721018220848, "Rustic Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "cost", "name" },
                values: new object[] { 967.19907108130508, "Practical Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "cost", "name" },
                values: new object[] { 17.390410532129209, "Unbranded Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "cost", "name" },
                values: new object[] { 371.78015431352111, "Handmade Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "cost", "name" },
                values: new object[] { 841.60574707150511, "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.07957495089363, "Handmade Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "cost", "name" },
                values: new object[] { 700.27318326452701, "Ergonomic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "cost", "name" },
                values: new object[] { 926.569241102251, "Licensed Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "cost", "name" },
                values: new object[] { 420.25111812479099, "Ergonomic Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "cost", "name" },
                values: new object[] { 356.04888499334737, "Rustic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "cost", "name" },
                values: new object[] { 675.90384078523846, "Practical Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.56026155471505, "Handcrafted Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "cost", "name" },
                values: new object[] { 998.48909891031974, "Practical Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "cost", "name" },
                values: new object[] { 459.57203303813981, "Intelligent Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "cost", "name" },
                values: new object[] { 280.40768716220691, "Rustic Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "cost", "name" },
                values: new object[] { 651.7483998993356, "Awesome Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "cost", "name" },
                values: new object[] { 715.01202048962352, "Rustic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.00436764470714, "Generic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "cost", "name" },
                values: new object[] { 675.71442654016903, "Fantastic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "cost", "name" },
                values: new object[] { 79.09982076241397, "Ergonomic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "cost", "name" },
                values: new object[] { 381.48481009630387, "Handcrafted Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.05183439407608, "Handmade Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.18316109915395, "Tasty Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "cost", "name" },
                values: new object[] { 383.76061367345579, "Intelligent Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "cost", "name" },
                values: new object[] { 190.84063482130614, "Rustic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "cost", "name" },
                values: new object[] { 803.40992123516969, "Tasty Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "cost", "name" },
                values: new object[] { 641.81161359495343, "Handmade Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.9939508747224, "Handcrafted Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "cost", "name" },
                values: new object[] { 799.24373175004723, "Gorgeous Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "cost", "name" },
                values: new object[] { 850.49519463530919, "Small Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.53186701843708, "Awesome Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "cost", "name" },
                values: new object[] { 123.82268790121344, "Handmade Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "cost", "name" },
                values: new object[] { 412.26473787194249, "Awesome Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "cost", "name" },
                values: new object[] { 739.45210356809798, "Generic Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "cost", "name" },
                values: new object[] { 384.59156088596364, "Unbranded Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "cost", "name" },
                values: new object[] { 384.25382694187073, "Practical Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "cost", "name" },
                values: new object[] { 983.34377335354532, "Intelligent Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.71209332879948, "Intelligent Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "cost", "name" },
                values: new object[] { 890.19195795046653, "Sleek Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "cost", "name" },
                values: new object[] { 480.88823562718892, "Unbranded Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.76414305257353, "Tasty Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "cost", "name" },
                values: new object[] { 240.23308398671224, "Awesome Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.4456732147346, "Ergonomic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "cost", "name" },
                values: new object[] { 893.96761088248707, "Practical Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "cost", "name" },
                values: new object[] { 913.03199216811902, "Small Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "cost", "name" },
                values: new object[] { 849.36360507015729, "Generic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "cost", "name" },
                values: new object[] { 879.51297179616836, "Refined Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "cost", "name" },
                values: new object[] { 954.58706213914627, "Intelligent Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "cost", "name" },
                values: new object[] { 777.18311106868555, "Incredible Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "cost", "name" },
                values: new object[] { 819.89375667604429, "Awesome Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "cost", "name" },
                values: new object[] { 48.623094549030768, "Rustic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "cost", "name" },
                values: new object[] { 406.22445580115169, "Practical Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "cost", "name" },
                values: new object[] { 432.777813478491, "Licensed Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "cost", "name" },
                values: new object[] { 292.36626877156317, "Unbranded Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "cost", "name" },
                values: new object[] { 834.75900247866161, "Awesome Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "cost", "name" },
                values: new object[] { 303.97122881042122, "Intelligent Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "cost", "name" },
                values: new object[] { 857.08123170874978, "Awesome Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "cost", "name" },
                values: new object[] { 984.99818294395641, "Licensed Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "cost", "name" },
                values: new object[] { 907.2585670661465, "Handcrafted Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "cost", "name" },
                values: new object[] { 35.444603449388858, "Awesome Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "cost", "name" },
                values: new object[] { 369.13828788960097, "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "cost", "name" },
                values: new object[] { 829.85492218551065, "Refined Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "cost", "name" },
                values: new object[] { 883.50765259592742, "Fantastic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.06739629255105, "Awesome Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.39940252387032, "Handmade Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "cost", "name" },
                values: new object[] { 728.13534386060769, "Intelligent Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "cost", "name" },
                values: new object[] { 834.65197039074656, "Fantastic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.04748484590289, "Handcrafted Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.40583677557368, "Practical Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "cost", "name" },
                values: new object[] { 951.42774839351898, "Refined Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "cost", "name" },
                values: new object[] { 147.26499478203567, "Gorgeous Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "cost", "name" },
                values: new object[] { 869.34784240554393, "Awesome Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "cost", "name" },
                values: new object[] { 861.12114329448389, "Unbranded Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "cost", "name" },
                values: new object[] { 416.61165856169112, "Generic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "cost", "name" },
                values: new object[] { 83.185725814802552, "Handcrafted Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "cost", "name" },
                values: new object[] { 752.60609679884703, "Sleek Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.96452036000073, "Licensed Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "cost", "name" },
                values: new object[] { 705.12488406642501, "Practical Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "cost", "name" },
                values: new object[] { 924.60169112209473, "Small Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "cost", "name" },
                values: new object[] { 14.225114433197747, "Small Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "cost", "name" },
                values: new object[] { 223.0730917814663, "Incredible Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.61719143588425, "Refined Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "cost", "name" },
                values: new object[] { 998.11029093222317, "Unbranded Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "cost", "name" },
                values: new object[] { 29.699292864702869, "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "cost", "name" },
                values: new object[] { 614.6874638406905, "Incredible Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "cost", "name" },
                values: new object[] { 887.08156920428883, "Awesome Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "cost", "name" },
                values: new object[] { 9.1294180234599072, "Intelligent Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "cost", "name" },
                values: new object[] { 945.02654568328376, "Ergonomic Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.63462372135496, "Fantastic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.38611580547423, "Fantastic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "cost", "name" },
                values: new object[] { 67.65579005996571, "Refined Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "cost", "name" },
                values: new object[] { 86.182047098817762, "Ergonomic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "cost", "name" },
                values: new object[] { 738.95176285641014, "Ergonomic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "cost", "name" },
                values: new object[] { 226.93417456406019, "Incredible Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "cost", "name" },
                values: new object[] { 615.82063397127047, "Incredible Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "cost", "name" },
                values: new object[] { 207.9133057325763, "Licensed Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "cost", "name" },
                values: new object[] { 184.788698300032, "Awesome Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "cost", "name" },
                values: new object[] { 355.40322753486845, "Rustic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "cost", "name" },
                values: new object[] { 194.37382910564412, "Practical Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "cost", "name" },
                values: new object[] { 834.21008026284119, "Small Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "cost", "name" },
                values: new object[] { 123.84377717668575, "Practical Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.36609783273889, "Handcrafted Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "cost", "name" },
                values: new object[] { 268.62013796167207, "Incredible Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.92483527576246, "Licensed Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "cost", "name" },
                values: new object[] { 669.91585345212059, "Intelligent Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "cost", "name" },
                values: new object[] { 84.408804805227973, "Tasty Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "cost", "name" },
                values: new object[] { 79.780325274082358, "Ergonomic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "cost", "name" },
                values: new object[] { 69.714066149301047, "Ergonomic Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.84095212679324, "Generic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "cost", "name" },
                values: new object[] { 108.33046298453785, "Handcrafted Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "cost", "name" },
                values: new object[] { 151.23488167819164, "Tasty Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.630441064040113, "Tasty Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "cost", "name" },
                values: new object[] { 499.23071350837273, "Generic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.69085128404652, "Rustic Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.23533960087383, "Intelligent Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "cost", "name" },
                values: new object[] { 146.69518186902445, "Practical Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "cost", "name" },
                values: new object[] { 36.095743693992119, "Handcrafted Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "cost", "name" },
                values: new object[] { 569.92141780590305, "Tasty Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "cost", "name" },
                values: new object[] { 579.9356476885074, "Ergonomic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "cost", "name" },
                values: new object[] { 333.14008944820358, "Rustic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "cost", "name" },
                values: new object[] { 90.419315600669464, "Fantastic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "cost", "name" },
                values: new object[] { 479.08053790682311, "Small Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "cost", "name" },
                values: new object[] { 769.08185658969728, "Handcrafted Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "cost", "name" },
                values: new object[] { 428.95815886080379, "Practical Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "cost", "name" },
                values: new object[] { 746.9918707984541, "Intelligent Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "cost", "name" },
                values: new object[] { 796.86491528694523, "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "cost", "name" },
                values: new object[] { 883.69899155805149, "Tasty Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "cost", "name" },
                values: new object[] { 834.30002243288845, "Refined Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.59201508121669, "Licensed Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "cost", "name" },
                values: new object[] { 964.66418479879405, "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.8869321277142, "Gorgeous Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "cost", "name" },
                values: new object[] { 73.971151439904006, "Awesome Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "cost", "name" },
                values: new object[] { 183.76003414806218, "Generic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "cost", "name" },
                values: new object[] { 597.81916790799426, "Refined Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "cost", "name" },
                values: new object[] { 371.92483654568002, "Rustic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "cost", "name" },
                values: new object[] { 999.14699020868545, "Intelligent Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "cost", "name" },
                values: new object[] { 27.800325295806367, "Generic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "cost", "name" },
                values: new object[] { 921.51197647139566, "Ergonomic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "cost", "name" },
                values: new object[] { 264.05174922295294, "Incredible Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "cost", "name" },
                values: new object[] { 726.17443472328046, "Practical Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "cost", "name" },
                values: new object[] { 415.79559966295182, "Small Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "cost", "name" },
                values: new object[] { 923.70080264938554, "Rustic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "cost", "name" },
                values: new object[] { 338.38102340022573, "Sleek Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "cost", "name" },
                values: new object[] { 694.63541066714822, "Gorgeous Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "cost", "name" },
                values: new object[] { 515.64465039057927, "Awesome Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "cost", "name" },
                values: new object[] { 391.80612022305456, "Refined Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "cost", "name" },
                values: new object[] { 875.89828037304335, "Licensed Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "cost", "name" },
                values: new object[] { 486.9543838478034, "Licensed Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "cost", "name" },
                values: new object[] { 930.9010918824149, "Fantastic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "cost", "name" },
                values: new object[] { 938.30226353385774, "Handmade Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "cost", "name" },
                values: new object[] { 881.09105535243771, "Practical Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "cost", "name" },
                values: new object[] { 95.08212940292681, "Intelligent Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "cost", "name" },
                values: new object[] { 26.110966224299705, "Awesome Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "cost", "name" },
                values: new object[] { 223.72929686547783, "Sleek Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "cost", "name" },
                values: new object[] { 270.41255597691367, "Handmade Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "cost", "name" },
                values: new object[] { 94.905000136946697, "Tasty Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.12147336285071, "Handmade Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.00188768548384, "Tasty Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "cost", "name" },
                values: new object[] { 560.59723923488343, "Unbranded Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.27482789938801, "Licensed Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "cost", "name" },
                values: new object[] { 265.22856081762541, "Ergonomic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.60451123596664, "Small Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "cost", "name" },
                values: new object[] { 974.07934991133493, "Intelligent Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "cost", "name" },
                values: new object[] { 479.05813221062414, "Practical Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "cost", "name" },
                values: new object[] { 701.77782447049503, "Fantastic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "cost", "name" },
                values: new object[] { 158.50565447237923, "Handmade Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "cost", "name" },
                values: new object[] { 835.41765294052459, "Handcrafted Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.16740835631757, "Generic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "cost", "name" },
                values: new object[] { 961.39390799346074, "Generic Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "cost", "name" },
                values: new object[] { 114.54632294880334, "Awesome Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "cost", "name" },
                values: new object[] { 831.21807238790109, "Intelligent Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.81115066628962, "Fantastic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "cost", "name" },
                values: new object[] { 779.41811824463684, "Incredible Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "cost", "name" },
                values: new object[] { 923.97050473684169, "Awesome Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "cost", "name" },
                values: new object[] { 180.11077242270366, "Handcrafted Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "cost", "name" },
                values: new object[] { 41.166551883663409, "Small Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "cost", "name" },
                values: new object[] { 440.59141484540584, "Practical Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "cost", "name" },
                values: new object[] { 534.3358501233464, "Gorgeous Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "cost", "name" },
                values: new object[] { 881.09053856700598, "Tasty Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.04341763579578, "Refined Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "cost", "name" },
                values: new object[] { 843.8344618714849, "Refined Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.75307539839127, "Rustic Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "cost", "name" },
                values: new object[] { 635.84106997038782, "Incredible Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "cost", "name" },
                values: new object[] { 267.66984023143243, "Small Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "cost", "name" },
                values: new object[] { 340.15419989700996, "Licensed Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "cost", "name" },
                values: new object[] { 29.427164941878999, "Handmade Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.21689842014666, "Handcrafted Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "cost", "name" },
                values: new object[] { 765.31389371119337, "Small Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "cost", "name" },
                values: new object[] { 114.02288047208684, "Small Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "cost", "name" },
                values: new object[] { 888.98863731229255, "Licensed Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.0161640118225, "Refined Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "cost", "name" },
                values: new object[] { 751.240972313263, "Refined Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.821819023803748, "Gorgeous Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "cost", "name" },
                values: new object[] { 490.61505322149759, "Intelligent Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "cost", "name" },
                values: new object[] { 15.763815189543584, "Intelligent Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.90426804448424, "Awesome Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "cost", "name" },
                values: new object[] { 935.07571645601877, "Incredible Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "cost", "name" },
                values: new object[] { 557.82674178679486, "Unbranded Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "cost", "name" },
                values: new object[] { 338.55650257414521, "Tasty Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "cost", "name" },
                values: new object[] { 399.86366246156666, "Fantastic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "cost", "name" },
                values: new object[] { 953.57672391117512, "Practical Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "cost", "name" },
                values: new object[] { 511.31066653137526, "Incredible Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "cost", "name" },
                values: new object[] { 136.77891567799045, "Incredible Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "cost", "name" },
                values: new object[] { 862.77295749740949, "Gorgeous Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "cost", "name" },
                values: new object[] { 602.87650143942346, "Rustic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "cost", "name" },
                values: new object[] { 669.04081121531317, "Tasty Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.65797694973071, "Handmade Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "cost", "name" },
                values: new object[] { 458.34833463805978, "Refined Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "cost", "name" },
                values: new object[] { 335.36868350411333, "Awesome Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "cost", "name" },
                values: new object[] { 814.15189132167689, "Unbranded Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.14581249098228, "Incredible Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "cost", "name" },
                values: new object[] { 809.84108586839181, "Handmade Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "cost", "name" },
                values: new object[] { 760.3569351355618, "Sleek Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "cost", "name" },
                values: new object[] { 621.68673189374795, "Incredible Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "cost", "name" },
                values: new object[] { 254.75372657563435, "Small Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "cost", "name" },
                values: new object[] { 694.43202934636349, "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "cost", "name" },
                values: new object[] { 316.47647867159839, "Practical Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.32009572423743, "Generic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "cost", "name" },
                values: new object[] { 897.54477398539518, "Generic Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "cost", "name" },
                values: new object[] { 808.14303692549208, "Practical Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "cost", "name" },
                values: new object[] { 469.26914478597291, "Awesome Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "cost", "name" },
                values: new object[] { 726.17192673924671, "Handmade Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "cost", "name" },
                values: new object[] { 482.76730893874338, "Awesome Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "cost", "name" },
                values: new object[] { 428.53547521083811, "Practical Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "cost", "name" },
                values: new object[] { 907.00944677277198, "Unbranded Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "cost", "name" },
                values: new object[] { 742.51251551942039, "Awesome Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "cost", "name" },
                values: new object[] { 781.99414995491782, "Generic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "cost", "name" },
                values: new object[] { 197.41466548367222, "Sleek Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.71592805665676, "Refined Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.92530045910075, "Ergonomic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.702303149226, "Refined Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "cost", "name" },
                values: new object[] { 887.75769125056695, "Awesome Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "cost", "name" },
                values: new object[] { 578.43204122649865, "Handmade Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "cost", "name" },
                values: new object[] { 650.95478613558817, "Incredible Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "cost", "name" },
                values: new object[] { 487.23206404857825, "Refined Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "cost", "name" },
                values: new object[] { 862.99010965461923, "Intelligent Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "cost", "name" },
                values: new object[] { 833.07056912133976, "Intelligent Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "cost", "name" },
                values: new object[] { 53.249542807751325, "Incredible Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.97081600128831, "Fantastic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "cost", "name" },
                values: new object[] { 387.78400616962972, "Fantastic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "cost", "name" },
                values: new object[] { 837.17906922011412, "Practical Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.49719495535084, "Rustic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.13266959071643, "Fantastic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "cost", "name" },
                values: new object[] { 593.01924505211582, "Tasty Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "cost", "name" },
                values: new object[] { 326.6830719353988, "Rustic Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.97056433271723, "Practical Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "cost", "name" },
                values: new object[] { 213.84133051784511, "Practical Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "cost", "name" },
                values: new object[] { 86.353990233284094, "Tasty Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "cost", "name" },
                values: new object[] { 450.60518894371023, "Ergonomic Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "cost", "name" },
                values: new object[] { 543.57751434887848, "Rustic Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "cost", "name" },
                values: new object[] { 749.98468342782519, "Handmade Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "cost", "name" },
                values: new object[] { 428.72135547748172, "Fantastic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "cost", "name" },
                values: new object[] { 737.5144537020434, "Practical Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.96584670153425, "Generic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "cost", "name" },
                values: new object[] { 62.578500123636957, "Generic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "cost", "name" },
                values: new object[] { 731.32326435739549, "Unbranded Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "cost", "name" },
                values: new object[] { 883.75330834188048, "Generic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "cost", "name" },
                values: new object[] { 821.38883847132274, "Sleek Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "cost", "name" },
                values: new object[] { 930.80180224248909, "Fantastic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "cost", "name" },
                values: new object[] { 555.14465784718641, "Rustic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "cost", "name" },
                values: new object[] { 203.75610083778736, "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "cost", "name" },
                values: new object[] { 357.85136052294752, "Generic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "cost", "name" },
                values: new object[] { 616.94144469493153, "Unbranded Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "cost", "name" },
                values: new object[] { 751.81184287844042, "Awesome Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.9766287204603, "Refined Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "cost", "name" },
                values: new object[] { 809.67803909790541, "Handmade Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "cost", "name" },
                values: new object[] { 348.93718494878124, "Sleek Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "cost", "name" },
                values: new object[] { 10.219109468555979, "Intelligent Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "cost", "name" },
                values: new object[] { 453.68750949622626, "Unbranded Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "cost", "name" },
                values: new object[] { 425.11597263675725, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "cost", "name" },
                values: new object[] { 77.750379971116317, "Gorgeous Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "cost", "name" },
                values: new object[] { 320.89300293092117, "Practical Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.37504405567375, "Handmade Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "cost", "name" },
                values: new object[] { 519.21201153506695, "Tasty Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "cost", "name" },
                values: new object[] { 602.89792782501752, "Handcrafted Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "cost", "name" },
                values: new object[] { 213.61848493807949, "Ergonomic Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "cost", "name" },
                values: new object[] { 637.43598706973034, "Handmade Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "cost", "name" },
                values: new object[] { 134.48393570188787, "Generic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "cost", "name" },
                values: new object[] { 889.12397724844323, "Small Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.343365028155496, "Gorgeous Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "cost", "name" },
                values: new object[] { 865.20022402549091, "Sleek Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "cost", "name" },
                values: new object[] { 822.25664639305387, "Awesome Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "cost", "name" },
                values: new object[] { 895.16263894192934, "Handcrafted Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "cost", "name" },
                values: new object[] { 335.9719121394499, "Sleek Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "cost", "name" },
                values: new object[] { 524.39798209059052, "Rustic Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "cost", "name" },
                values: new object[] { 160.02544985651161, "Handmade Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "cost", "name" },
                values: new object[] { 335.21335948147436, "Incredible Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.13776120604007, "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "cost", "name" },
                values: new object[] { 793.91701845613943, "Sleek Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "cost", "name" },
                values: new object[] { 158.04111933855475, "Unbranded Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "cost", "name" },
                values: new object[] { 410.00857123182908, "Gorgeous Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "cost", "name" },
                values: new object[] { 160.12292834623258, "Ergonomic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.45746225205812, "Awesome Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "cost", "name" },
                values: new object[] { 286.39267305052874, "Handmade Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.971389277418929, "Sleek Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "cost", "name" },
                values: new object[] { 293.2771921374092, "Ergonomic Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "cost", "name" },
                values: new object[] { 603.00656523497832, "Handcrafted Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "cost", "name" },
                values: new object[] { 291.89557938648511, "Unbranded Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.15981265934261, "Rustic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "cost", "name" },
                values: new object[] { 659.23817796258663, "Licensed Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "cost", "name" },
                values: new object[] { 12.883133992757411, "Handmade Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "cost", "name" },
                values: new object[] { 51.809498780958798, "Sleek Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "cost", "name" },
                values: new object[] { 878.31380483854355, "Small Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "cost", "name" },
                values: new object[] { 711.8107787941866, "Gorgeous Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.51442596745619, "Incredible Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "cost", "name" },
                values: new object[] { 659.34603757740319, "Intelligent Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "cost", "name" },
                values: new object[] { 194.87559445757577, "Rustic Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "cost", "name" },
                values: new object[] { 981.34912527571259, "Ergonomic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "cost", "name" },
                values: new object[] { 20.801652597502066, "Generic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "cost", "name" },
                values: new object[] { 906.61459894566178, "Fantastic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "cost", "name" },
                values: new object[] { 53.32520202497642, "Incredible Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "cost", "name" },
                values: new object[] { 164.77880711898939, "Unbranded Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "cost", "name" },
                values: new object[] { 478.88366759981272, "Sleek Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "cost", "name" },
                values: new object[] { 949.72106827544349, "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "cost", "name" },
                values: new object[] { 469.552756988429, "Practical Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.93353952863589, "Tasty Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "cost", "name" },
                values: new object[] { 640.23874405543643, "Fantastic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "cost", "name" },
                values: new object[] { 872.03052877977234, "Rustic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "cost", "name" },
                values: new object[] { 497.95136430258373, "Unbranded Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "cost", "name" },
                values: new object[] { 672.49632787666474, "Incredible Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "cost", "name" },
                values: new object[] { 391.82186911120272, "Licensed Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "cost", "name" },
                values: new object[] { 9.4553652499815648, "Handcrafted Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.90762538563064, "Sleek Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "cost", "name" },
                values: new object[] { 452.70131676856067, "Handmade Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "cost", "name" },
                values: new object[] { 918.54591735204565, "Handmade Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "cost", "name" },
                values: new object[] { 981.84431158594634, "Handcrafted Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "cost", "name" },
                values: new object[] { 316.94780790800854, "Licensed Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.01286767517627, "Licensed Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "cost", "name" },
                values: new object[] { 212.28973031139273, "Fantastic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "cost", "name" },
                values: new object[] { 429.19842722332743, "Gorgeous Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "cost", "name" },
                values: new object[] { 452.99675063743808, "Unbranded Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "cost", "name" },
                values: new object[] { 557.31678727563258, "Awesome Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "cost", "name" },
                values: new object[] { 110.53233175325727, "Rustic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "cost", "name" },
                values: new object[] { 347.63861770527052, "Tasty Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "cost", "name" },
                values: new object[] { 939.39825036023808, "Intelligent Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.536048008003625, "Incredible Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "cost", "name" },
                values: new object[] { 819.00365396002746, "Sleek Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "cost", "name" },
                values: new object[] { 362.08373123254881, "Rustic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "cost", "name" },
                values: new object[] { 830.66461701163882, "Licensed Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "cost", "name" },
                values: new object[] { 562.72956404888737, "Sleek Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "cost", "name" },
                values: new object[] { 291.87722023873272, "Awesome Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "cost", "name" },
                values: new object[] { 267.32454134107337, "Awesome Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "cost", "name" },
                values: new object[] { 702.818233665668, "Rustic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "cost", "name" },
                values: new object[] { 442.28728710326135, "Awesome Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.92627118688239, "Handcrafted Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.71758649819704, "Handcrafted Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "cost", "name" },
                values: new object[] { 83.858496118435497, "Incredible Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "cost", "name" },
                values: new object[] { 443.90176941118727, "Practical Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "cost", "name" },
                values: new object[] { 358.88961663794652, "Tasty Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "cost", "name" },
                values: new object[] { 367.01879169767057, "Licensed Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "cost", "name" },
                values: new object[] { 591.02894277503572, "Practical Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "cost", "name" },
                values: new object[] { 705.76089117855372, "Rustic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "cost", "name" },
                values: new object[] { 727.74069074732029, "Intelligent Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "cost", "name" },
                values: new object[] { 520.48552168753849, "Practical Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "cost", "name" },
                values: new object[] { 805.3100237082723, "Sleek Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "cost", "name" },
                values: new object[] { 587.64616735700406, "Ergonomic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "cost", "name" },
                values: new object[] { 871.54572276347574, "Ergonomic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "cost", "name" },
                values: new object[] { 876.16298230751045, "Sleek Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "cost", "name" },
                values: new object[] { 781.43748793144994, "Generic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "cost", "name" },
                values: new object[] { 918.98709293931279, "Awesome Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "cost", "name" },
                values: new object[] { 587.18033889238779, "Ergonomic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "cost", "name" },
                values: new object[] { 571.02912734548329, "Fantastic Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.58860152291697, "Practical Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "cost", "name" },
                values: new object[] { 220.23039889034592, "Generic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "cost", "name" },
                values: new object[] { 398.87990383247546, "Small Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.82968019989505, "Sleek Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "cost", "name" },
                values: new object[] { 110.02798900652814, "Tasty Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "cost", "name" },
                values: new object[] { 528.21747293466558, "Refined Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "cost", "name" },
                values: new object[] { 319.91689084316192, "Licensed Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.78212133188833, "Handmade Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "cost", "name" },
                values: new object[] { 637.95020109088262, "Handcrafted Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "cost", "name" },
                values: new object[] { 628.05443961499054, "Rustic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "cost", "name" },
                values: new object[] { 328.05287236082961, "Unbranded Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "cost", "name" },
                values: new object[] { 873.66780413997367, "Handcrafted Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "cost", "name" },
                values: new object[] { 120.47669335136754, "Tasty Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "cost", "name" },
                values: new object[] { 76.553467033673485, "Handcrafted Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "cost", "name" },
                values: new object[] { 430.52470860276492, "Small Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.21242890563485, "Generic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "cost", "name" },
                values: new object[] { 848.52049171470253, "Small Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.1727618962055, "Generic Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "cost", "name" },
                values: new object[] { 97.834939424211441, "Handmade Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "cost", "name" },
                values: new object[] { 407.16460069278929, "Rustic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "cost", "name" },
                values: new object[] { 989.75228382842909, "Unbranded Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "cost", "name" },
                values: new object[] { 412.99600832498561, "Intelligent Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "cost", "name" },
                values: new object[] { 333.38910807479095, "Handmade Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.151800851549524, "Rustic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "cost", "name" },
                values: new object[] { 330.2993519763549, "Practical Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "cost", "name" },
                values: new object[] { 729.94826953404379, "Intelligent Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "cost", "name" },
                values: new object[] { 997.35719989519021, "Sleek Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "cost", "name" },
                values: new object[] { 93.723116645471265, "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "cost", "name" },
                values: new object[] { 579.1726500165704, "Refined Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "cost", "name" },
                values: new object[] { 35.901674959756555, "Unbranded Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "cost", "name" },
                values: new object[] { 27.378828218819255, "Unbranded Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "cost", "name" },
                values: new object[] { 409.08499510875436, "Generic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "cost", "name" },
                values: new object[] { 359.29008000058974, "Fantastic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "cost", "name" },
                values: new object[] { 582.0430165522074, "Refined Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "cost", "name" },
                values: new object[] { 628.98910967206984, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "cost", "name" },
                values: new object[] { 884.70151396541189, "Fantastic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "cost", "name" },
                values: new object[] { 731.74422043478614, "Incredible Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "cost", "name" },
                values: new object[] { 249.12267995492056, "Ergonomic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.37843142046958, "Gorgeous Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "cost", "name" },
                values: new object[] { 154.50056063916961, "Handcrafted Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "cost", "name" },
                values: new object[] { 706.9858459391819, "Small Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "cost", "name" },
                values: new object[] { 467.05854201652846, "Handmade Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "cost", "name" },
                values: new object[] { 984.90251418413538, "Licensed Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "cost", "name" },
                values: new object[] { 921.13693911218741, "Awesome Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "cost", "name" },
                values: new object[] { 488.74990422156901, "Gorgeous Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "cost", "name" },
                values: new object[] { 246.711939302145, "Tasty Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "cost", "name" },
                values: new object[] { 358.64595348766716, "Fantastic Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "cost", "name" },
                values: new object[] { 73.416268834781903, "Incredible Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "cost", "name" },
                values: new object[] { 691.14530056805063, "Unbranded Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "cost", "name" },
                values: new object[] { 877.57968378259773, "Intelligent Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "cost", "name" },
                values: new object[] { 12.378869668252143, "Handmade Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "cost", "name" },
                values: new object[] { 547.14148478239144, "Small Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "cost", "name" },
                values: new object[] { 699.84786041437133, "Rustic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.03501601116471, "Incredible Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "cost", "name" },
                values: new object[] { 60.611271153334684, "Small Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "cost", "name" },
                values: new object[] { 310.51407222207894, "Tasty Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "cost", "name" },
                values: new object[] { 828.0998049739685, "Ergonomic Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "cost", "name" },
                values: new object[] { 259.06248560126897, "Handcrafted Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "cost", "name" },
                values: new object[] { 370.27072819581917, "Practical Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "cost", "name" },
                values: new object[] { 303.02695196665837, "Awesome Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "cost", "name" },
                values: new object[] { 175.93956574001078, "Sleek Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "cost", "name" },
                values: new object[] { 380.16779824151723, "Tasty Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "cost", "name" },
                values: new object[] { 929.57066951946933, "Refined Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.14531623511982, "Practical Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "cost", "name" },
                values: new object[] { 644.19156530322994, "Small Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "cost", "name" },
                values: new object[] { 801.58757026382989, "Ergonomic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "cost", "name" },
                values: new object[] { 597.30910214391372, "Licensed Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "cost", "name" },
                values: new object[] { 753.30004975132772, "Fantastic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "cost", "name" },
                values: new object[] { 410.9756230283478, "Handmade Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.57816768258175, "Incredible Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "cost", "name" },
                values: new object[] { 922.37436150148937, "Generic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.86067343837033, "Refined Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.09722190647636, "Awesome Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "cost", "name" },
                values: new object[] { 482.50561997970948, "Licensed Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "cost", "name" },
                values: new object[] { 291.23371895930882, "Awesome Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "cost", "name" },
                values: new object[] { 183.61441632101204, "Intelligent Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "cost", "name" },
                values: new object[] { 838.44642192418337, "Awesome Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "cost", "name" },
                values: new object[] { 799.9926524605421, "Unbranded Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "cost", "name" },
                values: new object[] { 757.13207086975763, "Licensed Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "cost", "name" },
                values: new object[] { 675.48254014057829, "Rustic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "cost", "name" },
                values: new object[] { 306.66669808305602, "Awesome Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "cost", "name" },
                values: new object[] { 274.55520575455961, "Rustic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.14714566161956, "Awesome Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.82113161302249, "Small Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "cost", "name" },
                values: new object[] { 986.67405815953487, "Intelligent Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "cost", "name" },
                values: new object[] { 330.48957589679475, "Sleek Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "cost", "name" },
                values: new object[] { 295.46354729546789, "Unbranded Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "cost", "name" },
                values: new object[] { 81.939618935488269, "Unbranded Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.61938088109315, "Sleek Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "cost", "name" },
                values: new object[] { 472.62116711154579, "Handcrafted Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "cost", "name" },
                values: new object[] { 420.84305181944643, "Small Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "cost", "name" },
                values: new object[] { 575.42372021085521, "Practical Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "cost", "name" },
                values: new object[] { 435.6180362977862, "Intelligent Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "cost", "name" },
                values: new object[] { 769.42896167480706, "Ergonomic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.64642767928649, "Ergonomic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "cost", "name" },
                values: new object[] { 74.05946775818586, "Handmade Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "cost", "name" },
                values: new object[] { 842.22684559787444, "Unbranded Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "cost", "name" },
                values: new object[] { 532.61504338577583, "Tasty Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "cost", "name" },
                values: new object[] { 936.68891633672899, "Gorgeous Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "cost", "name" },
                values: new object[] { 646.13970194751539, "Rustic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.37996068343705, "Tasty Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "cost", "name" },
                values: new object[] { 807.76388077796025, "Licensed Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.83876467268442, "Fantastic Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "cost", "name" },
                values: new object[] { 468.2452296666425, "Sleek Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "cost", "name" },
                values: new object[] { 828.93786822815605, "Practical Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "cost", "name" },
                values: new object[] { 630.03787898061478, "Practical Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "cost", "name" },
                values: new object[] { 225.33546508455612, "Rustic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "cost", "name" },
                values: new object[] { 162.08855351514592, "Handmade Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "cost", "name" },
                values: new object[] { 602.23729726975432, "Rustic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "cost", "name" },
                values: new object[] { 987.33240389967523, "Small Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.64714779258736, "Small Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "cost", "name" },
                values: new object[] { 346.63464179329344, "Generic Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.72457660815502, "Tasty Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "cost", "name" },
                values: new object[] { 339.54048729167295, "Sleek Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "cost", "name" },
                values: new object[] { 500.91722758653992, "Handmade Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "cost", "name" },
                values: new object[] { 565.27616188172181, "Gorgeous Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "cost", "name" },
                values: new object[] { 141.19269567303706, "Sleek Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.18859297324155, "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "cost", "name" },
                values: new object[] { 748.41898094663043, "Licensed Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "cost", "name" },
                values: new object[] { 528.64889897468709, "Sleek Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "cost", "name" },
                values: new object[] { 547.21617136891746, "Unbranded Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "cost", "name" },
                values: new object[] { 890.97373601480763, "Sleek Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.06835107341328, "Gorgeous Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "cost", "name" },
                values: new object[] { 633.60853803486361, "Rustic Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "cost", "name" },
                values: new object[] { 911.37211347774075, "Intelligent Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "cost", "name" },
                values: new object[] { 669.50593669355851, "Tasty Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "cost", "name" },
                values: new object[] { 593.38090273228636, "Incredible Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "cost", "name" },
                values: new object[] { 643.68209787867647, "Generic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "cost", "name" },
                values: new object[] { 879.06518040917047, "Incredible Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "cost", "name" },
                values: new object[] { 146.50257712444116, "Licensed Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "cost", "name" },
                values: new object[] { 994.73890647256394, "Tasty Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.23738745898356, "Refined Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.11741097411101, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "cost", "name" },
                values: new object[] { 910.5548387604432, "Refined Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "cost", "name" },
                values: new object[] { 573.22183700910671, "Generic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.44933870423966, "Incredible Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.4256977753297, "Refined Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "cost", "name" },
                values: new object[] { 509.45573664991167, "Gorgeous Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.126666713752719, "Intelligent Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "cost", "name" },
                values: new object[] { 871.43130452535502, "Tasty Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "cost", "name" },
                values: new object[] { 467.38863214204741, "Licensed Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.61960938176833, "Tasty Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "cost", "name" },
                values: new object[] { 190.12619749670313, "Licensed Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "cost", "name" },
                values: new object[] { 650.91260529353121, "Ergonomic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.32105115810646, "Intelligent Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "cost", "name" },
                values: new object[] { 219.52157666046656, "Sleek Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "cost", "name" },
                values: new object[] { 174.51832358222327, "Incredible Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "cost", "name" },
                values: new object[] { 624.37224425344527, "Unbranded Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "cost", "name" },
                values: new object[] { 275.6841859084488, "Handmade Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "cost", "name" },
                values: new object[] { 468.05732831020384, "Rustic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "cost", "name" },
                values: new object[] { 562.38953991494486, "Incredible Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "cost", "name" },
                values: new object[] { 779.93438177135158, "Tasty Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "cost", "name" },
                values: new object[] { 77.855645752784881, "Gorgeous Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.6587654209128, "Licensed Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.67651206491166, "Intelligent Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "cost", "name" },
                values: new object[] { 797.21000538002818, "Unbranded Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "cost", "name" },
                values: new object[] { 5.2121602264504645, "Practical Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "cost", "name" },
                values: new object[] { 710.52837769283065, "Small Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "cost", "name" },
                values: new object[] { 172.6594730719379, "Rustic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "cost", "name" },
                values: new object[] { 905.11670377216444, "Small Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "cost", "name" },
                values: new object[] { 56.98804736110251, "Ergonomic Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "cost", "name" },
                values: new object[] { 740.55618200197762, "Intelligent Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "cost", "name" },
                values: new object[] { 183.97053337526503, "Practical Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "cost", "name" },
                values: new object[] { 446.52164350159529, "Practical Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "cost", "name" },
                values: new object[] { 670.68210664991636, "Handcrafted Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "cost", "name" },
                values: new object[] { 574.84993462866362, "Gorgeous Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "cost", "name" },
                values: new object[] { 12.250356088999711, "Licensed Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "cost", "name" },
                values: new object[] { 219.98014981743594, "Sleek Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "cost", "name" },
                values: new object[] { 543.66754827136538, "Refined Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "cost", "name" },
                values: new object[] { 143.23011106481991, "Practical Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "cost", "name" },
                values: new object[] { 38.773792783320104, "Small Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "cost", "name" },
                values: new object[] { 434.71501367048131, "Tasty Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "cost", "name" },
                values: new object[] { 739.56380571868249, "Awesome Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "cost", "name" },
                values: new object[] { 537.45545858018068, "Sleek Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "cost", "name" },
                values: new object[] { 95.660556560921279, "Sleek Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.431455783742351, "Handcrafted Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.22559960810256, "Fantastic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "cost", "name" },
                values: new object[] { 770.91985318228296, "Unbranded Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.40658876793191, "Handcrafted Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "cost", "name" },
                values: new object[] { 508.31027813066765, "Unbranded Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "cost", "name" },
                values: new object[] { 561.85998713782294, "Sleek Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "cost", "name" },
                values: new object[] { 93.318601420151623, "Refined Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "cost", "name" },
                values: new object[] { 147.21503854695212, "Rustic Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "cost", "name" },
                values: new object[] { 307.90104830221981, "Intelligent Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "cost", "name" },
                values: new object[] { 211.00917138500756, "Unbranded Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "cost", "name" },
                values: new object[] { 603.65989210196472, "Ergonomic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "cost", "name" },
                values: new object[] { 194.4742073838834, "Rustic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "cost", "name" },
                values: new object[] { 371.80573444630716, "Gorgeous Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "cost", "name" },
                values: new object[] { 458.46732368437637, "Small Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "cost", "name" },
                values: new object[] { 233.07513741668976, "Handcrafted Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.89129986941668, "Ergonomic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "cost", "name" },
                values: new object[] { 998.50821878405509, "Incredible Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.93391563529826, "Refined Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "cost", "name" },
                values: new object[] { 297.90894181077448, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "cost", "name" },
                values: new object[] { 909.00299910699709, "Unbranded Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "cost", "name" },
                values: new object[] { 865.74727875202564, "Intelligent Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "cost", "name" },
                values: new object[] { 526.47052815926543, "Practical Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.78915188934252, "Unbranded Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "cost", "name" },
                values: new object[] { 579.35607752356566, "Incredible Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "cost", "name" },
                values: new object[] { 883.91421250602843, "Ergonomic Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.96124292792967, "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.27492425733965, "Intelligent Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "cost", "name" },
                values: new object[] { 174.34575379079075, "Licensed Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "cost", "name" },
                values: new object[] { 907.23730697759004, "Incredible Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.3460205861843, "Practical Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "cost", "name" },
                values: new object[] { 39.616271785204695, "Tasty Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "cost", "name" },
                values: new object[] { 597.79222588065511, "Handmade Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "cost", "name" },
                values: new object[] { 843.44698528432832, "Tasty Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.95401618965684, "Gorgeous Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "cost", "name" },
                values: new object[] { 661.72231660968873, "Refined Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "cost", "name" },
                values: new object[] { 574.98558463200857, "Rustic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "cost", "name" },
                values: new object[] { 487.92480805662132, "Handcrafted Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.78738998890151, "Incredible Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "cost", "name" },
                values: new object[] { 118.2078894640137, "Incredible Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "cost", "name" },
                values: new object[] { 823.47610398085521, "Handcrafted Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.930872069078049, "Refined Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "cost", "name" },
                values: new object[] { 756.32687350249614, "Generic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.67935932909444, "Practical Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "cost", "name" },
                values: new object[] { 550.77169244661684, "Rustic Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.12026274437233, "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "cost", "name" },
                values: new object[] { 935.51208029264444, "Ergonomic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "cost", "name" },
                values: new object[] { 94.383035246538995, "Handcrafted Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "cost", "name" },
                values: new object[] { 562.45564031781601, "Ergonomic Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "cost", "name" },
                values: new object[] { 166.52059517965498, "Licensed Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "cost", "name" },
                values: new object[] { 585.58822212390112, "Awesome Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "cost", "name" },
                values: new object[] { 526.15872409658778, "Incredible Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.3357708717881, "Unbranded Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "cost", "name" },
                values: new object[] { 721.72609365804419, "Handmade Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "cost", "name" },
                values: new object[] { 385.30685414545155, "Unbranded Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "cost", "name" },
                values: new object[] { 674.80727534745813, "Refined Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.63917421924538, "Generic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "cost", "name" },
                values: new object[] { 26.661579504093773, "Handmade Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.15195491715679, "Sleek Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "cost", "name" },
                values: new object[] { 279.28261305243228, "Intelligent Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.68225888586619, "Refined Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "cost", "name" },
                values: new object[] { 676.0645505557352, "Handmade Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.82184649617614, "Ergonomic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "cost", "name" },
                values: new object[] { 735.11964031025616, "Handcrafted Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "cost", "name" },
                values: new object[] { 559.4923544243627, "Handmade Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "cost", "name" },
                values: new object[] { 844.16489775884838, "Practical Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "cost", "name" },
                values: new object[] { 756.13274744184139, "Intelligent Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "cost", "name" },
                values: new object[] { 967.31136225339196, "Practical Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "cost", "name" },
                values: new object[] { 691.74046838994445, "Awesome Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "cost", "name" },
                values: new object[] { 438.84843422292954, "Fantastic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "cost", "name" },
                values: new object[] { 315.66355613696112, "Refined Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "cost", "name" },
                values: new object[] { 800.81476747008594, "Incredible Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "cost", "name" },
                values: new object[] { 267.31682104975249, "Awesome Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "cost", "name" },
                values: new object[] { 455.90564559635038, "Rustic Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "cost", "name" },
                values: new object[] { 191.38897668555333, "Refined Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.67030239234566, "Intelligent Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "cost", "name" },
                values: new object[] { 382.09738591314954, "Intelligent Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "cost", "name" },
                values: new object[] { 170.37589647062376, "Incredible Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "cost", "name" },
                values: new object[] { 110.17120997418562, "Practical Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "cost", "name" },
                values: new object[] { 769.8770353700038, "Tasty Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.95272565506397, "Practical Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "cost", "name" },
                values: new object[] { 534.89004473638477, "Handmade Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "cost", "name" },
                values: new object[] { 430.27754120782475, "Small Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "cost", "name" },
                values: new object[] { 946.56704499521834, "Licensed Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.42675720106377, "Unbranded Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "cost", "name" },
                values: new object[] { 317.21022868178898, "Tasty Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "cost", "name" },
                values: new object[] { 898.38853882924093, "Ergonomic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "cost", "name" },
                values: new object[] { 534.08186136027552, "Unbranded Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "cost", "name" },
                values: new object[] { 158.74626018123439, "Generic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "cost", "name" },
                values: new object[] { 295.46922812112365, "Rustic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "cost", "name" },
                values: new object[] { 632.87596190230272, "Practical Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "cost", "name" },
                values: new object[] { 15.892287198500892, "Refined Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "cost", "name" },
                values: new object[] { 570.73220910246937, "Tasty Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.15636041932157, "Awesome Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "cost", "name" },
                values: new object[] { 179.26230091649856, "Handcrafted Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "cost", "name" },
                values: new object[] { 111.0337894247793, "Licensed Granite Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "cost", "name" },
                values: new object[] { 207.30952323722315, "Licensed Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "cost", "name" },
                values: new object[] { 566.48587663083561, "Rustic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "cost", "name" },
                values: new object[] { 303.07367667865475, "Unbranded Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "cost", "name" },
                values: new object[] { 97.158725821164182, "Gorgeous Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 940,
                columns: new[] { "cost", "name" },
                values: new object[] { 426.55049580509495, "Refined Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 941,
                columns: new[] { "cost", "name" },
                values: new object[] { 151.23985291539998, "Generic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 942,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.30965404809544, "Handcrafted Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 943,
                columns: new[] { "cost", "name" },
                values: new object[] { 92.55957400315782, "Small Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 944,
                columns: new[] { "cost", "name" },
                values: new object[] { 880.10923986555758, "Incredible Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 945,
                columns: new[] { "cost", "name" },
                values: new object[] { 422.22509307729297, "Unbranded Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 946,
                columns: new[] { "cost", "name" },
                values: new object[] { 135.12375008659299, "Handcrafted Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 947,
                columns: new[] { "cost", "name" },
                values: new object[] { 487.69308210954608, "Small Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 948,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.21060341063333, "Rustic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 949,
                columns: new[] { "cost", "name" },
                values: new object[] { 227.10000379312009, "Incredible Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 950,
                columns: new[] { "cost", "name" },
                values: new object[] { 69.163375901754449, "Gorgeous Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 951,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.60463113207663, "Awesome Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 952,
                columns: new[] { "cost", "name" },
                values: new object[] { 101.9385509461106, "Practical Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 953,
                columns: new[] { "cost", "name" },
                values: new object[] { 35.387012581719539, "Intelligent Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 954,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.71891184924402, "Handmade Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 955,
                columns: new[] { "cost", "name" },
                values: new object[] { 216.75888185509945, "Incredible Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 956,
                columns: new[] { "cost", "name" },
                values: new object[] { 298.59029323170392, "Sleek Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 957,
                columns: new[] { "cost", "name" },
                values: new object[] { 786.95953515374879, "Licensed Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 958,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.24403072025669, "Awesome Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 959,
                columns: new[] { "cost", "name" },
                values: new object[] { 218.15236678551935, "Fantastic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 960,
                columns: new[] { "cost", "name" },
                values: new object[] { 138.96706116393767, "Ergonomic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 961,
                columns: new[] { "cost", "name" },
                values: new object[] { 663.93718478475944, "Handcrafted Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 962,
                columns: new[] { "cost", "name" },
                values: new object[] { 492.27026835272142, "Small Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 963,
                columns: new[] { "cost", "name" },
                values: new object[] { 507.28144159359323, "Sleek Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 964,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.80469064160411, "Small Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 965,
                columns: new[] { "cost", "name" },
                values: new object[] { 13.453949258896504, "Fantastic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 966,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.96460530230604, "Tasty Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 967,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.20382476925579, "Incredible Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 968,
                columns: new[] { "cost", "name" },
                values: new object[] { 905.65732508075473, "Handmade Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 969,
                columns: new[] { "cost", "name" },
                values: new object[] { 946.16682110608247, "Gorgeous Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 970,
                columns: new[] { "cost", "name" },
                values: new object[] { 318.42398847946566, "Handcrafted Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 971,
                columns: new[] { "cost", "name" },
                values: new object[] { 4.5462605467288171, "Handcrafted Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 972,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.920249710576, "Awesome Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 973,
                columns: new[] { "cost", "name" },
                values: new object[] { 29.017817804850392, "Refined Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 974,
                columns: new[] { "cost", "name" },
                values: new object[] { 830.03528617832217, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 975,
                columns: new[] { "cost", "name" },
                values: new object[] { 86.657254335144785, "Practical Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 976,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.89653396733752, "Unbranded Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 977,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.70521354939603, "Practical Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 978,
                columns: new[] { "cost", "name" },
                values: new object[] { 624.11100351357311, "Ergonomic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 979,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.466760557633378, "Incredible Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 980,
                columns: new[] { "cost", "name" },
                values: new object[] { 310.36387258739575, "Rustic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 981,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.65271265646419, "Ergonomic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 982,
                columns: new[] { "cost", "name" },
                values: new object[] { 202.57010919830489, "Incredible Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 983,
                columns: new[] { "cost", "name" },
                values: new object[] { 631.02418107550409, "Generic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 984,
                columns: new[] { "cost", "name" },
                values: new object[] { 286.00644992622108, "Gorgeous Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 985,
                columns: new[] { "cost", "name" },
                values: new object[] { 752.15715648383332, "Practical Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 986,
                columns: new[] { "cost", "name" },
                values: new object[] { 191.77666121292535, "Fantastic Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 987,
                columns: new[] { "cost", "name" },
                values: new object[] { 100.86772196796663, "Unbranded Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 988,
                columns: new[] { "cost", "name" },
                values: new object[] { 909.63664209133151, "Sleek Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 989,
                columns: new[] { "cost", "name" },
                values: new object[] { 467.15802865691808, "Gorgeous Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 990,
                columns: new[] { "cost", "name" },
                values: new object[] { 886.23992175131229, "Gorgeous Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 991,
                columns: new[] { "cost", "name" },
                values: new object[] { 169.569173230225, "Handcrafted Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 992,
                columns: new[] { "cost", "name" },
                values: new object[] { 417.62718520435516, "Refined Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 993,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.37031232810989, "Practical Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 994,
                columns: new[] { "cost", "name" },
                values: new object[] { 410.28385687799783, "Handmade Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 995,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.65671608681714, "Handcrafted Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 996,
                columns: new[] { "cost", "name" },
                values: new object[] { 530.48175426117359, "Sleek Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 997,
                columns: new[] { "cost", "name" },
                values: new object[] { 870.8635221082103, "Gorgeous Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 998,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.31940636814022, "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 999,
                columns: new[] { "cost", "name" },
                values: new object[] { 82.905265292469693, "Unbranded Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1000,
                columns: new[] { "cost", "name" },
                values: new object[] { 418.19982761480946, "Licensed Steel Car" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.7543036082505, "Fantastic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cost", "name" },
                values: new object[] { 686.07251847882128, "Practical Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cost", "name" },
                values: new object[] { 759.91138385404781, "Generic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cost", "name" },
                values: new object[] { 944.78055681834087, "Tasty Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cost", "name" },
                values: new object[] { 338.77480062140762, "Practical Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cost", "name" },
                values: new object[] { 725.14167027254666, "Unbranded Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cost", "name" },
                values: new object[] { 822.41483442131755, "Unbranded Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.80799184921801, "Intelligent Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cost", "name" },
                values: new object[] { 408.64049974089318, "Fantastic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cost", "name" },
                values: new object[] { 154.35993070920352, "Handcrafted Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.50933479469762, "Intelligent Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cost", "name" },
                values: new object[] { 814.5709370252506, "Rustic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cost", "name" },
                values: new object[] { 196.19078097009321, "Intelligent Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cost", "name" },
                values: new object[] { 847.2767746738881, "Handcrafted Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.48559415312695, "Tasty Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cost", "name" },
                values: new object[] { 492.50984812555942, "Generic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cost", "name" },
                values: new object[] { 760.08612564143846, "Rustic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.54890725883001, "Licensed Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cost", "name" },
                values: new object[] { 887.45067410061165, "Tasty Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cost", "name" },
                values: new object[] { 943.87524784234483, "Incredible Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cost", "name" },
                values: new object[] { 126.95975113034338, "Handcrafted Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cost", "name" },
                values: new object[] { 597.67080847981833, "Gorgeous Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cost", "name" },
                values: new object[] { 249.61284873436361, "Gorgeous Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cost", "name" },
                values: new object[] { 116.53700151788345, "Fantastic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cost", "name" },
                values: new object[] { 954.05613110486775, "Gorgeous Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "cost", "name" },
                values: new object[] { 770.54964302938629, "Incredible Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "cost", "name" },
                values: new object[] { 868.85643995969986, "Fantastic Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "cost", "name" },
                values: new object[] { 86.676611824144857, "Handcrafted Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "cost", "name" },
                values: new object[] { 290.17013343230474, "Sleek Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "cost", "name" },
                values: new object[] { 801.26839118976045, "Handcrafted Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "cost", "name" },
                values: new object[] { 922.6909755688597, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "cost", "name" },
                values: new object[] { 965.61867012896118, "Sleek Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "cost", "name" },
                values: new object[] { 123.94145875025981, "Generic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "cost", "name" },
                values: new object[] { 651.43482295454112, "Licensed Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "cost", "name" },
                values: new object[] { 129.91093601204648, "Ergonomic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.63822216409835, "Sleek Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.356143949940094, "Awesome Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "cost", "name" },
                values: new object[] { 740.17019988295806, "Refined Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.80885004266042, "Licensed Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "cost", "name" },
                values: new object[] { 19.491479433991117, "Tasty Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "cost", "name" },
                values: new object[] { 169.83836115163294, "Practical Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "cost", "name" },
                values: new object[] { 493.54687985738116, "Handcrafted Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "cost", "name" },
                values: new object[] { 947.878596666063, "Rustic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "cost", "name" },
                values: new object[] { 405.77827562295806, "Unbranded Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "cost", "name" },
                values: new object[] { 546.36976993744679, "Gorgeous Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "cost", "name" },
                values: new object[] { 716.20408948486681, "Ergonomic Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "cost", "name" },
                values: new object[] { 9.6015715193965221, "Handmade Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "cost", "name" },
                values: new object[] { 480.09568364374576, "Generic Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "cost", "name" },
                values: new object[] { 936.12855863123707, "Unbranded Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "cost", "name" },
                values: new object[] { 528.66432578004265, "Handcrafted Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "cost", "name" },
                values: new object[] { 563.38048988326943, "Handmade Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.3734114899284, "Practical Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.33444155703864, "Awesome Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "cost", "name" },
                values: new object[] { 357.88193906559513, "Licensed Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "cost", "name" },
                values: new object[] { 137.79285012892709, "Licensed Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "cost", "name" },
                values: new object[] { 479.05158816402962, "Practical Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.76048167631927, "Ergonomic Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.839370987777556, "Fantastic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "cost", "name" },
                values: new object[] { 980.21021884825097, "Refined Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "cost", "name" },
                values: new object[] { 905.6820072165275, "Awesome Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "cost", "name" },
                values: new object[] { 166.37765753524974, "Unbranded Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "cost", "name" },
                values: new object[] { 560.88538344345864, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "cost", "name" },
                values: new object[] { 251.68307286808886, "Refined Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.70328749567943, "Small Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "cost", "name" },
                values: new object[] { 944.24408386376024, "Small Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "cost", "name" },
                values: new object[] { 717.29825778872146, "Handmade Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.19466738369192, "Small Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "cost", "name" },
                values: new object[] { 873.98119410025129, "Generic Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "cost", "name" },
                values: new object[] { 857.28533021562487, "Ergonomic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "cost", "name" },
                values: new object[] { 506.32800732477739, "Refined Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "cost", "name" },
                values: new object[] { 867.47935916665199, "Practical Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.2989714986099212, "Unbranded Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "cost", "name" },
                values: new object[] { 207.58818999281857, "Ergonomic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "cost", "name" },
                values: new object[] { 974.77082617481062, "Rustic Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "cost", "name" },
                values: new object[] { 764.50240146688327, "Fantastic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "cost", "name" },
                values: new object[] { 874.64457100745335, "Unbranded Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "cost", "name" },
                values: new object[] { 7.9403244385757983, "Licensed Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.58808627122676, "Unbranded Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "cost", "name" },
                values: new object[] { 89.251351612063687, "Fantastic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.63966783645503, "Small Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "cost", "name" },
                values: new object[] { 369.1962763289481, "Refined Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "cost", "name" },
                values: new object[] { 684.58458294892955, "Sleek Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "cost", "name" },
                values: new object[] { 968.08256645443487, "Awesome Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "cost", "name" },
                values: new object[] { 738.7316944096068, "Intelligent Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "cost", "name" },
                values: new object[] { 273.06438959227791, "Intelligent Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "cost", "name" },
                values: new object[] { 206.54371237975568, "Gorgeous Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "cost", "name" },
                values: new object[] { 442.02592354333132, "Awesome Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "cost", "name" },
                values: new object[] { 272.98362709062366, "Ergonomic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.77864595251231, "Refined Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "cost", "name" },
                values: new object[] { 678.14402683444223, "Sleek Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "cost", "name" },
                values: new object[] { 19.04390637948519, "Handcrafted Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.43587335282049, "Handcrafted Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "cost", "name" },
                values: new object[] { 850.92569984712054, "Licensed Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "cost", "name" },
                values: new object[] { 337.29688839469981, "Generic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.22247875073009, "Licensed Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "cost", "name" },
                values: new object[] { 967.66259942814781, "Handcrafted Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "cost", "name" },
                values: new object[] { 113.89775518964163, "Rustic Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "cost", "name" },
                values: new object[] { 378.50651580606473, "Refined Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "cost", "name" },
                values: new object[] { 869.61607505198788, "Generic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.7394873409429, "Fantastic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "cost", "name" },
                values: new object[] { 28.875510186761829, "Generic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "cost", "name" },
                values: new object[] { 990.93015021602048, "Generic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "cost", "name" },
                values: new object[] { 452.20170867653729, "Fantastic Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "cost", "name" },
                values: new object[] { 943.24486907632593, "Awesome Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "cost", "name" },
                values: new object[] { 490.10569149922583, "Small Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "cost", "name" },
                values: new object[] { 8.0999282396175332, "Ergonomic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.55549155875269, "Handcrafted Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "cost", "name" },
                values: new object[] { 847.58035512813456, "Small Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "cost", "name" },
                values: new object[] { 817.07881871783206, "Ergonomic Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.930934057504714, "Unbranded Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.96998605046588, "Handcrafted Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.05557591654815, "Rustic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.03149144117708, "Generic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "cost", "name" },
                values: new object[] { 747.93871250639597, "Practical Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "cost", "name" },
                values: new object[] { 24.529335351292744, "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "cost", "name" },
                values: new object[] { 871.49287473262279, "Handmade Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "cost", "name" },
                values: new object[] { 993.59823166985598, "Awesome Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.33339009717622, "Tasty Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "cost", "name" },
                values: new object[] { 696.66983643524736, "Generic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "cost", "name" },
                values: new object[] { 622.46086146260632, "Practical Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "cost", "name" },
                values: new object[] { 102.39992175558001, "Handmade Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "cost", "name" },
                values: new object[] { 543.3910745602343, "Practical Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "cost", "name" },
                values: new object[] { 87.92590852948193, "Handmade Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "cost", "name" },
                values: new object[] { 568.99857849959415, "Rustic Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "cost", "name" },
                values: new object[] { 64.247646244974433, "Handmade Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "cost", "name" },
                values: new object[] { 557.79550760122902, "Incredible Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "cost", "name" },
                values: new object[] { 645.59864942351874, "Unbranded Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "cost", "name" },
                values: new object[] { 179.14953947343622, "Handmade Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.16078289786083, "Rustic Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "cost", "name" },
                values: new object[] { 487.3330704442476, "Handmade Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.66449320686411, "Incredible Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.61611477523059, "Handcrafted Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "cost", "name" },
                values: new object[] { 358.07511335509315, "Intelligent Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "cost", "name" },
                values: new object[] { 919.02103071932333, "Handmade Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "cost", "name" },
                values: new object[] { 294.56908422785023, "Gorgeous Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.70402183537431, "Incredible Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "cost", "name" },
                values: new object[] { 873.49389552136438, "Ergonomic Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "cost", "name" },
                values: new object[] { 216.25363485294034, "Incredible Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.50990893167511, "Gorgeous Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.64311291774919, "Awesome Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "cost", "name" },
                values: new object[] { 483.10089334576458, "Unbranded Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "cost", "name" },
                values: new object[] { 836.02715830562011, "Incredible Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.46901663990235, "Intelligent Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "cost", "name" },
                values: new object[] { 862.11084779155851, "Rustic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "cost", "name" },
                values: new object[] { 217.09295503473217, "Generic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "cost", "name" },
                values: new object[] { 919.13884673129883, "Small Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.71628517309819, "Ergonomic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "cost", "name" },
                values: new object[] { 211.19109600432208, "Small Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "cost", "name" },
                values: new object[] { 552.46236083338636, "Refined Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "cost", "name" },
                values: new object[] { 323.42761533900403, "Handcrafted Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "cost", "name" },
                values: new object[] { 330.20038006419844, "Small Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.17329634365956, "Gorgeous Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "cost", "name" },
                values: new object[] { 701.0411576639957, "Rustic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "cost", "name" },
                values: new object[] { 968.70796929785058, "Licensed Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "cost", "name" },
                values: new object[] { 554.77360389436751, "Handcrafted Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.41788613220916, "Fantastic Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "cost", "name" },
                values: new object[] { 334.48098611360911, "Unbranded Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "cost", "name" },
                values: new object[] { 858.36885322588137, "Gorgeous Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "cost", "name" },
                values: new object[] { 667.00996928441657, "Licensed Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "cost", "name" },
                values: new object[] { 82.497719806526703, "Practical Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.63559608721215, "Practical Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "cost", "name" },
                values: new object[] { 307.53169224037725, "Awesome Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "cost", "name" },
                values: new object[] { 172.07161819754549, "Generic Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.28336579346063, "Awesome Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.27333634126455, "Sleek Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "cost", "name" },
                values: new object[] { 901.01049398937346, "Unbranded Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "cost", "name" },
                values: new object[] { 255.03313571413975, "Incredible Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.46555739278824, "Tasty Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "cost", "name" },
                values: new object[] { 477.56899405937799, "Gorgeous Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.03306005121397, "Intelligent Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "cost", "name" },
                values: new object[] { 499.63015712832015, "Gorgeous Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "cost", "name" },
                values: new object[] { 282.36274375748303, "Gorgeous Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "cost", "name" },
                values: new object[] { 559.86566555223078, "Awesome Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "cost", "name" },
                values: new object[] { 282.3675602840508, "Intelligent Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "cost", "name" },
                values: new object[] { 145.1684892557397, "Gorgeous Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "cost", "name" },
                values: new object[] { 872.18380699366435, "Incredible Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "cost", "name" },
                values: new object[] { 186.95418300160742, "Rustic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "cost", "name" },
                values: new object[] { 132.27386528461909, "Small Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.923930592059456, "Gorgeous Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "cost", "name" },
                values: new object[] { 135.42172521343289, "Licensed Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "cost", "name" },
                values: new object[] { 180.40676644563584, "Rustic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "cost", "name" },
                values: new object[] { 339.77149904201639, "Fantastic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "cost", "name" },
                values: new object[] { 565.52185844707594, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "cost", "name" },
                values: new object[] { 792.70985022142611, "Licensed Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "cost", "name" },
                values: new object[] { 493.05671146661115, "Handcrafted Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "cost", "name" },
                values: new object[] { 5.7727314542353083, "Tasty Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "cost", "name" },
                values: new object[] { 277.26366070347285, "Generic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "cost", "name" },
                values: new object[] { 697.08810842831531, "Tasty Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.56188347562403, "Refined Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "cost", "name" },
                values: new object[] { 152.68712430254999, "Handcrafted Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.8968946998354, "Tasty Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "cost", "name" },
                values: new object[] { 4.355300478794053, "Handmade Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.85210834282248, "Incredible Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.76670373386867, "Ergonomic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "cost", "name" },
                values: new object[] { 647.66891622538469, "Ergonomic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.78149587369805, "Small Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "cost", "name" },
                values: new object[] { 572.73177656058238, "Sleek Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "cost", "name" },
                values: new object[] { 464.07038386216885, "Unbranded Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.11553375689653, "Intelligent Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.85612371777543, "Rustic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "cost", "name" },
                values: new object[] { 417.27486141857327, "Licensed Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "cost", "name" },
                values: new object[] { 156.12746624255394, "Generic Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.3508601154702, "Tasty Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "cost", "name" },
                values: new object[] { 429.91307875229188, "Fantastic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "cost", "name" },
                values: new object[] { 914.47973555049282, "Refined Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "cost", "name" },
                values: new object[] { 929.23580842763465, "Refined Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "cost", "name" },
                values: new object[] { 806.91685374844008, "Handcrafted Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "cost", "name" },
                values: new object[] { 589.30264064917867, "Ergonomic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "cost", "name" },
                values: new object[] { 281.97072002988477, "Unbranded Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "cost", "name" },
                values: new object[] { 560.15884125050354, "Ergonomic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "cost", "name" },
                values: new object[] { 358.21605576527554, "Practical Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.2120331837416, "Handcrafted Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "cost", "name" },
                values: new object[] { 782.53006643524361, "Small Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "cost", "name" },
                values: new object[] { 622.62189272599085, "Sleek Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "cost", "name" },
                values: new object[] { 264.68649053718241, "Intelligent Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "cost", "name" },
                values: new object[] { 727.70202646787891, "Rustic Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "cost", "name" },
                values: new object[] { 169.00648956249651, "Handmade Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "cost", "name" },
                values: new object[] { 739.63734318050285, "Handcrafted Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "cost", "name" },
                values: new object[] { 782.91748818625967, "Handmade Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "cost", "name" },
                values: new object[] { 563.09333067865907, "Handcrafted Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "cost", "name" },
                values: new object[] { 524.96012443895017, "Fantastic Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "cost", "name" },
                values: new object[] { 900.62251384761691, "Tasty Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "cost", "name" },
                values: new object[] { 357.44243338696964, "Licensed Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.71271862532022, "Ergonomic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "cost", "name" },
                values: new object[] { 769.53587768558145, "Small Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "cost", "name" },
                values: new object[] { 429.77639189605657, "Rustic Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "cost", "name" },
                values: new object[] { 579.80067167266031, "Intelligent Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "cost", "name" },
                values: new object[] { 478.64981545972103, "Unbranded Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "cost", "name" },
                values: new object[] { 508.42164658018459, "Awesome Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "cost", "name" },
                values: new object[] { 411.95648224576342, "Intelligent Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "cost", "name" },
                values: new object[] { 678.24611445013522, "Sleek Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "cost", "name" },
                values: new object[] { 204.27691820979121, "Tasty Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "cost", "name" },
                values: new object[] { 445.74383457385636, "Small Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "cost", "name" },
                values: new object[] { 787.17865104987322, "Fantastic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "cost", "name" },
                values: new object[] { 888.5904189163341, "Practical Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.06698599670776, "Ergonomic Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.40392552105527, "Licensed Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "cost", "name" },
                values: new object[] { 860.42329770096524, "Unbranded Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "cost", "name" },
                values: new object[] { 902.35709835288924, "Generic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "cost", "name" },
                values: new object[] { 558.49002804323572, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "cost", "name" },
                values: new object[] { 363.48976553649976, "Intelligent Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "cost", "name" },
                values: new object[] { 55.165492170922917, "Fantastic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.26470757664072, "Sleek Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "cost", "name" },
                values: new object[] { 997.5220683944068, "Sleek Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "cost", "name" },
                values: new object[] { 31.375276044770107, "Refined Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "cost", "name" },
                values: new object[] { 621.49308436447427, "Tasty Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "cost", "name" },
                values: new object[] { 371.04660017924562, "Licensed Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "cost", "name" },
                values: new object[] { 592.43231963749543, "Small Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "cost", "name" },
                values: new object[] { 683.59325037218628, "Generic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "cost", "name" },
                values: new object[] { 415.62585830483528, "Sleek Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "cost", "name" },
                values: new object[] { 704.29260026158727, "Practical Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "cost", "name" },
                values: new object[] { 798.04697874856276, "Intelligent Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.81780570721321, "Small Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "cost", "name" },
                values: new object[] { 71.224972936586141, "Practical Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "cost", "name" },
                values: new object[] { 970.38371321776879, "Awesome Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "cost", "name" },
                values: new object[] { 606.15211244824854, "Handmade Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "cost", "name" },
                values: new object[] { 124.18050018249518, "Handcrafted Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "cost", "name" },
                values: new object[] { 255.94302887170454, "Ergonomic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.97979281166079, "Incredible Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "cost", "name" },
                values: new object[] { 76.197320880450647, "Tasty Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "cost", "name" },
                values: new object[] { 408.45108507239382, "Awesome Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "cost", "name" },
                values: new object[] { 200.24262804816667, "Refined Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "cost", "name" },
                values: new object[] { 659.54600290094561, "Practical Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "cost", "name" },
                values: new object[] { 801.23018254715055, "Gorgeous Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.579965278569091, "Sleek Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "cost", "name" },
                values: new object[] { 317.66546292352075, "Refined Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "cost", "name" },
                values: new object[] { 688.4917205505119, "Handmade Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "cost", "name" },
                values: new object[] { 574.07461032797414, "Handcrafted Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "cost", "name" },
                values: new object[] { 245.18713598171328, "Sleek Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "cost", "name" },
                values: new object[] { 398.1339775717633, "Handmade Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "cost", "name" },
                values: new object[] { 53.99651957599356, "Awesome Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "cost", "name" },
                values: new object[] { 606.02896943831604, "Tasty Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "cost", "name" },
                values: new object[] { 828.4172637863893, "Small Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "cost", "name" },
                values: new object[] { 296.87551436100716, "Awesome Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "cost", "name" },
                values: new object[] { 881.36139794652331, "Awesome Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.33621536649423, "Small Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.32799546512405, "Fantastic Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "cost", "name" },
                values: new object[] { 560.61818847234144, "Handmade Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "cost", "name" },
                values: new object[] { 101.94619810718774, "Practical Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "cost", "name" },
                values: new object[] { 681.16451609386195, "Ergonomic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "cost", "name" },
                values: new object[] { 665.58785693539846, "Generic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "cost", "name" },
                values: new object[] { 200.76048051248335, "Incredible Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "cost", "name" },
                values: new object[] { 387.19756763754935, "Unbranded Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.3801009523936, "Incredible Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "cost", "name" },
                values: new object[] { 333.65231392598679, "Practical Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.9456588301025, "Rustic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "cost", "name" },
                values: new object[] { 290.30123583618143, "Awesome Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "cost", "name" },
                values: new object[] { 170.39760311878879, "Incredible Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "cost", "name" },
                values: new object[] { 969.20193035687669, "Generic Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "cost", "name" },
                values: new object[] { 662.61587401005204, "Awesome Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "cost", "name" },
                values: new object[] { 563.87271639280061, "Tasty Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "cost", "name" },
                values: new object[] { 744.44798897299745, "Handmade Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "cost", "name" },
                values: new object[] { 895.19509218090866, "Practical Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.0869688800417, "Handmade Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "cost", "name" },
                values: new object[] { 297.22575607704863, "Generic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "cost", "name" },
                values: new object[] { 345.36658951019962, "Generic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "cost", "name" },
                values: new object[] { 199.92904653475838, "Generic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "cost", "name" },
                values: new object[] { 889.86093212621927, "Practical Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "cost", "name" },
                values: new object[] { 68.322561112279985, "Intelligent Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "cost", "name" },
                values: new object[] { 972.67136443589197, "Awesome Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.7180729993666, "Generic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "cost", "name" },
                values: new object[] { 388.02887975412483, "Practical Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "cost", "name" },
                values: new object[] { 143.66516782826639, "Tasty Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.46366316040394, "Refined Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "cost", "name" },
                values: new object[] { 872.20111201107829, "Incredible Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "cost", "name" },
                values: new object[] { 865.7518350701821, "Handcrafted Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "cost", "name" },
                values: new object[] { 879.7290670417301, "Intelligent Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "cost", "name" },
                values: new object[] { 885.02045698937241, "Awesome Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "cost", "name" },
                values: new object[] { 550.06499704839882, "Intelligent Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.11759018707687, "Incredible Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "cost", "name" },
                values: new object[] { 288.7936979451149, "Sleek Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "cost", "name" },
                values: new object[] { 904.23388147274443, "Refined Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "cost", "name" },
                values: new object[] { 750.45607978286114, "Ergonomic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "cost", "name" },
                values: new object[] { 463.4202821888116, "Small Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "cost", "name" },
                values: new object[] { 302.79301084833571, "Intelligent Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "cost", "name" },
                values: new object[] { 226.92994691761331, "Awesome Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.57367971724142, "Practical Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "cost", "name" },
                values: new object[] { 605.09161037477691, "Gorgeous Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.37745725086654, "Handmade Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "cost", "name" },
                values: new object[] { 678.14128638223792, "Generic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.43461096381134, "Incredible Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "cost", "name" },
                values: new object[] { 198.54015138642521, "Refined Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "cost", "name" },
                values: new object[] { 380.95149982923613, "Gorgeous Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "cost", "name" },
                values: new object[] { 518.39427570057171, "Handmade Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "cost", "name" },
                values: new object[] { 462.95681006140853, "Refined Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "cost", "name" },
                values: new object[] { 810.79461260539915, "Unbranded Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.57735033512387, "Practical Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "cost", "name" },
                values: new object[] { 150.03628777096219, "Gorgeous Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "cost", "name" },
                values: new object[] { 960.5860411498827, "Generic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "cost", "name" },
                values: new object[] { 756.9530755895089, "Handmade Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "cost", "name" },
                values: new object[] { 97.230312159846136, "Incredible Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.0728287357199, "Ergonomic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "cost", "name" },
                values: new object[] { 231.97305158845276, "Ergonomic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "cost", "name" },
                values: new object[] { 299.58847054910291, "Fantastic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "cost", "name" },
                values: new object[] { 254.52158205529315, "Generic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "cost", "name" },
                values: new object[] { 314.35818453188637, "Incredible Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "cost", "name" },
                values: new object[] { 638.4888492019229, "Sleek Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "cost", "name" },
                values: new object[] { 179.09199294602732, "Rustic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "cost", "name" },
                values: new object[] { 571.03503702296814, "Intelligent Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "cost", "name" },
                values: new object[] { 565.74276381605989, "Handcrafted Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "cost", "name" },
                values: new object[] { 662.22863204479643, "Handmade Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.78868179832295, "Small Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "cost", "name" },
                values: new object[] { 828.29354320121183, "Licensed Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "cost", "name" },
                values: new object[] { 119.52616205363933, "Handmade Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "cost", "name" },
                values: new object[] { 149.83131965254501, "Small Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "cost", "name" },
                values: new object[] { 513.88822741918364, "Licensed Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "cost", "name" },
                values: new object[] { 345.96217559208986, "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "cost", "name" },
                values: new object[] { 422.67755337215766, "Generic Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "cost", "name" },
                values: new object[] { 816.071361139587, "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "cost", "name" },
                values: new object[] { 466.40987907812081, "Handmade Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.10929914676711, "Ergonomic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "cost", "name" },
                values: new object[] { 806.43321705856943, "Fantastic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "cost", "name" },
                values: new object[] { 410.40100609246122, "Handcrafted Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "cost", "name" },
                values: new object[] { 342.32853538793779, "Awesome Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "cost", "name" },
                values: new object[] { 453.81878256102704, "Handmade Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "cost", "name" },
                values: new object[] { 77.693217862822451, "Small Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.83904183078494, "Fantastic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "cost", "name" },
                values: new object[] { 885.7772652879687, "Practical Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.29684447182314, "Tasty Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.743110986745073, "Handcrafted Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "cost", "name" },
                values: new object[] { 950.92299319257802, "Practical Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "cost", "name" },
                values: new object[] { 60.734158478513372, "Licensed Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "cost", "name" },
                values: new object[] { 69.044316989689108, "Handcrafted Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "cost", "name" },
                values: new object[] { 266.27294869718696, "Incredible Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "cost", "name" },
                values: new object[] { 268.36433671416728, "Rustic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "cost", "name" },
                values: new object[] { 333.1406897298121, "Licensed Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "cost", "name" },
                values: new object[] { 292.78332960933824, "Intelligent Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "cost", "name" },
                values: new object[] { 726.95751368132869, "Ergonomic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "cost", "name" },
                values: new object[] { 413.63008299584993, "Licensed Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "cost", "name" },
                values: new object[] { 821.54657381261234, "Ergonomic Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "cost", "name" },
                values: new object[] { 257.77918676642378, "Generic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "cost", "name" },
                values: new object[] { 929.06330426181751, "Awesome Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "cost", "name" },
                values: new object[] { 142.57715914985076, "Handcrafted Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.85415419691014, "Sleek Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "cost", "name" },
                values: new object[] { 854.03392319490831, "Licensed Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.86578984200548, "Generic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "cost", "name" },
                values: new object[] { 961.73055240142708, "Intelligent Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "cost", "name" },
                values: new object[] { 527.2713621095495, "Gorgeous Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "cost", "name" },
                values: new object[] { 568.08607639395098, "Licensed Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "cost", "name" },
                values: new object[] { 136.01304580322588, "Gorgeous Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.0446435374414, "Fantastic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.68775846062097, "Awesome Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "cost", "name" },
                values: new object[] { 539.19608936822908, "Tasty Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "cost", "name" },
                values: new object[] { 572.60803753843641, "Refined Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "cost", "name" },
                values: new object[] { 111.89461398503542, "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "cost", "name" },
                values: new object[] { 976.60245361540899, "Small Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "cost", "name" },
                values: new object[] { 969.63496382465166, "Licensed Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "cost", "name" },
                values: new object[] { 251.07685463410326, "Handmade Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "cost", "name" },
                values: new object[] { 468.73016585456691, "Ergonomic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "cost", "name" },
                values: new object[] { 950.75534780731937, "Sleek Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "cost", "name" },
                values: new object[] { 715.59243349215467, "Sleek Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.79297038805353, "Incredible Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "cost", "name" },
                values: new object[] { 587.27951105918066, "Practical Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "cost", "name" },
                values: new object[] { 153.17121447081365, "Practical Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "cost", "name" },
                values: new object[] { 440.48737349257323, "Rustic Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.40823623601318, "Licensed Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "cost", "name" },
                values: new object[] { 140.31151119119016, "Licensed Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.88563648701415, "Tasty Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "cost", "name" },
                values: new object[] { 477.37129679874374, "Intelligent Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "cost", "name" },
                values: new object[] { 627.96145369560122, "Awesome Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "cost", "name" },
                values: new object[] { 350.46982947388244, "Practical Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.36144941585553, "Ergonomic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "cost", "name" },
                values: new object[] { 353.09677913313391, "Handmade Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "cost", "name" },
                values: new object[] { 596.39031496609266, "Practical Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.603641904283773, "Ergonomic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "cost", "name" },
                values: new object[] { 766.22762556393991, "Handmade Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "cost", "name" },
                values: new object[] { 753.03340258051992, "Handcrafted Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.95883881965813, "Sleek Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.62354215827776, "Licensed Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "cost", "name" },
                values: new object[] { 343.63333521618085, "Handcrafted Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "cost", "name" },
                values: new object[] { 530.70004660979305, "Gorgeous Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "cost", "name" },
                values: new object[] { 668.28215048849188, "Unbranded Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "cost", "name" },
                values: new object[] { 551.24884288831151, "Awesome Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "cost", "name" },
                values: new object[] { 819.58338164130362, "Handmade Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "cost", "name" },
                values: new object[] { 109.78970021625318, "Handcrafted Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "cost", "name" },
                values: new object[] { 854.77367980452561, "Handcrafted Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "cost", "name" },
                values: new object[] { 465.94409455359602, "Sleek Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.11814862634833, "Small Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "cost", "name" },
                values: new object[] { 294.14241670214204, "Rustic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.11352838576795, "Refined Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "cost", "name" },
                values: new object[] { 443.71415499716517, "Handmade Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "cost", "name" },
                values: new object[] { 646.4176351608038, "Gorgeous Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "cost", "name" },
                values: new object[] { 412.16287728645352, "Intelligent Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "cost", "name" },
                values: new object[] { 668.70195273999389, "Generic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.302915298488877, "Awesome Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "cost", "name" },
                values: new object[] { 589.60521592976363, "Refined Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "cost", "name" },
                values: new object[] { 182.86390516105797, "Gorgeous Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.09560953274638, "Fantastic Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.54059919482052, "Incredible Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "cost", "name" },
                values: new object[] { 537.57355391992019, "Licensed Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "cost", "name" },
                values: new object[] { 625.67507002549428, "Handmade Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "cost", "name" },
                values: new object[] { 22.399163694233721, "Awesome Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "cost", "name" },
                values: new object[] { 72.469386871696003, "Practical Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.4480808292941, "Awesome Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.78911156856839, "Ergonomic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "cost", "name" },
                values: new object[] { 319.37057009194626, "Incredible Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.996553972577317, "Generic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "cost", "name" },
                values: new object[] { 340.49502157036522, "Licensed Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.40127486738396, "Handmade Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "cost", "name" },
                values: new object[] { 72.574251350778255, "Ergonomic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "cost", "name" },
                values: new object[] { 466.66958460036636, "Gorgeous Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.95118451024348, "Rustic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "cost", "name" },
                values: new object[] { 324.5411374989186, "Awesome Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "cost", "name" },
                values: new object[] { 621.43057510693404, "Practical Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "cost", "name" },
                values: new object[] { 692.45039443203154, "Unbranded Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "cost", "name" },
                values: new object[] { 591.21523941262285, "Intelligent Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "cost", "name" },
                values: new object[] { 829.59693697279056, "Gorgeous Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "cost", "name" },
                values: new object[] { 323.48059544743711, "Small Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "cost", "name" },
                values: new object[] { 72.040182348325359, "Ergonomic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "cost", "name" },
                values: new object[] { 205.01370160729539, "Refined Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.6100888654886092, "Gorgeous Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "cost", "name" },
                values: new object[] { 67.553648808485789, "Rustic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "cost", "name" },
                values: new object[] { 210.75641941921435, "Handmade Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.2873493909687, "Licensed Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "cost", "name" },
                values: new object[] { 623.60737057272831, "Ergonomic Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "cost", "name" },
                values: new object[] { 489.61260969420624, "Awesome Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "cost", "name" },
                values: new object[] { 794.77488682618605, "Tasty Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "cost", "name" },
                values: new object[] { 332.35192094844018, "Incredible Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.02582164111766, "Handcrafted Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "cost", "name" },
                values: new object[] { 632.45063738360614, "Refined Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.7644386705403, "Handcrafted Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "cost", "name" },
                values: new object[] { 699.13704361871885, "Intelligent Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.2813277534292, "Sleek Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "cost", "name" },
                values: new object[] { 6.8840984879343461, "Refined Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "cost", "name" },
                values: new object[] { 427.38245130706781, "Ergonomic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "cost", "name" },
                values: new object[] { 378.96251996253937, "Refined Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.132825766274735, "Awesome Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "cost", "name" },
                values: new object[] { 474.07370352238468, "Intelligent Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "cost", "name" },
                values: new object[] { 417.74976834843699, "Rustic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.06850359719294, "Refined Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "cost", "name" },
                values: new object[] { 150.60747939768129, "Licensed Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "cost", "name" },
                values: new object[] { 931.22903238922584, "Incredible Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "cost", "name" },
                values: new object[] { 611.99973122808842, "Incredible Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "cost", "name" },
                values: new object[] { 476.85964180508665, "Tasty Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "cost", "name" },
                values: new object[] { 756.55266520090811, "Handcrafted Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "cost", "name" },
                values: new object[] { 634.9710301760316, "Generic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "cost", "name" },
                values: new object[] { 751.47742906538645, "Licensed Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "cost", "name" },
                values: new object[] { 809.8684860530891, "Small Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "cost", "name" },
                values: new object[] { 823.34045727637579, "Practical Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "cost", "name" },
                values: new object[] { 735.45244867650297, "Tasty Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "cost", "name" },
                values: new object[] { 146.82778875714675, "Refined Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.08992535497953, "Handcrafted Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "cost", "name" },
                values: new object[] { 781.50003253636771, "Awesome Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "cost", "name" },
                values: new object[] { 687.6942758483541, "Fantastic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "cost", "name" },
                values: new object[] { 555.27931762289234, "Refined Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "cost", "name" },
                values: new object[] { 916.99227292706144, "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "cost", "name" },
                values: new object[] { 618.63915534580394, "Licensed Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.380946839223952, "Fantastic Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.08536470858201, "Fantastic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "cost", "name" },
                values: new object[] { 309.4644264711439, "Unbranded Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "cost", "name" },
                values: new object[] { 769.59510599907458, "Sleek Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "cost", "name" },
                values: new object[] { 231.45330771652283, "Licensed Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.44227709487268, "Ergonomic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.06179129832185, "Ergonomic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "cost", "name" },
                values: new object[] { 835.16401534013505, "Awesome Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "cost", "name" },
                values: new object[] { 986.16547297319141, "Ergonomic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.67750339817223, "Incredible Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "cost", "name" },
                values: new object[] { 682.53864400246789, "Handcrafted Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.52075948539266, "Ergonomic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "cost", "name" },
                values: new object[] { 205.955312717038, "Small Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "cost", "name" },
                values: new object[] { 294.41436783065711, "Refined Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.86950142589069, "Refined Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "cost", "name" },
                values: new object[] { 488.34035813917967, "Unbranded Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "cost", "name" },
                values: new object[] { 203.31547579265785, "Practical Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "cost", "name" },
                values: new object[] { 100.39560178285316, "Awesome Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "cost", "name" },
                values: new object[] { 713.88594170728959, "Rustic Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "cost", "name" },
                values: new object[] { 986.93968453800676, "Refined Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "cost", "name" },
                values: new object[] { 81.864003541794375, "Intelligent Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "cost", "name" },
                values: new object[] { 469.73908046408457, "Generic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "cost", "name" },
                values: new object[] { 919.50151137942669, "Licensed Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "cost", "name" },
                values: new object[] { 146.63132960153106, "Intelligent Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "cost", "name" },
                values: new object[] { 707.05554966985301, "Awesome Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "cost", "name" },
                values: new object[] { 469.59180879837169, "Practical Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.4762752742505, "Incredible Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "cost", "name" },
                values: new object[] { 729.94320983168825, "Handcrafted Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "cost", "name" },
                values: new object[] { 924.60440893295322, "Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "cost", "name" },
                values: new object[] { 458.93103603712404, "Handmade Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "cost", "name" },
                values: new object[] { 386.16753603871797, "Refined Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "cost", "name" },
                values: new object[] { 925.68148431435179, "Rustic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "cost", "name" },
                values: new object[] { 782.05703985094306, "Sleek Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "cost", "name" },
                values: new object[] { 672.95584685533879, "Gorgeous Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.73726818881593, "Licensed Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "cost", "name" },
                values: new object[] { 640.16318025808278, "Ergonomic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "cost", "name" },
                values: new object[] { 213.46619657178252, "Generic Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "cost", "name" },
                values: new object[] { 216.97955200691376, "Handcrafted Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "cost", "name" },
                values: new object[] { 419.45063935771037, "Incredible Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.46338544663013, "Small Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "cost", "name" },
                values: new object[] { 97.001809231271082, "Refined Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "cost", "name" },
                values: new object[] { 897.86042457168082, "Fantastic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "cost", "name" },
                values: new object[] { 839.90759438911482, "Fantastic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.637835215838351, "Small Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "cost", "name" },
                values: new object[] { 929.67140231967767, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "cost", "name" },
                values: new object[] { 259.46853847930919, "Handmade Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "cost", "name" },
                values: new object[] { 27.460869616459973, "Rustic Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.2379283698048922, "Gorgeous Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.97254528919223, "Rustic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "cost", "name" },
                values: new object[] { 430.63447365637921, "Handmade Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "cost", "name" },
                values: new object[] { 936.98036765889344, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "cost", "name" },
                values: new object[] { 477.26388575231448, "Generic Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.39639216404566, "Tasty Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "cost", "name" },
                values: new object[] { 949.33646995140884, "Intelligent Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "cost", "name" },
                values: new object[] { 943.03189875594273, "Rustic Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.76026872088744, "Intelligent Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "cost", "name" },
                values: new object[] { 515.30272311090755, "Generic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "cost", "name" },
                values: new object[] { 222.2256315637558, "Sleek Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "cost", "name" },
                values: new object[] { 826.14222654775813, "Sleek Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "cost", "name" },
                values: new object[] { 590.23382803959987, "Licensed Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "cost", "name" },
                values: new object[] { 812.32873834221641, "Awesome Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "cost", "name" },
                values: new object[] { 250.91587246045151, "Gorgeous Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "cost", "name" },
                values: new object[] { 881.02627405273552, "Tasty Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "cost", "name" },
                values: new object[] { 577.95527818661412, "Practical Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "cost", "name" },
                values: new object[] { 442.57307434934933, "Handcrafted Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "cost", "name" },
                values: new object[] { 884.39190164225101, "Awesome Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "cost", "name" },
                values: new object[] { 499.44464840864447, "Fantastic Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "cost", "name" },
                values: new object[] { 860.23539867127511, "Handcrafted Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.03746325625804, "Awesome Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "cost", "name" },
                values: new object[] { 786.16052120771667, "Refined Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "cost", "name" },
                values: new object[] { 706.26317792928955, "Unbranded Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "cost", "name" },
                values: new object[] { 279.52238614743555, "Licensed Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "cost", "name" },
                values: new object[] { 439.63639773581883, "Incredible Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.860919312193644, "Small Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "cost", "name" },
                values: new object[] { 744.75592739238721, "Unbranded Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "cost", "name" },
                values: new object[] { 831.15983964021211, "Intelligent Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "cost", "name" },
                values: new object[] { 496.00443584364223, "Incredible Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "cost", "name" },
                values: new object[] { 163.82855163938856, "Generic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "cost", "name" },
                values: new object[] { 64.841333790482111, "Ergonomic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.13061201360529, "Practical Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "cost", "name" },
                values: new object[] { 413.15810958005898, "Practical Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "cost", "name" },
                values: new object[] { 130.51704935759466, "Fantastic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.7624942749776, "Fantastic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.54227237034024, "Handcrafted Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "cost", "name" },
                values: new object[] { 706.05208673904292, "Incredible Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "cost", "name" },
                values: new object[] { 822.12479516643816, "Handcrafted Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "cost", "name" },
                values: new object[] { 580.67019609110241, "Handcrafted Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "cost", "name" },
                values: new object[] { 124.73594632713481, "Incredible Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "cost", "name" },
                values: new object[] { 668.3941369242126, "Ergonomic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "cost", "name" },
                values: new object[] { 656.00578425757237, "Licensed Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "cost", "name" },
                values: new object[] { 583.87344240909681, "Licensed Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.04394564824611, "Practical Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "cost", "name" },
                values: new object[] { 66.126620549578547, "Generic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "cost", "name" },
                values: new object[] { 416.75347855960649, "Gorgeous Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "cost", "name" },
                values: new object[] { 586.74582495976165, "Generic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "cost", "name" },
                values: new object[] { 579.30178767270127, "Practical Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "cost", "name" },
                values: new object[] { 911.49335190328281, "Intelligent Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.91555598860134, "Fantastic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "cost", "name" },
                values: new object[] { 141.01138011867624, "Intelligent Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.71149445418979, "Awesome Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "cost", "name" },
                values: new object[] { 665.13797050447999, "Intelligent Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.14138931318917, "Intelligent Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "cost", "name" },
                values: new object[] { 625.70553298427649, "Refined Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "cost", "name" },
                values: new object[] { 82.540839165652756, "Tasty Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "cost", "name" },
                values: new object[] { 454.14501064152898, "Tasty Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "cost", "name" },
                values: new object[] { 202.0853559167096, "Tasty Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "cost", "name" },
                values: new object[] { 488.14408318905697, "Tasty Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "cost", "name" },
                values: new object[] { 742.70042208658026, "Handcrafted Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.3252039666335, "Licensed Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.87814233654672, "Intelligent Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "cost", "name" },
                values: new object[] { 318.9439933614658, "Gorgeous Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "cost", "name" },
                values: new object[] { 683.58698243449635, "Sleek Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "cost", "name" },
                values: new object[] { 324.12595449165269, "Unbranded Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "cost", "name" },
                values: new object[] { 147.61490183993391, "Handmade Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.33157991043913, "Refined Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "cost", "name" },
                values: new object[] { 263.31456451468335, "Sleek Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "cost", "name" },
                values: new object[] { 935.0405757016872, "Gorgeous Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "cost", "name" },
                values: new object[] { 639.06272366055941, "Generic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "cost", "name" },
                values: new object[] { 695.11697746434049, "Tasty Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "cost", "name" },
                values: new object[] { 507.62815666404407, "Sleek Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "cost", "name" },
                values: new object[] { 195.98724505971262, "Rustic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.09280452569692, "Small Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.484130365648056, "Practical Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "cost", "name" },
                values: new object[] { 889.86109797448842, "Licensed Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "cost", "name" },
                values: new object[] { 158.35041331407081, "Fantastic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "cost", "name" },
                values: new object[] { 507.60890656523804, "Ergonomic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "cost", "name" },
                values: new object[] { 497.37818925137668, "Fantastic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "cost", "name" },
                values: new object[] { 511.35433081633744, "Unbranded Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.52515906041265, "Tasty Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.77068835812852, "Awesome Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.23850377690837, "Small Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.12184206555511, "Fantastic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "cost", "name" },
                values: new object[] { 868.60546684038559, "Ergonomic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "cost", "name" },
                values: new object[] { 380.24374456510026, "Tasty Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "cost", "name" },
                values: new object[] { 617.52722041873596, "Rustic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "cost", "name" },
                values: new object[] { 578.67366023406123, "Licensed Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.5118438758513, "Small Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "cost", "name" },
                values: new object[] { 840.96643118730958, "Small Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "cost", "name" },
                values: new object[] { 977.94049849225632, "Sleek Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "cost", "name" },
                values: new object[] { 872.84772253746712, "Fantastic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.65977576345449, "Unbranded Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "cost", "name" },
                values: new object[] { 518.68208856818433, "Small Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "cost", "name" },
                values: new object[] { 217.08150297241619, "Unbranded Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "cost", "name" },
                values: new object[] { 486.59103627748004, "Practical Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.64806118152092, "Unbranded Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.09142096584242, "Intelligent Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "cost", "name" },
                values: new object[] { 895.87643138634053, "Gorgeous Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "cost", "name" },
                values: new object[] { 221.66080956009236, "Unbranded Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "cost", "name" },
                values: new object[] { 965.84401053872159, "Refined Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "cost", "name" },
                values: new object[] { 665.93054874062432, "Unbranded Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "cost", "name" },
                values: new object[] { 10.567803967885459, "Sleek Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "cost", "name" },
                values: new object[] { 612.69809357217616, "Fantastic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "cost", "name" },
                values: new object[] { 900.13081036975632, "Fantastic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.37227151096147, "Fantastic Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "cost", "name" },
                values: new object[] { 801.42450403031239, "Fantastic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "cost", "name" },
                values: new object[] { 848.06129089351032, "Handcrafted Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.56907897982364, "Practical Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.52759336737006, "Intelligent Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "cost", "name" },
                values: new object[] { 855.75623608609055, "Licensed Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "cost", "name" },
                values: new object[] { 379.73147781408818, "Tasty Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "cost", "name" },
                values: new object[] { 565.78448022081454, "Small Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "cost", "name" },
                values: new object[] { 74.952352542432536, "Fantastic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "cost", "name" },
                values: new object[] { 414.47067889532923, "Fantastic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.11204742427003, "Unbranded Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "cost", "name" },
                values: new object[] { 604.73555903399301, "Tasty Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "cost", "name" },
                values: new object[] { 669.81499087193185, "Rustic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "cost", "name" },
                values: new object[] { 983.25273039626165, "Rustic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "cost", "name" },
                values: new object[] { 199.17265721995275, "Handcrafted Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "cost", "name" },
                values: new object[] { 899.1718742800573, "Fantastic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "cost", "name" },
                values: new object[] { 602.73099677926461, "Generic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "cost", "name" },
                values: new object[] { 177.33559331775191, "Tasty Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "cost", "name" },
                values: new object[] { 262.05572448189332, "Unbranded Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "cost", "name" },
                values: new object[] { 704.6561120861428, "Refined Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "cost", "name" },
                values: new object[] { 912.51267361470195, "Awesome Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "cost", "name" },
                values: new object[] { 29.481884898923955, "Rustic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "cost", "name" },
                values: new object[] { 828.52740096480477, "Unbranded Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "cost", "name" },
                values: new object[] { 915.01408666461884, "Handmade Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "cost", "name" },
                values: new object[] { 879.36016737732143, "Incredible Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "cost", "name" },
                values: new object[] { 406.44945499195103, "Gorgeous Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "cost", "name" },
                values: new object[] { 629.42705893057746, "Awesome Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "cost", "name" },
                values: new object[] { 986.27528158570306, "Generic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "cost", "name" },
                values: new object[] { 119.65691753762339, "Small Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "cost", "name" },
                values: new object[] { 270.59789192956242, "Licensed Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.32719215791522, "Unbranded Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "cost", "name" },
                values: new object[] { 186.65480235799035, "Gorgeous Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "cost", "name" },
                values: new object[] { 680.19456060835864, "Practical Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "cost", "name" },
                values: new object[] { 71.142789329083726, "Handmade Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "cost", "name" },
                values: new object[] { 346.19655329874644, "Intelligent Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.30992113752689, "Tasty Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "cost", "name" },
                values: new object[] { 256.43970269205039, "Gorgeous Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "cost", "name" },
                values: new object[] { 160.81339786198475, "Practical Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.80148701819076, "Awesome Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.81168641614067, "Rustic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "cost", "name" },
                values: new object[] { 494.10785529707101, "Rustic Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "cost", "name" },
                values: new object[] { 274.6849646177302, "Intelligent Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "cost", "name" },
                values: new object[] { 983.32935688863813, "Practical Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "cost", "name" },
                values: new object[] { 23.724330698029842, "Unbranded Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "cost", "name" },
                values: new object[] { 65.890415263352835, "Fantastic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.51875245685801, "Tasty Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "cost", "name" },
                values: new object[] { 797.96644602878007, "Incredible Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "cost", "name" },
                values: new object[] { 156.52205360470884, "Licensed Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.55447304268591, "Sleek Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "cost", "name" },
                values: new object[] { 141.59025678097254, "Rustic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "cost", "name" },
                values: new object[] { 402.39958753445541, "Handmade Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.57386468798813, "Fantastic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "cost", "name" },
                values: new object[] { 513.15154270502785, "Licensed Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "cost", "name" },
                values: new object[] { 18.096542636871916, "Incredible Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "cost", "name" },
                values: new object[] { 494.7603050557085, "Handmade Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "cost", "name" },
                values: new object[] { 2.6986341541572809, "Ergonomic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "cost", "name" },
                values: new object[] { 269.37918692949199, "Ergonomic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "cost", "name" },
                values: new object[] { 387.28088268733956, "Fantastic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "cost", "name" },
                values: new object[] { 915.02912383604144, "Intelligent Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.05369668621336, "Fantastic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "cost", "name" },
                values: new object[] { 195.22274271627688, "Rustic Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.80455631736527, "Unbranded Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "cost", "name" },
                values: new object[] { 636.10911683176232, "Sleek Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.77631204186918, "Unbranded Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "cost", "name" },
                values: new object[] { 737.83109939925657, "Incredible Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.687299849702114, "Rustic Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "cost", "name" },
                values: new object[] { 48.64572172285353, "Incredible Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.4927482142657, "Incredible Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.83835558294152, "Practical Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "cost", "name" },
                values: new object[] { 666.24546686077019, "Handcrafted Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "cost", "name" },
                values: new object[] { 490.22336450389548, "Incredible Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "cost", "name" },
                values: new object[] { 382.19752701340656, "Practical Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "cost", "name" },
                values: new object[] { 289.71154878716391, "Handmade Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "cost", "name" },
                values: new object[] { 486.26666885602049, "Ergonomic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "cost", "name" },
                values: new object[] { 981.65430132434471, "Sleek Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "cost", "name" },
                values: new object[] { 678.27792831035401, "Handmade Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "cost", "name" },
                values: new object[] { 286.81893155114869, "Ergonomic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "cost", "name" },
                values: new object[] { 259.84228061530848, "Practical Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "cost", "name" },
                values: new object[] { 934.57211705857594, "Ergonomic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "cost", "name" },
                values: new object[] { 973.26159457338326, "Gorgeous Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "cost", "name" },
                values: new object[] { 969.26203719618525, "Refined Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "cost", "name" },
                values: new object[] { 642.58995537571195, "Gorgeous Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "cost", "name" },
                values: new object[] { 935.51432342626788, "Gorgeous Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.90144123398684, "Ergonomic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "cost", "name" },
                values: new object[] { 538.84856448172627, "Refined Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "cost", "name" },
                values: new object[] { 729.38687381381533, "Rustic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "cost", "name" },
                values: new object[] { 129.41180528517805, "Generic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "cost", "name" },
                values: new object[] { 546.04094364620414, "Refined Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.85117574929279, "Handcrafted Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "cost", "name" },
                values: new object[] { 704.75677100279927, "Practical Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "cost", "name" },
                values: new object[] { 181.27613716753544, "Generic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "cost", "name" },
                values: new object[] { 991.36411522367973, "Practical Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "cost", "name" },
                values: new object[] { 60.337820448830364, "Generic Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "cost", "name" },
                values: new object[] { 160.14935783955661, "Incredible Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "cost", "name" },
                values: new object[] { 677.60380645569523, "Handmade Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "cost", "name" },
                values: new object[] { 587.65653575190868, "Handmade Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "cost", "name" },
                values: new object[] { 221.5681839478159, "Unbranded Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.83928233623067, "Rustic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "cost", "name" },
                values: new object[] { 296.93968258017583, "Awesome Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "cost", "name" },
                values: new object[] { 141.69948290822344, "Incredible Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "cost", "name" },
                values: new object[] { 114.67360792810543, "Generic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "cost", "name" },
                values: new object[] { 902.58953300517373, "Fantastic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "cost", "name" },
                values: new object[] { 151.14217099624022, "Practical Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "cost", "name" },
                values: new object[] { 15.604411854370369, "Generic Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.44976231049895, "Tasty Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.74322305596348, "Handcrafted Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.53942789848315, "Tasty Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.62031540609195, "Incredible Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "cost", "name" },
                values: new object[] { 695.55618465922225, "Gorgeous Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "cost", "name" },
                values: new object[] { 844.58089875276448, "Awesome Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "cost", "name" },
                values: new object[] { 220.92456757393467, "Ergonomic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.07320633992867, "Awesome Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "cost", "name" },
                values: new object[] { 3.4795788121383824, "Intelligent Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "cost", "name" },
                values: new object[] { 409.81205662373878, "Practical Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "cost", "name" },
                values: new object[] { 599.05183692625565, "Handcrafted Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "cost", "name" },
                values: new object[] { 326.32896285967979, "Ergonomic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "cost", "name" },
                values: new object[] { 387.73574629382824, "Handmade Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.22486754414194, "Small Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.69672522024257, "Practical Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "cost", "name" },
                values: new object[] { 480.47391548203422, "Ergonomic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "cost", "name" },
                values: new object[] { 436.31964110662574, "Handmade Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "cost", "name" },
                values: new object[] { 792.67437986665936, "Awesome Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "cost", "name" },
                values: new object[] { 56.094484499923432, "Fantastic Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "cost", "name" },
                values: new object[] { 198.98008492002043, "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "cost", "name" },
                values: new object[] { 605.08888163036727, "Awesome Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "cost", "name" },
                values: new object[] { 635.88864102929085, "Intelligent Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "cost", "name" },
                values: new object[] { 673.93793481772479, "Generic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "cost", "name" },
                values: new object[] { 268.94215508375231, "Refined Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.45773252380627, "Sleek Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "cost", "name" },
                values: new object[] { 226.0964456441973, "Intelligent Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.80736926136211, "Small Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "cost", "name" },
                values: new object[] { 39.629499501107787, "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "cost", "name" },
                values: new object[] { 630.89194939214144, "Gorgeous Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "cost", "name" },
                values: new object[] { 878.52540382998666, "Intelligent Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "cost", "name" },
                values: new object[] { 937.32141383029557, "Practical Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "cost", "name" },
                values: new object[] { 815.03286026002627, "Sleek Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.58437149382144, "Small Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.87823872531305, "Ergonomic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "cost", "name" },
                values: new object[] { 705.62030986670038, "Sleek Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "cost", "name" },
                values: new object[] { 640.15951227763037, "Rustic Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.98747222093461, "Tasty Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "cost", "name" },
                values: new object[] { 464.16796408113163, "Tasty Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "cost", "name" },
                values: new object[] { 880.06759137628205, "Refined Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.82921220570199, "Gorgeous Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "cost", "name" },
                values: new object[] { 415.08934334778627, "Small Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "cost", "name" },
                values: new object[] { 290.76604993261287, "Handmade Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.21867895622549, "Handcrafted Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "cost", "name" },
                values: new object[] { 562.90081461199384, "Generic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "cost", "name" },
                values: new object[] { 500.86646419953399, "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.93108178554314, "Tasty Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "cost", "name" },
                values: new object[] { 165.35237004639666, "Fantastic Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.62979867116303, "Tasty Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "cost", "name" },
                values: new object[] { 195.61283273396396, "Ergonomic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "cost", "name" },
                values: new object[] { 539.8519226830856, "Gorgeous Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "cost", "name" },
                values: new object[] { 891.6924260239665, "Rustic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.61088433573195, "Refined Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "cost", "name" },
                values: new object[] { 353.40373139913419, "Fantastic Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.54754529602769, "Licensed Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "cost", "name" },
                values: new object[] { 305.27542535247255, "Tasty Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "cost", "name" },
                values: new object[] { 627.88895615695048, "Generic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "cost", "name" },
                values: new object[] { 454.44018007430947, "Sleek Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "cost", "name" },
                values: new object[] { 787.22050364794916, "Rustic Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "cost", "name" },
                values: new object[] { 287.52421663901731, "Gorgeous Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "cost", "name" },
                values: new object[] { 204.90590774405132, "Ergonomic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "cost", "name" },
                values: new object[] { 624.92914367444189, "Fantastic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "cost", "name" },
                values: new object[] { 255.20011715680107, "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "cost", "name" },
                values: new object[] { 347.26836559981712, "Refined Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "cost", "name" },
                values: new object[] { 986.71657404698067, "Practical Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "cost", "name" },
                values: new object[] { 101.91788084956535, "Ergonomic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "cost", "name" },
                values: new object[] { 893.0418898983977, "Handmade Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.45129008252309, "Fantastic Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.497265835658446, "Licensed Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "cost", "name" },
                values: new object[] { 268.51954662126337, "Intelligent Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "cost", "name" },
                values: new object[] { 746.0281785558941, "Practical Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "cost", "name" },
                values: new object[] { 281.89913724860327, "Fantastic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "cost", "name" },
                values: new object[] { 82.934361856546687, "Refined Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "cost", "name" },
                values: new object[] { 491.66056256120174, "Handmade Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "cost", "name" },
                values: new object[] { 592.09906647504476, "Ergonomic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "cost", "name" },
                values: new object[] { 575.82282730995701, "Incredible Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.33221454960051, "Tasty Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "cost", "name" },
                values: new object[] { 457.03621395335131, "Fantastic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "cost", "name" },
                values: new object[] { 742.33215861535245, "Generic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.5597811430747, "Generic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "cost", "name" },
                values: new object[] { 379.90053103502362, "Fantastic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "cost", "name" },
                values: new object[] { 224.84085448908289, "Handcrafted Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.60945071035792, "Awesome Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "cost", "name" },
                values: new object[] { 709.52767950143834, "Handcrafted Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "cost", "name" },
                values: new object[] { 739.9891033004526, "Awesome Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "cost", "name" },
                values: new object[] { 935.95017051670504, "Licensed Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "cost", "name" },
                values: new object[] { 137.73134714767292, "Practical Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "cost", "name" },
                values: new object[] { 110.98803200164249, "Generic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "cost", "name" },
                values: new object[] { 422.84966137592852, "Generic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "cost", "name" },
                values: new object[] { 457.08249269017568, "Licensed Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.4301574139489, "Generic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "cost", "name" },
                values: new object[] { 171.36657044511526, "Small Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.38108836006484, "Rustic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "cost", "name" },
                values: new object[] { 39.546863901775829, "Handmade Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "cost", "name" },
                values: new object[] { 939.28927899392568, "Sleek Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.68470972124095, "Awesome Granite Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "cost", "name" },
                values: new object[] { 581.47313778594662, "Awesome Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "cost", "name" },
                values: new object[] { 449.22051291652497, "Awesome Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "cost", "name" },
                values: new object[] { 477.95459040779929, "Sleek Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "cost", "name" },
                values: new object[] { 968.61792439960584, "Gorgeous Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.22869300315676, "Generic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "cost", "name" },
                values: new object[] { 571.09519481516554, "Gorgeous Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "cost", "name" },
                values: new object[] { 896.29952178081396, "Intelligent Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "cost", "name" },
                values: new object[] { 163.52849347808205, "Generic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "cost", "name" },
                values: new object[] { 629.82879600865965, "Ergonomic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "cost", "name" },
                values: new object[] { 950.97830894411618, "Generic Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "cost", "name" },
                values: new object[] { 735.55435181812391, "Small Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.66585796416109, "Tasty Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "cost", "name" },
                values: new object[] { 891.98519245134889, "Fantastic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "cost", "name" },
                values: new object[] { 212.54920129158671, "Fantastic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.09380908279377, "Sleek Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "cost", "name" },
                values: new object[] { 79.864889159941342, "Licensed Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.86398840065993, "Sleek Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "cost", "name" },
                values: new object[] { 319.66461210178153, "Incredible Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "cost", "name" },
                values: new object[] { 72.006702488614906, "Incredible Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "cost", "name" },
                values: new object[] { 925.37266921712899, "Intelligent Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "cost", "name" },
                values: new object[] { 147.02411859529408, "Generic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "cost", "name" },
                values: new object[] { 296.71331465349931, "Incredible Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "cost", "name" },
                values: new object[] { 535.67638281833172, "Practical Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "cost", "name" },
                values: new object[] { 326.75837206369022, "Awesome Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "cost", "name" },
                values: new object[] { 536.21160127451958, "Gorgeous Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "cost", "name" },
                values: new object[] { 262.07450870724438, "Intelligent Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "cost", "name" },
                values: new object[] { 315.38928988639123, "Rustic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "cost", "name" },
                values: new object[] { 125.10721172082327, "Gorgeous Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "cost", "name" },
                values: new object[] { 415.48739045338488, "Tasty Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "cost", "name" },
                values: new object[] { 466.39316642627512, "Unbranded Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.80554043369682, "Refined Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "cost", "name" },
                values: new object[] { 312.0956155948362, "Sleek Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "cost", "name" },
                values: new object[] { 867.35273472151164, "Licensed Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "cost", "name" },
                values: new object[] { 385.62684060144011, "Small Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "cost", "name" },
                values: new object[] { 89.896283959957188, "Fantastic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "cost", "name" },
                values: new object[] { 243.58603270024281, "Refined Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "cost", "name" },
                values: new object[] { 207.49412151896684, "Generic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "cost", "name" },
                values: new object[] { 392.05728588138913, "Generic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "cost", "name" },
                values: new object[] { 773.52214648676386, "Rustic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "cost", "name" },
                values: new object[] { 58.803515789497176, "Gorgeous Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.70145471966669, "Ergonomic Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "cost", "name" },
                values: new object[] { 155.70846281576365, "Incredible Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "cost", "name" },
                values: new object[] { 603.07485796013339, "Refined Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "cost", "name" },
                values: new object[] { 715.48906061492846, "Practical Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "cost", "name" },
                values: new object[] { 674.65864151028211, "Awesome Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "cost", "name" },
                values: new object[] { 492.73688854988529, "Practical Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.01495879006216, "Refined Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.83693634911953, "Incredible Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "cost", "name" },
                values: new object[] { 327.66912757944243, "Sleek Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "cost", "name" },
                values: new object[] { 987.00056637443174, "Tasty Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "cost", "name" },
                values: new object[] { 312.56998286134541, "Gorgeous Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "cost", "name" },
                values: new object[] { 54.035738108969866, "Fantastic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.83615189858139, "Generic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "cost", "name" },
                values: new object[] { 269.70118359549804, "Licensed Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "cost", "name" },
                values: new object[] { 297.92342753276336, "Generic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "cost", "name" },
                values: new object[] { 281.27801887652805, "Intelligent Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "cost", "name" },
                values: new object[] { 171.06227400440855, "Tasty Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "cost", "name" },
                values: new object[] { 315.13903043327389, "Rustic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "cost", "name" },
                values: new object[] { 588.79017187842476, "Generic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "cost", "name" },
                values: new object[] { 212.62146346951442, "Unbranded Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "cost", "name" },
                values: new object[] { 988.89625719732567, "Small Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.00487972847168, "Awesome Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "cost", "name" },
                values: new object[] { 576.7925246629236, "Handmade Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "cost", "name" },
                values: new object[] { 661.82508787422296, "Tasty Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "cost", "name" },
                values: new object[] { 900.40586886952065, "Refined Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "cost", "name" },
                values: new object[] { 872.41462280875714, "Generic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "cost", "name" },
                values: new object[] { 662.39193366882603, "Gorgeous Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "cost", "name" },
                values: new object[] { 598.24873249992993, "Refined Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.86988698713674, "Handcrafted Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "cost", "name" },
                values: new object[] { 448.36421445053168, "Tasty Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "cost", "name" },
                values: new object[] { 5.8186279991556464, "Rustic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "cost", "name" },
                values: new object[] { 419.20606062027048, "Licensed Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.56879427652348, "Generic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "cost", "name" },
                values: new object[] { 933.72176078435109, "Handmade Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.95381451374277, "Sleek Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "cost", "name" },
                values: new object[] { 614.84911517162334, "Rustic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.149641759428746, "Intelligent Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "cost", "name" },
                values: new object[] { 542.92354287608975, "Licensed Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "cost", "name" },
                values: new object[] { 640.21362094502535, "Generic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "cost", "name" },
                values: new object[] { 750.54825149861483, "Small Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "cost", "name" },
                values: new object[] { 479.88806832001393, "Rustic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "cost", "name" },
                values: new object[] { 465.55600031835547, "Tasty Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "cost", "name" },
                values: new object[] { 522.88321153377069, "Intelligent Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "cost", "name" },
                values: new object[] { 926.58577568370754, "Handmade Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "cost", "name" },
                values: new object[] { 846.11708357061048, "Rustic Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "cost", "name" },
                values: new object[] { 462.19671735147949, "Ergonomic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "cost", "name" },
                values: new object[] { 618.50686826733272, "Unbranded Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "cost", "name" },
                values: new object[] { 901.53924175463703, "Unbranded Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "cost", "name" },
                values: new object[] { 646.13889021300611, "Incredible Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "cost", "name" },
                values: new object[] { 602.98550366999416, "Rustic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "cost", "name" },
                values: new object[] { 56.988279439920269, "Awesome Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "cost", "name" },
                values: new object[] { 89.548254177588248, "Awesome Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "cost", "name" },
                values: new object[] { 518.5157498808469, "Unbranded Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "cost", "name" },
                values: new object[] { 871.92208373132621, "Licensed Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "cost", "name" },
                values: new object[] { 762.40933112547702, "Small Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.158945998517304, "Rustic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "cost", "name" },
                values: new object[] { 236.25198079494101, "Tasty Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "cost", "name" },
                values: new object[] { 982.55010996445071, "Intelligent Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "cost", "name" },
                values: new object[] { 327.49510456187448, "Small Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "cost", "name" },
                values: new object[] { 806.65383779107935, "Fantastic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 940,
                columns: new[] { "cost", "name" },
                values: new object[] { 27.31359970311296, "Intelligent Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 941,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.53409359367697, "Intelligent Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 942,
                columns: new[] { "cost", "name" },
                values: new object[] { 953.75416189474288, "Incredible Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 943,
                columns: new[] { "cost", "name" },
                values: new object[] { 271.51555938726955, "Gorgeous Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 944,
                columns: new[] { "cost", "name" },
                values: new object[] { 482.35748049227351, "Gorgeous Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 945,
                columns: new[] { "cost", "name" },
                values: new object[] { 198.19092710233261, "Ergonomic Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 946,
                columns: new[] { "cost", "name" },
                values: new object[] { 166.09464963491223, "Unbranded Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 947,
                columns: new[] { "cost", "name" },
                values: new object[] { 18.138755238255442, "Intelligent Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 948,
                columns: new[] { "cost", "name" },
                values: new object[] { 587.52618342866026, "Gorgeous Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 949,
                columns: new[] { "cost", "name" },
                values: new object[] { 143.01557647669881, "Unbranded Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 950,
                columns: new[] { "cost", "name" },
                values: new object[] { 535.4486530493125, "Gorgeous Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 951,
                columns: new[] { "cost", "name" },
                values: new object[] { 159.56807010798533, "Sleek Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 952,
                columns: new[] { "cost", "name" },
                values: new object[] { 682.70437082448132, "Practical Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 953,
                columns: new[] { "cost", "name" },
                values: new object[] { 510.47046692042636, "Small Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 954,
                columns: new[] { "cost", "name" },
                values: new object[] { 922.63242851578343, "Licensed Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 955,
                columns: new[] { "cost", "name" },
                values: new object[] { 356.12772888392237, "Tasty Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 956,
                columns: new[] { "cost", "name" },
                values: new object[] { 127.14609611922246, "Fantastic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 957,
                columns: new[] { "cost", "name" },
                values: new object[] { 154.42720515357399, "Awesome Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 958,
                columns: new[] { "cost", "name" },
                values: new object[] { 629.47737539186119, "Small Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 959,
                columns: new[] { "cost", "name" },
                values: new object[] { 825.19371527332567, "Unbranded Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 960,
                columns: new[] { "cost", "name" },
                values: new object[] { 294.07637294788077, "Rustic Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 961,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.40582592831427, "Intelligent Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 962,
                columns: new[] { "cost", "name" },
                values: new object[] { 854.04398885056116, "Ergonomic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 963,
                columns: new[] { "cost", "name" },
                values: new object[] { 260.86667000663851, "Gorgeous Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 964,
                columns: new[] { "cost", "name" },
                values: new object[] { 307.82078976592811, "Awesome Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 965,
                columns: new[] { "cost", "name" },
                values: new object[] { 156.12301141119374, "Awesome Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 966,
                columns: new[] { "cost", "name" },
                values: new object[] { 831.08979847933506, "Licensed Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 967,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.64468762451569, "Handmade Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 968,
                columns: new[] { "cost", "name" },
                values: new object[] { 982.86280018351601, "Fantastic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 969,
                columns: new[] { "cost", "name" },
                values: new object[] { 905.47506712752977, "Licensed Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 970,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.7770719857798, "Awesome Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 971,
                columns: new[] { "cost", "name" },
                values: new object[] { 322.64026936814946, "Ergonomic Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 972,
                columns: new[] { "cost", "name" },
                values: new object[] { 6.1811433106679878, "Sleek Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 973,
                columns: new[] { "cost", "name" },
                values: new object[] { 590.39801359981777, "Handmade Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 974,
                columns: new[] { "cost", "name" },
                values: new object[] { 940.44774965479951, "Small Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 975,
                columns: new[] { "cost", "name" },
                values: new object[] { 584.44792224259629, "Unbranded Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 976,
                columns: new[] { "cost", "name" },
                values: new object[] { 190.37509900143252, "Ergonomic Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 977,
                columns: new[] { "cost", "name" },
                values: new object[] { 854.24035321296162, "Practical Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 978,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.31840674803198, "Intelligent Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 979,
                columns: new[] { "cost", "name" },
                values: new object[] { 877.66968746712985, "Practical Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 980,
                columns: new[] { "cost", "name" },
                values: new object[] { 721.86836367299418, "Practical Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 981,
                columns: new[] { "cost", "name" },
                values: new object[] { 643.62202257158583, "Sleek Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 982,
                columns: new[] { "cost", "name" },
                values: new object[] { 106.34424418934432, "Handmade Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 983,
                columns: new[] { "cost", "name" },
                values: new object[] { 104.73600856225529, "Generic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 984,
                columns: new[] { "cost", "name" },
                values: new object[] { 766.20763422461994, "Fantastic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 985,
                columns: new[] { "cost", "name" },
                values: new object[] { 549.74022838490282, "Small Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 986,
                columns: new[] { "cost", "name" },
                values: new object[] { 879.90922857696285, "Generic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 987,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.18395789952717, "Sleek Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 988,
                columns: new[] { "cost", "name" },
                values: new object[] { 384.36760970234263, "Intelligent Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 989,
                columns: new[] { "cost", "name" },
                values: new object[] { 269.41680335141007, "Gorgeous Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 990,
                columns: new[] { "cost", "name" },
                values: new object[] { 319.8813025132053, "Handcrafted Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 991,
                columns: new[] { "cost", "name" },
                values: new object[] { 277.80043925836867, "Tasty Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 992,
                columns: new[] { "cost", "name" },
                values: new object[] { 497.75201919444203, "Intelligent Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 993,
                columns: new[] { "cost", "name" },
                values: new object[] { 970.02886736663345, "Generic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 994,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.98575095548517, "Generic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 995,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.68831703238408, "Small Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 996,
                columns: new[] { "cost", "name" },
                values: new object[] { 454.90235387722174, "Sleek Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 997,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.45343572447371, "Gorgeous Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 998,
                columns: new[] { "cost", "name" },
                values: new object[] { 318.40229275443397, "Small Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 999,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.7079857083292, "Intelligent Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1000,
                columns: new[] { "cost", "name" },
                values: new object[] { 14.493075852847294, "Ergonomic Cotton Chicken" });
        }
    }
}
