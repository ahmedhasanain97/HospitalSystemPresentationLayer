using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystemDAL.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EmployeeId",
                table: "Reservations",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Employees_EmployeeId",
                table: "Reservations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Employees_EmployeeId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_EmployeeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Reservations");
        }
    }
}
