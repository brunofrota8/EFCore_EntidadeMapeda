

using GestorZeta_DAO.Negocio;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace GestorZeta_DAO.Dados
{
    class BancoContext : DbContext
    {

        private SqlConnection conexao;

        //Um DbSet por tabela    
        public DbSet<Entidade> RS_Entidade { get; set; }


        //Contexto do Banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ////No Servidor. Utilizando [using System.Data.SqlClient;] 
            //optionsBuilder.UseSqlServer(conexao = new SqlConnection());
            //conexao.ConnectionString = @"DATA SOURCE= SERVIDOR\FONTES;
            //                                INITIAL CATALOG= GESTOR_Z_PESQUISA;
            //                                             USER= gestor; 
            //                                         PASSWORD= gestor;";

            //No Notebook
            //optionsBuilder.UseSqlServer(@"DATA SOURCE=BFNOTE\SQLEXPRESS2008R2; 
            //                                   INITIAL CATALOG=GESTOR_Z;
            //                                   USER=gestor; PASSWORD=gestor;");

            ////No Servidor
            //optionsBuilder.UseSqlServer(@"DATA SOURCE=SERVIDOR\FONTES; 
            //                                   INITIAL CATALOG=GESTOR_Z;
            //                                   USER=gestor; PASSWORD=gestor;");

            //Não Funciou
            ////https://www.connectionstrings.com/sql-server-2008/
            //optionsBuilder.UseSqlServer(@"Server=192.168.0.200\\FONTES;
            //                                   Database=GESTOR_Z;
            //                                      User Id=gestor;
            //                                 Password=gestor;");

            //Funciona somente com o Servidor na rede
            //https://github.com/dotnet/corefx/issues/24175
            optionsBuilder.UseSqlServer(@"Data Source=192.168.0.200,1433;
                                                Initial Catalog=GESTOR_Z_PESQUISA;
                                                          User ID=gestor;
                                                        Password=gestor");

        }

        //Contrutor de cada Builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntidadeConfiguration());
        }


    }
}
