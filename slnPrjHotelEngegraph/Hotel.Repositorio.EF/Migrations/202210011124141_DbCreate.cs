namespace Hotel.Repositorio.EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckOut",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataCheckOut = c.DateTime(nullable: false),
                        OcupacaoId = c.Guid(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ocupacao", t => t.OcupacaoId)
                .Index(t => t.OcupacaoId);
            
            CreateTable(
                "dbo.Lancamentos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Valor = c.Double(nullable: false),
                        TipoPagtoId = c.Guid(nullable: false),
                        CheckOutId = c.Guid(nullable: false),
                        Conta = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckOut", t => t.CheckOutId)
                .ForeignKey("dbo.TipoPagto", t => t.TipoPagtoId)
                .Index(t => t.TipoPagtoId)
                .Index(t => t.CheckOutId);
            
            CreateTable(
                "dbo.TipoPagto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 40, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ocupacao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataCheckIn = c.DateTime(nullable: false),
                        Situacao = c.Int(nullable: false),
                        ReservaId = c.Guid(nullable: false),
                        UhId = c.Guid(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reserva", t => t.ReservaId)
                .ForeignKey("dbo.Uh", t => t.UhId)
                .Index(t => t.ReservaId)
                .Index(t => t.UhId);
            
            CreateTable(
                "dbo.Reserva",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomeSolicitante = c.String(nullable: false, maxLength: 40, unicode: false),
                        TelefoneSolicitante = c.String(nullable: false, maxLength: 15, unicode: false),
                        DataCheckIn = c.DateTime(nullable: false),
                        DataCheckOut = c.DateTime(nullable: false),
                        QtdeAdt = c.Int(nullable: false),
                        QtdeChd = c.Int(nullable: false),
                        TipoUhId = c.Guid(nullable: false),
                        Observacoes = c.String(maxLength: 200, unicode: false),
                        Situacao = c.Int(nullable: false),
                        EMailSolicitante = c.String(nullable: false, maxLength: 100, unicode: false),
                        Localizador = c.String(nullable: false, maxLength: 12, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoUh", t => t.TipoUhId)
                .Index(t => t.TipoUhId);
            
            CreateTable(
                "dbo.TipoUh",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 40, unicode: false),
                        QtdeAdt = c.Int(nullable: false),
                        QtdeChd = c.Int(nullable: false),
                        ValorDiaria = c.Double(nullable: false),
                        ValorAdicional = c.Double(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uh",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Numero = c.String(maxLength: 15, unicode: false),
                        Bloco = c.String(maxLength: 15, unicode: false),
                        Nivel = c.String(maxLength: 15, unicode: false),
                        TipoUhId = c.Guid(nullable: false),
                        Situacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoUh", t => t.TipoUhId)
                .Index(t => t.TipoUhId);
            
            CreateTable(
                "dbo.Configuracao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Codigo = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 75, unicode: false),
                        Valor = c.String(nullable: false, maxLength: 400, unicode: false),
                        Tipo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hospede",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 40, unicode: false),
                        SobreNome = c.String(nullable: false, maxLength: 40, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Genero = c.Int(nullable: false),
                        NumeroDocumento = c.String(nullable: false, maxLength: 40, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 15, unicode: false),
                        Endereco = c.String(nullable: false, maxLength: 200, unicode: false),
                        IsEstrangeiro = c.Boolean(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HospedeOcupacao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HospedeId = c.Guid(nullable: false),
                        OcupacaoId = c.Guid(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hospede", t => t.HospedeId)
                .ForeignKey("dbo.Ocupacao", t => t.OcupacaoId)
                .Index(t => t.HospedeId)
                .Index(t => t.OcupacaoId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(nullable: false, maxLength: 40, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 200, unicode: false),
                        EMail = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Tentativas = c.Int(nullable: false),
                        DataExpiracao = c.DateTime(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HospedeOcupacao", "OcupacaoId", "dbo.Ocupacao");
            DropForeignKey("dbo.HospedeOcupacao", "HospedeId", "dbo.Hospede");
            DropForeignKey("dbo.CheckOut", "OcupacaoId", "dbo.Ocupacao");
            DropForeignKey("dbo.Ocupacao", "UhId", "dbo.Uh");
            DropForeignKey("dbo.Ocupacao", "ReservaId", "dbo.Reserva");
            DropForeignKey("dbo.Reserva", "TipoUhId", "dbo.TipoUh");
            DropForeignKey("dbo.Uh", "TipoUhId", "dbo.TipoUh");
            DropForeignKey("dbo.Lancamentos", "TipoPagtoId", "dbo.TipoPagto");
            DropForeignKey("dbo.Lancamentos", "CheckOutId", "dbo.CheckOut");
            DropIndex("dbo.HospedeOcupacao", new[] { "OcupacaoId" });
            DropIndex("dbo.HospedeOcupacao", new[] { "HospedeId" });
            DropIndex("dbo.Uh", new[] { "TipoUhId" });
            DropIndex("dbo.Reserva", new[] { "TipoUhId" });
            DropIndex("dbo.Ocupacao", new[] { "UhId" });
            DropIndex("dbo.Ocupacao", new[] { "ReservaId" });
            DropIndex("dbo.Lancamentos", new[] { "CheckOutId" });
            DropIndex("dbo.Lancamentos", new[] { "TipoPagtoId" });
            DropIndex("dbo.CheckOut", new[] { "OcupacaoId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.HospedeOcupacao");
            DropTable("dbo.Hospede");
            DropTable("dbo.Configuracao");
            DropTable("dbo.Uh");
            DropTable("dbo.TipoUh");
            DropTable("dbo.Reserva");
            DropTable("dbo.Ocupacao");
            DropTable("dbo.TipoPagto");
            DropTable("dbo.Lancamentos");
            DropTable("dbo.CheckOut");
        }
    }
}
