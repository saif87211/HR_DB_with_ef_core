using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_DB_with_ef_core.Migrations
{
    /// <inheritdoc />
    public partial class JobColumnsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MinSalary",
                table: "Jobs",
                type: "TEXT",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaxSalary",
                table: "Jobs",
                type: "TEXT",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MinSalary",
                table: "Jobs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxSalary",
                table: "Jobs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 6,
                oldNullable: true);
        }
    }
}
