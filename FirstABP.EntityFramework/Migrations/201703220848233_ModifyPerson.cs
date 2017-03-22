namespace FirstABP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPerson : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Name", c => c.String());
        }
    }
}
