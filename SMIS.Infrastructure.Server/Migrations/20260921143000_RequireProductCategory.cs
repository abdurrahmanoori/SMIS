using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMIS.Infrastructure.Server.Migrations
{
    public partial class RequireProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                UPDATE p
                SET CategoryId = replacement.Id
                FROM Product AS p
                CROSS APPLY (
                    SELECT TOP (1) c.Id
                    FROM Category AS c
                    WHERE c.ShopId = p.ShopId
                      AND c.IsDeleted = 0
                    ORDER BY NEWID()
                ) AS replacement
                WHERE p.CategoryId IS NULL;

                IF EXISTS (SELECT 1 FROM Product WHERE CategoryId IS NULL)
                    THROW 50001, 'Cannot require Product.CategoryId because at least one product has no valid category in its shop.', 1;

                IF EXISTS (
                    SELECT 1
                    FROM sys.foreign_keys
                    WHERE name = 'FK_Product_Category_CategoryId'
                      AND parent_object_id = OBJECT_ID('Product')
                )
                    ALTER TABLE Product DROP CONSTRAINT FK_Product_Category_CategoryId;

                IF NOT EXISTS (
                    SELECT 1
                    FROM sys.check_constraints
                    WHERE name = 'CK_Product_CategoryId_Required'
                      AND parent_object_id = OBJECT_ID('Product')
                )
                    ALTER TABLE Product WITH CHECK
                    ADD CONSTRAINT CK_Product_CategoryId_Required
                    CHECK (CategoryId IS NOT NULL);

                ALTER TABLE Product CHECK CONSTRAINT CK_Product_CategoryId_Required;

                ALTER TABLE Product
                    ADD CONSTRAINT FK_Product_Category_CategoryId
                    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
                    ON DELETE NO ACTION;
                """);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                IF EXISTS (
                    SELECT 1
                    FROM sys.foreign_keys
                    WHERE name = 'FK_Product_Category_CategoryId'
                      AND parent_object_id = OBJECT_ID('Product')
                )
                    ALTER TABLE Product DROP CONSTRAINT FK_Product_Category_CategoryId;

                IF EXISTS (
                    SELECT 1
                    FROM sys.check_constraints
                    WHERE name = 'CK_Product_CategoryId_Required'
                      AND parent_object_id = OBJECT_ID('Product')
                )
                    ALTER TABLE Product DROP CONSTRAINT CK_Product_CategoryId_Required;

                ALTER TABLE Product
                    ADD CONSTRAINT FK_Product_Category_CategoryId
                    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
                    ON DELETE SET NULL;
                """);
        }
    }
}
