namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "LastName", c => c.String());
        }
    }
}
