
using GestorZeta_DAO.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorZeta_DAO.Dados
{
    class EntidadeConfiguration : IEntityTypeConfiguration<Entidade>
    {
        public void Configure(EntityTypeBuilder<Entidade> builder)
        {
            //Nome da Tabela no Banco de Dados
            builder
                .ToTable("ENTIDADE");

            ////Indicando qual é o campo Chave Primária para o Entity
            //builder
            //    .HasKey("ID_ENTIDADE");

            // Mapeando campos:
            ///////////////////////////////////////////////////////////////////////////////////

            builder
               .Property(c => c.EntidadeId)             //-->> Campo da Classe
               .HasColumnName("ID_ENTIDADE");           //-->> Campo do Banco

            builder
                .Property(c => c.EmpresaId)
                .HasColumnName("ID_EMPRESA")
                .HasDefaultValue(0);

            builder
                .Property(c => c.Entidade_TranspId)
                .HasColumnName("ID_ENTIDADE_TRANSP")
                .HasDefaultValue(0);

            builder
                .Property(c => c.Forma_PgtoId)
                .HasColumnName("ID_FORMA_PGTO")
                .HasDefaultValue(0);

            builder
               .Property(c => c.Seg_MercadoId)
               .HasColumnName("ID_SEG_MERCADO")
               .HasDefaultValue(0);

            builder
               .Property(c => c.CRTId)
               .HasColumnName("ID_CRT")
               .HasDefaultValue(0);

            builder
                .Property(c => c.DATA_ULT_ALT)
                .HasColumnType("datetime");

            builder
                .Property(c => c.HORA_ULT_ALT)
                .HasColumnType("datetime");

            builder
                .Property(c => c.USUARIO_ULT_ALT)
                .HasColumnType("nvarchar(120)");

            builder
               .Property(c => c.DATA_CADASTRO)
               .HasColumnType("datetime");

            builder
               .Property(c => c.USUARIO_CADASTRO)
               .HasColumnType("nvarchar(120)");

            builder
               .Property(c => c.OBS)
               .HasColumnType("nvarchar(max)");

            builder
               .Property(c => c.EXCLUIDO)
               .HasDefaultValue(0);

            builder
              .Property(c => c.RazaoSocial)
              .HasColumnType("nvarchar(120)");

            builder
              .Property(c => c.Fantasia)
              .HasColumnType("nvarchar(120)");

            builder
              .Property(c => c.CNPJ)
              .HasColumnType("nvarchar(30)");

            builder
              .Property(c => c.IE)
              .HasColumnType("nvarchar(30)");

            builder
              .Property(c => c.IE_SUBS)
              .HasColumnType("nvarchar(30)");

            builder
              .Property(c => c.Contribuinte_ICMS)
              .HasDefaultValue(0);

            builder
              .Property(c => c.Tipo_Fornecedor)
              .HasDefaultValue(0);

            builder
              .Property(c => c.Tipo_Funcionario)
              .HasDefaultValue(0);

            builder
              .Property(c => c.Tipo_Cliente)
              .HasDefaultValue(0);

            builder
              .Property(c => c.Data_Abertura)
              .HasColumnType("datetime");


            builder
              .Property(c => c.Inscr_Municipal)
              .HasColumnType("nvarchar(30)");

            builder
              .Property(c => c.CNAE)
              .HasColumnType("nvarchar(30)");

            builder
              .Property(c => c.Inscr_Suframa)
              .HasColumnType("float");

            builder
              .Property(c => c.Telefone)
              .HasColumnType("nvarchar(50)");

            builder
              .Property(c => c.Fax)
              .HasColumnType("nvarchar(50)");

            builder
              .Property(c => c.Email_NFe)
              .HasColumnType("nvarchar(max)");

            builder
              .Property(c => c.Email)
              .HasColumnType("nvarchar(max)");

            builder
              .Property(c => c.Site)
              .HasColumnType("nvarchar(max)");

            builder
              .Property(c => c.Bloqueado)
              .HasDefaultValue(0);

            builder
              .Property(c => c.Credito_Pre_Aprovado)
              .HasColumnType("float");

            builder
              .Property(c => c.Comissao)
              .HasColumnType("float");



            //Exemplos
            //builder
            //    .Property(a => a.UltimoNome)
            //    .HasColumnName("last_name")
            //    .HasColumnType("varchar(45)")
            //    .IsRequired();

            //builder
            //    .Property<DateTime>("last_update")    -->> Shadown
            //    .HasColumnType("datetime")
            //    .HasDefaultValueSql("getdate()")
            //    .IsRequired();

        }

    }
}
