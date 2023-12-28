using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS(select id from AspNetRoles where id ='a4ac2f87-2356-4547-9d56-33ba9c0d04c3')
                BEGIN
                INSERT INTO [AspNetRoles]
                           ([Id]
                           ,[Name]
                           ,[NormalizedName])
                     VALUES
                           ('a4ac2f87-2356-4547-9d56-33ba9c0d04c3'
                           ,'admin'
                           ,'ADMIN')
                END
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetRoles where Id='a4ac2f87-2356-4547-9d56-33ba9c0d04c3'");
        }
    }
}
