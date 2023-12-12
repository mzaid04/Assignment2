using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class databasemig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptid = table.Column<int>(type: "int", nullable: false),
                    standing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.fid);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    standing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.sid);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    room_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.cid);
                    table.ForeignKey(
                        name: "FK_Class_Faculty_fid",
                        column: x => x.fid,
                        principalTable: "Faculty",
                        principalColumn: "fid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cid = table.Column<int>(type: "int", nullable: false),
                    sid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.eid);
                    table.ForeignKey(
                        name: "FK_Enrollment_Class_cid",
                        column: x => x.cid,
                        principalTable: "Class",
                        principalColumn: "cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_sid",
                        column: x => x.sid,
                        principalTable: "Student",
                        principalColumn: "sid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_fid",
                table: "Class",
                column: "fid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_cid",
                table: "Enrollment",
                column: "cid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_sid",
                table: "Enrollment",
                column: "sid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Faculty");
        }
    }
}
