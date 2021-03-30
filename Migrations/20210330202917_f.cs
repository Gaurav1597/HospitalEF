using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalEF.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "PatientsID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientsId",
                table: "Appointment",
                newName: "IX_Appointment_PatientsID");

            migrationBuilder.AlterColumn<int>(
                name: "PatientsID",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patients_PatientsID",
                table: "Appointment",
                column: "PatientsID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patients_PatientsID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "PatientsID",
                table: "Appointment",
                newName: "PatientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientsID",
                table: "Appointment",
                newName: "IX_Appointment_PatientsId");

            migrationBuilder.AlterColumn<int>(
                name: "PatientsId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
