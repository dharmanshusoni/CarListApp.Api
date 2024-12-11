using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a220b77-52fe-4fc6-9a91-67246ef3529f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3204c0b7-d9aa-46a2-9114-9680068d262d", "AQAAAAIAAYagAAAAEMKMti9zomH8KG0c30s0VKIO4s8Koab8XIbvqov77mIFiX2qDrcBourAqx5Vnl9d6Q==", "09cb504a-5ec5-414c-8da2-73ae91e2ab6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3deb5dc-93e4-4295-ba46-2fc651f62441",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e54e61c9-9b3c-4608-b0d0-5616481bb1e3", "AQAAAAIAAYagAAAAEF5K266nkjiUMpxbwynOaxBdPzJoEvjV31NNVHK+6UM+WoSUkQ6L33sFhb4ogc3RhA==", "b5e28011-5480-4749-97bc-31fbacc9d56a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a220b77-52fe-4fc6-9a91-67246ef3529f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b35b9b6-d29f-4e96-acbe-5521bffeff28", "AQAAAAIAAYagAAAAEJxK3mJEbPouFvUBjPnRSRAn2mrDhcnfBxYQm+IGdJuKakspAnQ6Q0TLGUzwSRCUPA==", "e0b7ee67-c01a-4f9a-8c4a-6603dca4e142" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3deb5dc-93e4-4295-ba46-2fc651f62441",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8cee061-d32c-4181-adca-3c3983a4995c", "AQAAAAIAAYagAAAAEBaZ/7HGb9ROBi9LCUv/1yXmTtQyiM4y2ZDIFbXPH7IGe3IP4Ari4A9GZTIqCNBA6A==", "c47536c1-8603-4f92-95ca-91cf8d134738" });
        }
    }
}
