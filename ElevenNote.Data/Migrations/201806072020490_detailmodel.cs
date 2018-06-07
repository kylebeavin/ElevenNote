namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class detailmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
            DropColumn("dbo.Note", "ModifidUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "ModifidUtc", c => c.DateTimeOffset(precision: 7));
            DropColumn("dbo.Note", "ModifiedUtc");
        }
    }
}
