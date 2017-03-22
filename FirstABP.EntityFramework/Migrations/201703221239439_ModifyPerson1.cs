namespace FirstABP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPerson1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "CreateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "CreateDate");
        }
    }
}
