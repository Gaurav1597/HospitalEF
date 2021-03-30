using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalEF.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patients_patientsidId",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "patientsidId",
                table: "Appointment",
                newName: "PatientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_patientsidId",
                table: "Appointment",
                newName: "IX_Appointment_PatientsId");

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patients_PatientsId",
                table: "Appointment",
                column: "PatientsId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patients_PatientsId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "Appointment",
                newName: "patientsidId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientsId",
                table: "Appointment",
                newName: "IX_Appointment_patientsidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patients_patientsidId",
                table: "Appointment",
                column: "patientsidId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
