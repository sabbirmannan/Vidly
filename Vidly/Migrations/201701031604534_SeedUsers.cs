namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e35709f-b92b-4842-a716-26284e5c3e9e', N'admin@vidly.com', 0, N'AEqdQOBgM4Cf9FiQR/nEScPP47USC3k+Xc3eVyFAreXYJnQ1HCxsOjtsITa50aPcAQ==', N'db5a7863-c7f9-42ec-83ee-49b56f0cf869', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a8820440-0529-43fc-bfce-58b7c92a6272', N'guest@vidly.com', 0, N'AAAKt8WMyaRDgwxCVadKwc7PHt4397mMh8qXM6kFmMtEH2EAdv5KXFkWAPi9Irin3w==', N'48efd641-c305-483e-b490-ad57d781c85d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'162f0d9f-7687-42ff-85c0-9aacc598f5c3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e35709f-b92b-4842-a716-26284e5c3e9e', N'162f0d9f-7687-42ff-85c0-9aacc598f5c3')

");
        }

        public override void Down()
        {
        }
    }
}
