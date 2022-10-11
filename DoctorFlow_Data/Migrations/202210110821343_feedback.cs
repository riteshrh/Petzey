namespace DoctorFlow_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feedback : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedback",
                c => new
                    {
                        Feedback_ID = c.Long(nullable: false, identity: true),
                        App_ID = c.Long(),
                        Comp_level = c.Int(),
                        Doctor_Rating = c.Int(),
                        Booking_Process = c.Int(),
                        Outcome = c.Int(),
                    })
                .PrimaryKey(t => t.Feedback_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feedback");
        }
    }
}
