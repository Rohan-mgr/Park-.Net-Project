namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table : DbMigration
    {
        public override void Up()
        {
            Sql(@"Create table test(
                id int primary key identity(1, 1), 
                name varchar(50) NOT NULL, 
                address varchar(20) NOT NULL
            );"); // for creating table 
        }
        
        public override void Down()
        {
        }
    }
}
