namespace RevisaoWEBApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTabelaUsuarios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 16));
        }
    }
}
