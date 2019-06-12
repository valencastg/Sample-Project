namespace MVCAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name_required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactGVCs", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactGVCs", "Name", c => c.String());
        }
    }
}
