namespace Hotel.Repositorio.EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cria_coluna_data_casamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospede", "DataCasamento", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hospede", "DataCasamento");
        }
    }
}
