namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Note", "ModifidUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "ModifidUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
