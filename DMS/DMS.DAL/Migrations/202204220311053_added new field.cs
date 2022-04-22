namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednewfield : DbMigration
    {
        public override void Up()
        {
            Sql(@"alter table usr05users add isAdmin bit");
        }
        
        public override void Down()
        {
        }
    }
}
