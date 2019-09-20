namespace VocabularyChecker.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Exercise : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        KeyWord = c.String(),
                        WordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Words", t => t.WordId, cascadeDelete: true)
                .Index(t => t.WordId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exercises", "WordId", "dbo.Words");
            DropIndex("dbo.Exercises", new[] { "WordId" });
            DropTable("dbo.Exercises");
        }
    }
}
