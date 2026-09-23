using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    /// <inheritdoc />
    public partial class StandardizeSeedUserIdentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                DECLARE @Users TABLE
                (
                    Id nvarchar(450) NOT NULL,
                    Email nvarchar(256) NOT NULL,
                    FirstName nvarchar(256) NULL,
                    LastName nvarchar(256) NULL
                );

                INSERT INTO @Users (Id, Email, FirstName, LastName)
                VALUES
                    ('44444444-0000-0000-0000-000000000001', 'superadmin@mainstore.com', 'Main Store', 'SuperAdmin'),
                    ('44444444-0000-0000-0000-000000000002', 'admin@mainstore.com', 'Main Store', 'Admin'),
                    ('44444444-0000-0000-0000-000000000003', 'administration@mainstore.com', 'Main Store', 'Administration'),
                    ('44444444-0000-0000-0000-000000000004', 'manager@mainstore.com', 'Main Store', 'Manager'),
                    ('44444444-0000-0000-0000-000000000005', 'staff@mainstore.com', 'Main Store', 'Staff'),
                    ('44444444-0000-0000-0000-000000000006', 'viewer@mainstore.com', 'Main Store', 'Viewer'),
                    ('44444444-0000-0000-0000-000000000007', 'editor@mainstore.com', 'Main Store', 'Editor'),
                    ('44444444-0000-0000-0000-000000000008', 'user@mainstore.com', 'Main Store', 'User'),
                    ('44444444-0000-0000-0000-000000000009', 'admin@branchstore.com', 'Branch Store', 'Admin'),
                    ('44444444-0000-0000-0000-000000000010', 'administration@branchstore.com', 'Branch Store', 'Administration'),
                    ('44444444-0000-0000-0000-000000000011', 'manager@branchstore.com', 'Branch Store', 'Manager'),
                    ('44444444-0000-0000-0000-000000000012', 'staff@branchstore.com', 'Branch Store', 'Staff'),
                    ('44444444-0000-0000-0000-000000000013', 'viewer@branchstore.com', 'Branch Store', 'Viewer'),
                    ('44444444-0000-0000-0000-000000000014', 'editor@branchstore.com', 'Branch Store', 'Editor'),
                    ('44444444-0000-0000-0000-000000000015', 'user@branchstore.com', 'Branch Store', 'User'),
                    ('44444444-0000-0000-0000-000000000016', 'admin@wasilshop.com', 'Wasil Shop', 'Admin');

                UPDATE u
                SET u.UserName = x.Email,
                    u.NormalizedUserName = UPPER(x.Email),
                    u.Email = x.Email,
                    u.NormalizedEmail = UPPER(x.Email),
                    u.FirstName = x.FirstName,
                    u.LastName = x.LastName
                FROM AspNetUsers u
                INNER JOIN @Users x ON x.Id = u.Id;

                UPDATE ur
                SET ur.UserName = x.Email
                FROM AspNetUserRoles ur
                INNER JOIN @Users x ON x.Id = ur.UserId;
                """
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                DECLARE @Users TABLE
                (
                    Id nvarchar(450) NOT NULL,
                    UserName nvarchar(256) NOT NULL,
                    Email nvarchar(256) NOT NULL,
                    FirstName nvarchar(256) NULL,
                    LastName nvarchar(256) NULL
                );

                INSERT INTO @Users (Id, UserName, Email, FirstName, LastName)
                VALUES
                    ('44444444-0000-0000-0000-000000000001', 'superadmin', 'superadmin@mainstore.com', 'Super', 'Admin'),
                    ('44444444-0000-0000-0000-000000000002', 'wadmin', 'wadmin@mainstore.com', 'Wholesale', 'Admin'),
                    ('44444444-0000-0000-0000-000000000003', 'wadministration', 'wadministration@mainstore.com', 'Wholesale', 'Administration'),
                    ('44444444-0000-0000-0000-000000000004', 'wmanager', 'wmanager@mainstore.com', 'Wholesale', 'Manager'),
                    ('44444444-0000-0000-0000-000000000005', 'wstaff', 'wstaff@mainstore.com', 'Wholesale', 'Staff'),
                    ('44444444-0000-0000-0000-000000000006', 'wviewer', 'wviewer@mainstore.com', 'Wholesale', 'Viewer'),
                    ('44444444-0000-0000-0000-000000000007', 'weditor', 'weditor@mainstore.com', 'Wholesale', 'Editor'),
                    ('44444444-0000-0000-0000-000000000008', 'wuser', 'wuser@mainstore.com', 'Wholesale', 'User'),
                    ('44444444-0000-0000-0000-000000000009', 'radmin', 'radmin@branchstore.com', 'Retail', 'Admin'),
                    ('44444444-0000-0000-0000-000000000010', 'radministration', 'radministration@branchstore.com', 'Retail', 'Administration'),
                    ('44444444-0000-0000-0000-000000000011', 'rmanager', 'rmanager@branchstore.com', 'Retail', 'Manager'),
                    ('44444444-0000-0000-0000-000000000012', 'rstaff', 'rstaff@branchstore.com', 'Retail', 'Staff'),
                    ('44444444-0000-0000-0000-000000000013', 'rviewer', 'rviewer@branchstore.com', 'Retail', 'Viewer'),
                    ('44444444-0000-0000-0000-000000000014', 'reditor', 'reditor@branchstore.com', 'Retail', 'Editor'),
                    ('44444444-0000-0000-0000-000000000015', 'ruser', 'ruser@branchstore.com', 'Retail', 'User'),
                    ('44444444-0000-0000-0000-000000000016', 'wasil', 'wasil@wasilshop.com', 'Wasil', 'Admin');

                UPDATE u
                SET u.UserName = x.UserName,
                    u.NormalizedUserName = UPPER(x.UserName),
                    u.Email = x.Email,
                    u.NormalizedEmail = UPPER(x.Email),
                    u.FirstName = x.FirstName,
                    u.LastName = x.LastName
                FROM AspNetUsers u
                INNER JOIN @Users x ON x.Id = u.Id;

                UPDATE ur
                SET ur.UserName = x.UserName
                FROM AspNetUserRoles ur
                INNER JOIN @Users x ON x.Id = ur.UserId;
                """
            );
        }
    }
}
