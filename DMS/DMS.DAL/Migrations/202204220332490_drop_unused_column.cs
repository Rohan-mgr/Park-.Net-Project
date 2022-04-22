//namespace DMS.DAL.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class drop_unused_column : DbMigration
//    {
//        public override void Up()
//        {
//            DropForeignKey("emp01employee", "emp01des01uin", "des01designations");
//            DropForeignKey("emp01employee", "emp01dep01uin", "dep01department");
//            DropForeignKey("emp01employee", "emp01lvl01uin", "lvl01employee_levels");
//            DropForeignKey("emp01employee", "emp01bra01uin", "bra01branches");
//            DropForeignKey("usr05users", "usr05bra01uin", "bra01branches");
//            Sql("Alter table emp01employee drop column emp01des01uin");
//            Sql("Alter table emp01employee drop column emp01dep01uin");
//            Sql("Alter table emp01employee drop column emp01lvl01uin");
//            Sql("Alter table emp01employee drop column emp01bra01uin");
//            Sql("Alter table usr05users drop column usr05bra01uin");
//        }
        
//        public override void Down()
//        {
//        }
//    }
//}
