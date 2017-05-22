namespace VideoShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7481ef03-e560-407b-8b5b-1bd6fa405817', N'admin@videoshop.com', 0, N'AD+DEBJGq/5OdEpJFd3lM0PUPLgVYwz21BcZN6FYhsD8PwmxCsOo1WfOtfPFeM1f+A==', N'f19042db-2ccc-435e-87f4-9750f81d86f5', NULL, 0, 0, NULL, 1, 0, N'admin@videoshop.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eb458fab-9d0d-4222-a2aa-21a38b7c02f1', N'guest@videoshop.com', 0, N'AM/HMv52v7mi9tkxZABOXFHwQeQE7Y9poMnmhVFDmr+OHEiTGeO3WJuYLEeAUyoEbg==', N'0f1ba16d-6491-4e90-bb5e-39b473d07116', NULL, 0, 0, NULL, 1, 0, N'guest@videoshop.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58e0a91b-3da1-4be2-9fc6-3eef4540e34e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7481ef03-e560-407b-8b5b-1bd6fa405817', N'58e0a91b-3da1-4be2-9fc6-3eef4540e34e')

");
        }
        
        public override void Down()
        {
        }
    }
}
