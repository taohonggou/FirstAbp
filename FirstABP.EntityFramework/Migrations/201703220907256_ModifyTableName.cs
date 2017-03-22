namespace FirstABP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTableName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Province_Id", c => c.Int());
            CreateIndex("dbo.People", "Province_Id");
            AddForeignKey("dbo.People", "Province_Id", "dbo.Provinces", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Province_Id", "dbo.Provinces");
            DropIndex("dbo.People", new[] { "Province_Id" });
            DropColumn("dbo.People", "Province_Id");
            DropTable("dbo.Provinces");
        }
    }
}
