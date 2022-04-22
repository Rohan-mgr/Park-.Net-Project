namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropped_unused_table : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.des01designations");
            DropTable("dbo.dep01department");
            DropTable("dbo.lvl01employee_levels");
            DropTable("dbo.bra01branches");
        }
        
        public override void Down()
        {
        }
    }
}
