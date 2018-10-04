namespace MVCSignalRChatSolution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageIdNuevoCampo_en_Users : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImageId", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ImageId");
        }
    }
}
