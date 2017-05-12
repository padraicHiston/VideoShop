namespace VideoShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'655eb516-07fa-4590-87b6-3803f3b47fce', N'guest@videoshop.com', 0, N'AIhtR8i92cusX0i7UsXa8P1eM2QirjCi55Cb30r2wcRlnP7w0V3+++pAbdfamLiaaA==', N'533a30d4-3917-4ba2-ab55-c9defac216b2', NULL, 0, 0, NULL, 1, 0, N'guest@videoshop.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e1f0eb1e-ff9d-4d44-8a90-bcef6523fbab', N'admin@videoshop.com', 0, N'AHnad9VZ52CobiLXNrvG7bnFSRYx8VI43Yw5Fm23xqTXVqJCqIt7vI9qas5WBjjmHA==', N'b1352008-cc3a-4b89-b5db-9a239659c492', NULL, 0, 0, NULL, 1, 0, N'admin@videoshop.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58e0a91b-3da1-4be2-9fc6-3eef4540e34e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e1f0eb1e-ff9d-4d44-8a90-bcef6523fbab', N'58e0a91b-3da1-4be2-9fc6-3eef4540e34e')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
