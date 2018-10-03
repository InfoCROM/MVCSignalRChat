namespace MVCSignalRChatSolution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigraciónInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Connections",
                c => new
                    {
                        ConnectionID = c.String(nullable: false, maxLength: 4000),
                        UserAgent = c.String(maxLength: 4000),
                        Connected = c.Boolean(nullable: false),
                        User_UserId = c.Guid(),
                    })
                .PrimaryKey(t => t.ConnectionID)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Connections", "User_UserId", "dbo.Users");
            DropIndex("dbo.Connections", new[] { "User_UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Connections");
        }
    }
}
