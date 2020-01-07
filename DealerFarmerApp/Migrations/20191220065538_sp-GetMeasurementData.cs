using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerFarmerApp.Migrations
{
    public partial class spGetMeasurementData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
      var sp = @"CREATE PROCEDURE [dbo].[GetMeasurementData]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from [dbo].[measurementDatas]
                END";

      migrationBuilder.Sql(sp);
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
