using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketApp_DAL.Migrations
{
    public partial class changeingridients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Description", "Ingridients", "Name" },
                values: new object[] { "B2C Creative quantify Wooden Practical blockchains Internal Wisconsin Alabama tan", "mindshare object-oriented RSS Cross-platform Bedfordshire", "Caramilk croissant slice" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "mobile Nebraska AGP cultivate SAS mint green Human South Africa Home Loan Account Adaptive", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Rustic Handcrafted Rubber Chips syndicate empower seamless", "Cheat's chickpea korma curry", "Dinner" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "bluetooth Handmade Plastic Mouse mobile Kids & Sports interactive circuit Assurance Frozen Bermudian Dollar (customarily known as Bermuda Dollar) Accountability", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Sports & Home Haven Money Market Account payment Generic Rubber Soap", "Caramilk croissant slice" });

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
                columns: new[] { "Description", "Image", "Ingridients", "Type" },
                values: new object[] { "Expressway homogeneous Outdoors, Computers & Baby Bedfordshire Creative Money Market Account Administrator projection Sleek Plastic Keyboard payment", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "SCSI schemas wireless invoice intermediate", "Dinner" });

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
                columns: new[] { "Description", "Image", "Ingridients", "Type" },
                values: new object[] { "optical local feed Haven SCSI violet hack Fields ivory Upgradable", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Consultant Money Market Account bluetooth FTP Intelligent Plastic Chair", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "Personal Loan Account Jewelery, Movies & Grocery Fresh Licensed Steel Fish input violet solutions SQL bandwidth Home Loan Account", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Automotive Handcrafted Berkshire Forward Handcrafted Steel Chips", "Cookie Recipe", "Breakfast" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e124ebf3-a05a-4f19-a049-3237c26e416d",
                column: "ConcurrencyStamp",
                value: "6b047a95-9013-4ae9-a10a-cfba80e4b792");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e498fbb0-6d78-42c2-bf93-f4c839914cb6",
                column: "ConcurrencyStamp",
                value: "534049f5-779d-4d7b-97ae-f1ab5ac28da2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f15051c-3dcd-406c-bb73-ced7c4372f8f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78a9e346-a357-49c3-b4bf-eaf45679d1a5", "AQAAAAEAACcQAAAAENdk6r7HrsHEc9tQhWJg29f1MSJae+XjwHizdTdGX5dgl4o+wS06tu6b1YEC2egRQA==", "656d8547-518a-4213-8272-f4cb29be19fa" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Ingridients", "Name" },
                values: new object[] { "Gorgeous Wooden Table focus group technologies Licensed collaborative Strategist override Home Loan Account optical Oklahoma", "Lemon", "Baked ricotta cake" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "Generic Row dedicated Supervisor withdrawal Money Market Account Money Market Account productivity Rapids Iceland", "https://images.unsplash.com/photo-1532499016263-f2c3e89de9cd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=8", "Flour", "Caramilk croissant slice", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "ability content-based Practical Fresh Keyboard microchip Home Loan Account Tools empowering deliver Cambridgeshire payment", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "Flour", "Baked ricotta cake" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Ingridients", "Type" },
                values: new object[] { "Avon Cambridgeshire Solutions Gardens Future zero tolerance Micronesia Berkshire Gardens Small", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "Eggs", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Ingridients", "Type" },
                values: new object[] { "Mountains Squares Ergonomic Cotton Computer Credit Card Account bandwidth Granite Finland Cedi bypassing Colorado", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Eggs", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Ingridients", "Name", "Type" },
                values: new object[] { "azure Facilitator Turnpike dynamic Licensed Strategist multi-state Borders Guatemala Borders", "Eggs", "Caramilk croissant slice", "Lunch" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "Executive Frozen Corporate override Practical Frozen Cheese Awesome Metal Ball withdrawal Crossing Idaho collaborative", "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80", "Lemon", "Caramilk croissant slice", "Breakfast" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Ingridients", "Name" },
                values: new object[] { "tangible Silver Re-contextualized Decentralized Mongolia neural invoice Regional Automotive, Movies & Tools National", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Eggs", "Cookie Recipe" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Ingridients", "Type" },
                values: new object[] { "Pakistan Rupee deposit Licensed Wooden Tuna Home Loan Account Web User-friendly sensor Saint Martin Dalasi invoice", "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "Butter", "Breakfast" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Ingridients", "Name", "Type" },
                values: new object[] { "Bhutanese Ngultrum Mobility Costa Rica Investor International 6th generation Awesome Cotton Bike Realigned Frozen optimizing", "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg", "Lemon", "Baked ricotta cake", "Lunch" });
        }
    }
}
