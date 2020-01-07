using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerFarmerApp.Migrations
{
    public partial class spGetCityData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          var sp = @"CREATE PROCEDURE [dbo].[GetCityData]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from [dbo].[cityModels]
                END";

           migrationBuilder.Sql(sp);
        }

    protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
