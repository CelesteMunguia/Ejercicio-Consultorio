namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaCita : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MCita",
                c => new
                    {
                        CitaId = c.Int(nullable: false, identity: true),
                        MedicoId = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                        FechaCita = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CitaId)
                .ForeignKey("dbo.MMedico", t => t.MedicoId)
                .ForeignKey("dbo.MPaciente", t => t.PacienteId)
                .Index(t => t.MedicoId)
                .Index(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MCita", "PacienteId", "dbo.MPaciente");
            DropForeignKey("dbo.MCita", "MedicoId", "dbo.MMedico");
            DropIndex("dbo.MCita", new[] { "PacienteId" });
            DropIndex("dbo.MCita", new[] { "MedicoId" });
            DropTable("dbo.MCita");
        }
    }
}
