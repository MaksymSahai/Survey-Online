namespace SurveyOnline.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuestionnaire : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        QuestionnaireId = c.Int(nullable: false, identity: true),
                        SurveyId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        AnswerVariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionnaireId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questionnaires");
        }
    }
}
