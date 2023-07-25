namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_footer_contact_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FooterContacts",
                c => new
                    {
                        FooterID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.FooterID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FooterContacts");
        }
    }
}
