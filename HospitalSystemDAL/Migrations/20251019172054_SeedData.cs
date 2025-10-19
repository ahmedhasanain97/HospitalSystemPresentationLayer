using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalSystemDAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Name", "openingHours" },
                values: new object[,]
                {
                    { 1, "Downtown Clinic", "9 AM - 5 PM" },
                    { 2, "Uptown Clinic", "10 AM - 6 PM" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Gender", "Name", "Position", "Salary", "phoneNumber" },
                values: new object[,]
                {
                    { 1, "Dokki, Giza", "F", "Heba Ali", "Receptionist", 7500.0, "01044444444" },
                    { 2, "Cairo", "M", "Khaled Hassan", "Accountant", 9000.0, "01033333333" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Address", "DateOfBirth", "Gender", "Name", "phoneNumber" },
                values: new object[,]
                {
                    { 1, "Giza, Egypt", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "Sara Mohamed", "01011122334" },
                    { 2, "Maadi, Cairo", new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Omar Khaled", "01099998888" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "ClinicId", "Gender", "Name", "Specialty", "phoneNumber" },
                values: new object[,]
                {
                    { 1, "Nasr City, Cairo", 1, "M", "Dr. Ahmed Hassan", "Cardiology", "01098765432" },
                    { 2, "Heliopolis, Cairo", 1, "F", "Dr. Mona Ibrahim", "Dermatology", "01055555555" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ClinicId", "DoctorId", "EmployeeId", "PatientId", "ReservationDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(2025, 10, 21, 20, 20, 54, 473, DateTimeKind.Local).AddTicks(2879) },
                    { 2, 1, 2, 2, 2, new DateTime(2025, 10, 22, 20, 20, 54, 473, DateTimeKind.Local).AddTicks(2919) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
