namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BasvuruYapanlars",
                c => new
                    {
                        Basvuruid = c.Int(nullable: false, identity: true),
                        BasvuranName = c.String(maxLength: 30),
                        BasvuranLastName = c.String(maxLength: 40),
                        BasvuranEmail = c.String(maxLength: 50),
                        BasvuranDepartment = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Basvuruid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BasvuruYapanlars");
        }
    }
}
