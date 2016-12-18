namespace SurveyOnline.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnswerVariants",
                c => new
                    {
                        AnswerVariantId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        AnswerVariantName = c.String(),
                    })
                .PrimaryKey(t => t.AnswerVariantId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        SurveyId = c.Int(nullable: false),
                        QuestionName = c.String(),
                        QuestionTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        QuestionTypeId = c.Int(nullable: false, identity: true),
                        QuestionTypeName = c.String(),
                        QuestionTypeDescription = c.String(),
                    })
                .PrimaryKey(t => t.QuestionTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.Questions");
            DropTable("dbo.AnswerVariants");
        }
    }
}
