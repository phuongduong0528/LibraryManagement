namespace LibraryManagement.DbManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumn_NgaySinh_T_NQL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguoiQL", "NgaySinh", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguoiQL", "NgaySinh");
        }
    }
}
