namespace SurveyOnline.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SelectedAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "SelectedAnswer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "SelectedAnswer");
        }
    }
}
