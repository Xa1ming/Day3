namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_userLogin",
                c => new
                    {
                        U_id = c.Guid(nullable: false),
                        UL_Name = c.String(maxLength: 30),
                        UL_Pwd = c.String(maxLength: 100),
                        UL_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.U_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_userLogin");
        }
    }
}
