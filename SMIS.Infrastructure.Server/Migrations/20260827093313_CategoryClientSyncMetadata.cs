using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SMIS.Infrastructure.Server.Context;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20260827093313_CategoryClientSyncMetadata")]
public partial class CategoryClientSyncMetadata : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "ClientCreatedBy",
            table: "Category",
            type: "nvarchar(450)",
            maxLength: 450,
            nullable: true);

        migrationBuilder.AddColumn<DateTime>(
            name: "ClientCreatedDate",
            table: "Category",
            type: "datetime2",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "ClientModifiedBy",
            table: "Category",
            type: "nvarchar(450)",
            maxLength: 450,
            nullable: true);

        migrationBuilder.AddColumn<DateTime>(
            name: "ClientModifiedDate",
            table: "Category",
            type: "datetime2",
            nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(name: "ClientCreatedBy", table: "Category");
        migrationBuilder.DropColumn(name: "ClientCreatedDate", table: "Category");
        migrationBuilder.DropColumn(name: "ClientModifiedBy", table: "Category");
        migrationBuilder.DropColumn(name: "ClientModifiedDate", table: "Category");
    }
}
