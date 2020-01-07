using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerFarmerApp.Migrations
{
    public partial class fullRegistrationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "measurementDatas",
                columns: table => new
                {
                    MeasureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasureName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measurementDatas", x => x.MeasureId);
                });

            migrationBuilder.CreateTable(
                name: "stateModels",
                columns: table => new
                {
                    StateId = table.Column<string>(nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stateModels", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "userTypes",
                columns: table => new
                {
                    userTypeId = table.Column<string>(nullable: false),
                    userTypeName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTypes", x => x.userTypeId);
                });

            migrationBuilder.CreateTable(
                name: "cityModels",
                columns: table => new
                {
                    CityId = table.Column<string>(nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StateId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityModels", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_cityModels_stateModels_StateId",
                        column: x => x.StateId,
                        principalTable: "stateModels",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registrationModels",
                columns: table => new
                {
                    RegisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Mobile = table.Column<long>(type: "BIGINT", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    userTypeId = table.Column<string>(nullable: false),
                    CityId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StateId = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registrationModels", x => x.RegisId);
                    table.ForeignKey(
                        name: "FK_registrationModels_stateModels_StateId",
                        column: x => x.StateId,
                        principalTable: "stateModels",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_registrationModels_userTypes_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "userTypes",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "delregistrationModels",
                columns: table => new
                {
                    DelRegisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ShopId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    RegisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delregistrationModels", x => x.DelRegisId);
                    table.ForeignKey(
                        name: "FK_delregistrationModels_registrationModels_RegisId",
                        column: x => x.RegisId,
                        principalTable: "registrationModels",
                        principalColumn: "RegisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "frmRegistrationModels",
                columns: table => new
                {
                    FrmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<double>(type: "float(50)", nullable: false),
                    MeasureId = table.Column<int>(nullable: false),
                    RegisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frmRegistrationModels", x => x.FrmId);
                    table.ForeignKey(
                        name: "FK_frmRegistrationModels_measurementDatas_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "measurementDatas",
                        principalColumn: "MeasureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_frmRegistrationModels_registrationModels_RegisId",
                        column: x => x.RegisId,
                        principalTable: "registrationModels",
                        principalColumn: "RegisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cityModels_StateId",
                table: "cityModels",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_delregistrationModels_RegisId",
                table: "delregistrationModels",
                column: "RegisId");

            migrationBuilder.CreateIndex(
                name: "IX_frmRegistrationModels_MeasureId",
                table: "frmRegistrationModels",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_frmRegistrationModels_RegisId",
                table: "frmRegistrationModels",
                column: "RegisId");

            migrationBuilder.CreateIndex(
                name: "IX_registrationModels_StateId",
                table: "registrationModels",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_registrationModels_userTypeId",
                table: "registrationModels",
                column: "userTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cityModels");

            migrationBuilder.DropTable(
                name: "delregistrationModels");

            migrationBuilder.DropTable(
                name: "frmRegistrationModels");

            migrationBuilder.DropTable(
                name: "measurementDatas");

            migrationBuilder.DropTable(
                name: "registrationModels");

            migrationBuilder.DropTable(
                name: "stateModels");

            migrationBuilder.DropTable(
                name: "userTypes");
        }
    }
}
