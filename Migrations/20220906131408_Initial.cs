using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IoT.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Category",
            //    columns: table => new
            //    {
            //        CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Category", x => x.CategoryID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Device",
            //    columns: table => new
            //    {
            //        DeviceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ZoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsActvie = table.Column<bool>(type: "bit", nullable: false),
            //        DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Device", x => x.DeviceID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Zone",
            //    columns: table => new
            //    {
            //        ZoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ZoneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ZoneDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Zone", x => x.ZoneID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Zone");
        }
    }
}
