using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketApp_DAL.Migrations
{
    public partial class changeingrname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingridients",
                table: "Recipe",
                newName: "Ingredients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e124ebf3-a05a-4f19-a049-3237c26e416d",
                column: "ConcurrencyStamp",
                value: "0598c363-d101-4de4-baef-2b9d9989a8b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e498fbb0-6d78-42c2-bf93-f4c839914cb6",
                column: "ConcurrencyStamp",
                value: "92b002c2-72de-4d6b-a5e6-902347ea1860");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f15051c-3dcd-406c-bb73-ced7c4372f8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d703b3fb-b56b-4f34-ba9b-04611f94c029", "AQAAAAEAACcQAAAAELPNTgiW9MrKYZM8+9LIDrh/Zaxn0pgbM7wmmsqubgI8f9BEZSe9xe0UveNq1vZ2WA==", "2c6720ce-a1c8-4299-ae76-b2c29a30c800" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Ingredients", "Name" },
                values: new object[] { "web services bluetooth RAM Plastic payment Intelligent Rubber Pizza Expressway Lead pixel orange", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "drive drive Ports Buckinghamshire Home Loan Account", "Cheat's chickpea korma curry" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Ingredients", "Name" },
                values: new object[] { "National Product Product Swaziland program Square Plastic Advanced Wooden Senior", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "niches JBOD Generic Rubber Salad Yemeni Rial Auto Loan Account", "Baked ricotta cake" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Ingredients", "Name", "Type" },
                values: new object[] { "supply-chains Avenue Handmade Soft Sausages feed seamless protocol Handmade Cotton Chips invoice Island hacking", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "gold panel SSL Gorgeous Soft Chicken Handmade Rubber Hat", "Cheat's chickpea korma curry", "Breakfast" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Ingredients", "Type" },
                values: new object[] { "supply-chains virtual Soft deposit maximize Customer Bedfordshire Rhode Island Practical Granite Chips Rustic Plastic Tuna", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Rubber Tasty Granite Table Ergonomic Metal Sausages Vatu circuit", "Dinner" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Ingredients", "Name" },
                values: new object[] { "Gorgeous Rubber Chicken Philippine Peso Checking Account Shores tan integrate Granite haptic niches cross-platform", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Kyrgyz Republic solid state Manager markets deposit", "Cookie Recipe" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Ingredients", "Name", "Type" },
                values: new object[] { "Baby & Home Intranet Monitored Product Awesome Soft Shoes Square Handmade Wooden Pizza Honduras Direct Buckinghamshire", "compelling Generic magnetic Generic data-warehouse", "Cheat's chickpea korma curry", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Ingredients", "Name", "Type" },
                values: new object[] { "Pike infomediaries content-based Missouri solid state Place Borders Vermont Flat Gorgeous Frozen Keyboard", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "sexy productivity violet virtual azure", "Baked ricotta cake", "Breakfast" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Ingredients", "Name" },
                values: new object[] { "Georgia card leading-edge invoice mint green Via Home, Clothing & Tools digital quantify Licensed Frozen Shirt", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Awesome Soft Table Baby Licensed Compatible exploit", "Caramilk croissant slice" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Ingredients", "Name", "Type" },
                values: new object[] { "Stand-alone RAM Versatile invoice calculating compress generating Planner eyeballs transmitting", "Home Loan Account intranet array Freeway Designer", "Cookie Recipe", "Breakfast" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Ingredients", "Name" },
                values: new object[] { "overriding digital matrix Gibraltar Pound Dynamic payment Trail Factors Small Avon", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "digital functionalities program Data generate", "Caramilk croissant slice" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingredients",
                table: "Recipe",
                newName: "Ingridients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e124ebf3-a05a-4f19-a049-3237c26e416d",
                column: "ConcurrencyStamp",
                value: "ea73117e-f425-4a5a-9e4d-09e44267a67d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e498fbb0-6d78-42c2-bf93-f4c839914cb6",
                column: "ConcurrencyStamp",
                value: "cef4af64-71ac-452b-95c0-657d115713ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f15051c-3dcd-406c-bb73-ced7c4372f8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09505c97-9c5d-41c5-b2dc-54f7c8fef00a", "AQAAAAEAACcQAAAAEG7eWTDblNbPcpXnQ8VOXz6+vIv1tfHeAIaG7dtvnxcKQL/aFf0hBHK3WJDJaH8lew==", "5e5a93dc-a23d-4dc9-ad55-3dcef45bfef4" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "B2C Creative quantify Wooden Practical blockchains Internal Wisconsin Alabama tan", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "mindshare object-oriented RSS Cross-platform Bedfordshire", "Caramilk croissant slice" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "mobile Nebraska AGP cultivate SAS mint green Human South Africa Home Loan Account Adaptive", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Rustic Handcrafted Rubber Chips syndicate empower seamless", "Cheat's chickpea korma curry" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "bluetooth Handmade Plastic Mouse mobile Kids & Sports interactive circuit Assurance Frozen Bermudian Dollar (customarily known as Bermuda Dollar) Accountability", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Sports & Home Haven Money Market Account payment Generic Rubber Soap", "Caramilk croissant slice", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Ingridients", "Type" },
                values: new object[] { "Common leverage Buckinghamshire Fords Small Concrete Bacon synergistic Harbor Dynamic withdrawal impactful", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "programming Producer monitor Generic Steel Soap action-items", "Breakfast" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "Expressway homogeneous Outdoors, Computers & Baby Bedfordshire Creative Money Market Account Administrator projection Sleek Plastic Keyboard payment", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "SCSI schemas wireless invoice intermediate", "Caramilk croissant slice" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Ingridients", "Name", "Type" },
                values: new object[] { "deposit Burundi Franc Generic Granite Ball Buckinghamshire Outdoors Croatia calculating Dynamic violet Multi-lateral", "Handmade Steel Pants systemic Wooden mission-critical black", "Cookie Recipe", "Dinner" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "Small Computers & Grocery Colorado frame microchip multimedia Shoals Gabon Lesotho bypassing", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Antarctica (the territory South of 60 deg S) overriding Investor Ergonomic Cotton Gloves array", "Cheat's chickpea korma curry", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "indexing Facilitator Generic Cotton Gloves Spurs Licensed Plastic Salad Zimbabwe Dollar solid state Hryvnia Small Health, Industrial & Books", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "bypassing indigo interface whiteboard Consultant", "Baked ricotta cake" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Ingridients", "Name", "Type" },
                values: new object[] { "optical local feed Haven SCSI violet hack Fields ivory Upgradable", "Consultant Money Market Account bluetooth FTP Intelligent Plastic Chair", "Cheat's chickpea korma curry", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "Personal Loan Account Jewelery, Movies & Grocery Fresh Licensed Steel Fish input violet solutions SQL bandwidth Home Loan Account", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Automotive Handcrafted Berkshire Forward Handcrafted Steel Chips", "Cookie Recipe" });
        }
    }
}
