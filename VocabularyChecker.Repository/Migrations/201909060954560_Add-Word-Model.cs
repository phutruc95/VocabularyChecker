namespace VocabularyChecker.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWordModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        English = c.String(),
                        VietnameseMeaning = c.String(),
                        PartOfSpeech = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Words");
        }
    }
}
