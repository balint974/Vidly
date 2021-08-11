namespace Vidly_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'889440e5-91aa-4ea0-8bd7-b1ce8de6ec94', N'balint97@yahoo.com', 0, N'AD7LbQC4xH0Xs+i4QwSbscq2228ozeSSSoLxpt30WuQA+0HQFmoetaCc6prbeX+BAg==', N'bd73b39c-c42a-457a-9d97-eada477e44d1', NULL, 0, 0, NULL, 1, 0, N'balint97@yahoo.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'919d4638-6dd1-4b81-8ad7-42ee5af55ef2', N'admin@vidly.com', 0, N'ANPB7OEi8EOwbEUOVdS4/eceivDBFO0ek4lqbbgjBO4xZNzqztipNP22Fq66u19VCQ==', N'2b4e2dc8-ec30-4cc2-9583-88e39fe48250', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9555588d-7549-4f7e-954a-2ca2cbeacd90', N'guest@yahoo.com', 0, N'AL1zim+A9p1SApLDfnyOEcPosq+skdaqQxQmd+5KpcrdyONjwfm3gsk7nrHpsX794w==', N'0ffd8892-ed15-4068-a6b1-53233b89ad2a', NULL, 0, 0, NULL, 1, 0, N'guest@yahoo.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b2470ee6-6aef-4961-b1ab-8e8830dd88e6', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'919d4638-6dd1-4b81-8ad7-42ee5af55ef2', N'b2470ee6-6aef-4961-b1ab-8e8830dd88e6')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
