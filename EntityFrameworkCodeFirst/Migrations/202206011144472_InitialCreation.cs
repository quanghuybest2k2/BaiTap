namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        LopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lops", t => t.LopId, cascadeDelete: true)
                .Index(t => t.LopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "LopId", "dbo.Lops");
            DropIndex("dbo.SinhViens", new[] { "LopId" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.Lops");
        }
    }
}
