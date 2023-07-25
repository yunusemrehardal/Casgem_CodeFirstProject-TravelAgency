namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_contactsocial_migg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactSocials",
                c => new
                    {
                        ContactSocialID = c.Int(nullable: false, identity: true),
                        ContactSocialName = c.String(),
                        ContactSocialURL = c.String(),
                        ContactSocialIcon = c.String(),
                    })
                .PrimaryKey(t => t.ContactSocialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactSocials");
        }
    }
}
