namespace SurveyOnline.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsurveycontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        SurveyName = c.String(nullable: false, maxLength: 250),
                        SurveyDescription = c.String(nullable: false),
                        SurveyStatus = c.Boolean(nullable: false),
                        SurveyUrl = c.String(nullable: false, maxLength: 50),
                        UserId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surveys");
        }
    }
}
