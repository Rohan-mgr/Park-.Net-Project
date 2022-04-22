namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class drop_unused_column : DbMigration
    {
        public override void Up()
        {
            Sql(@"Alter table emp01employee drop constraint FK_emp01employee_des01designations");
            Sql(@"Alter table emp01employee drop constraint FK_emp01employee_dep01department");
            Sql(@"Alter table emp01employee drop constraint FK_emp01employee_lvl01employee_levels");
            Sql(@"Alter table emp01employee drop constraint FK_emp01employee_bra01branches");
            Sql(@"Alter table usr05users drop constraint FK_usr05users_bra01branches");
            Sql("Alter table emp01employee drop column emp01des01uin");
            Sql("Alter table emp01employee drop column emp01dep01uin");
            Sql("Alter table emp01employee drop column emp01lvl01uin");
            Sql("Alter table emp01employee drop column emp01bra01uin");
            Sql("Alter table usr05users drop column usr05bra01uin");
        }

        public override void Down()
        {
        }
    }
}
