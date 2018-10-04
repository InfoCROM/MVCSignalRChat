namespace MVCSignalRChatSolution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectionId_unica_en_Users : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Connections", "User_UserId", "dbo.Users");
            DropIndex("dbo.Connections", new[] { "User_UserId" });
            AddColumn("dbo.Users", "ConnectionId", c => c.String(maxLength: 4000));
            DropColumn("dbo.Connections", "User_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Connections", "User_UserId", c => c.Guid());
            DropColumn("dbo.Users", "ConnectionId");
            CreateIndex("dbo.Connections", "User_UserId");
            AddForeignKey("dbo.Connections", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
