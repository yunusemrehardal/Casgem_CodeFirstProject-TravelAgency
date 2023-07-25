namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_social_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocialMedias", "Icon");
        }
    }
}
