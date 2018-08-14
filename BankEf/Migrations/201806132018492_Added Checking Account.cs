namespace BankEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCheckingAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checkings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Payee = c.String(),
                        Name = c.String(nullable: false, maxLength: 250),
                        ClientName = c.String(nullable: false, maxLength: 100),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AccNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Checkings");
        }
    }
}
