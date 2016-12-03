namespace PrototypeAdal.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReleaseRequest : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ReleaseRequests");
            AddColumn("dbo.ReleaseRequests", "VersionId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.ReleaseRequests", "Name", c => c.String());
            AddColumn("dbo.ReleaseRequests", "ApprovalStatusId", c => c.Int(nullable: false));
            AddColumn("dbo.ReleaseRequests", "ApprovedBy", c => c.String());
            AddColumn("dbo.ReleaseRequests", "ApprovedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.ReleaseRequests", "BranchId", c => c.Int(nullable: false));
            AddColumn("dbo.ReleaseRequests", "SubmissionDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReleaseRequests", "ReleaseNotes", c => c.String());
            AddPrimaryKey("dbo.ReleaseRequests", "VersionId");
            DropColumn("dbo.ReleaseRequests", "ProductId");
            DropColumn("dbo.ReleaseRequests", "Product");
            DropColumn("dbo.ReleaseRequests", "Branch");
            DropColumn("dbo.ReleaseRequests", "VersionNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReleaseRequests", "VersionNumber", c => c.String(nullable: false));
            AddColumn("dbo.ReleaseRequests", "Branch", c => c.String());
            AddColumn("dbo.ReleaseRequests", "Product", c => c.String(nullable: false));
            AddColumn("dbo.ReleaseRequests", "ProductId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ReleaseRequests");
            AlterColumn("dbo.ReleaseRequests", "ReleaseNotes", c => c.String(nullable: false));
            DropColumn("dbo.ReleaseRequests", "SubmissionDateTime");
            DropColumn("dbo.ReleaseRequests", "BranchId");
            DropColumn("dbo.ReleaseRequests", "ApprovedDateTime");
            DropColumn("dbo.ReleaseRequests", "ApprovedBy");
            DropColumn("dbo.ReleaseRequests", "ApprovalStatusId");
            DropColumn("dbo.ReleaseRequests", "Name");
            DropColumn("dbo.ReleaseRequests", "VersionId");
            AddPrimaryKey("dbo.ReleaseRequests", "ProductId");
        }
    }
}
