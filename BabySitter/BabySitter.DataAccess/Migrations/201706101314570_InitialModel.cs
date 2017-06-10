namespace BabySitter.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInformation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResumeId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        DetailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Resume", t => t.ResumeId, cascadeDelete: true)
                .Index(t => t.ResumeId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Resume",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ResumeName = c.String(nullable: false),
                        SubmittedDate = c.DateTime(),
                        Status = c.Short(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonalInformation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResumeId = c.Int(nullable: false),
                        Nationality = c.Short(nullable: false),
                        Gender = c.Short(nullable: false),
                        MobilePhone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resume", t => t.ResumeId, cascadeDelete: true)
                .Index(t => t.ResumeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonalInformation", "ResumeId", "dbo.Resume");
            DropForeignKey("dbo.ContactInformation", "ResumeId", "dbo.Resume");
            DropForeignKey("dbo.ContactInformation", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "CountryId", "dbo.Country");
            DropIndex("dbo.PersonalInformation", new[] { "ResumeId" });
            DropIndex("dbo.ContactInformation", new[] { "CityId" });
            DropIndex("dbo.ContactInformation", new[] { "ResumeId" });
            DropIndex("dbo.City", new[] { "CountryId" });
            DropTable("dbo.PersonalInformation");
            DropTable("dbo.Resume");
            DropTable("dbo.ContactInformation");
            DropTable("dbo.Country");
            DropTable("dbo.City");
        }
    }
}
