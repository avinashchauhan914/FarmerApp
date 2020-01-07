using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerFarmerApp.Migrations
{
    public partial class spGetRegistrationList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
      var sp = @"CREATE PROCEDURE [dbo].[GetRegistrationList]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from [dbo].[registrationModels]
                END";

      migrationBuilder.Sql(sp);
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
