namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_12451122 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FooterGaleries",
                c => new
                    {
                        FooterGaleryID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.FooterGaleryID);
            
            CreateTable(
                "dbo.FooterTravelTrips",
                c => new
                    {
                        FooterTravelTripID = c.Int(nullable: false, identity: true),
                        FooterTravelTripName = c.String(),
                    })
                .PrimaryKey(t => t.FooterTravelTripID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FooterTravelTrips");
            DropTable("dbo.FooterGaleries");
        }
    }
}
