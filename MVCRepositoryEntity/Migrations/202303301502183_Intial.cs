namespace MVCRepositoryEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        intId = c.Int(nullable: false, identity: true),
                        strName = c.String(nullable: false),
                        strEmail = c.String(nullable: false),
                        strRegNo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.intId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
