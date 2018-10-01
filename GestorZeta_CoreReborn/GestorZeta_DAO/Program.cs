
using GestorZeta_DAO.Dados;
using GestorZeta_DAO.Extensions;
using GestorZeta_DAO.Negocio;
using System;
using System.Linq;  //Para utilizar o .First

namespace GestorZeta_DAO
{
    class Program
    {
        static void Main(string[] args)
        {

            Incluir_Entidade();

            //Exibir_Entidade();

            //Excluir_Entidade();

            //Editar_Entidade();

            Console.ReadLine();

            //using (var contexto = new BancoContext())
            //{
            //    contexto.LogSQLToConsole();                            

            //    foreach (var entidade in contexto.RS_Entidade)
            //    {
            //        Console.WriteLine(entidade);                                    
            //    }

            //    Console.ReadLine();
            //    //Console.ReadKey();

            //}

        }

        //EXIBIR TODOS OS REGISTROS
        private static void Exibir_Entidade()
        {
            using (var contexto = new BancoContext())
            {

                contexto.LogSQLToConsole();

                Console.WriteLine("\n Mostrando Todos os Registros...");

                var obj = contexto.RS_Entidade;

                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }                               

            }
        }

        //INCLUIR REGISTRO
        private static void Incluir_Entidade()
        {
            using (var contexto = new BancoContext())
            {
                contexto.LogSQLToConsole();

                var obj_Entidade = new Entidade();                      //Criando obj do Tipo Entidade
                var obj_EntidadeDAO = new EntidadeDAO();
                
                obj_Entidade.DATA_ULT_ALT = new DateTime(2017, 1, 1);   //Inserindo os Dados no obj
                obj_Entidade.RazaoSocial = "BRUNO XISSSS";
                obj_Entidade.Fantasia = "XISSSS";

                obj_EntidadeDAO.Adicionar(obj_Entidade);                //Chamando as funções da ClasseDAO                     

            }
        }

        //EXCLUIR REGISTRO
        private static void Excluir_Entidade()
        {
            using (var contexto = new BancoContext())
            {
                contexto.LogSQLToConsole();

                var obj_Entidade = contexto                      //Criando obj do Tipo RS_Entidade
                    .RS_Entidade
                    .First();

                var obj_EntidadeDAO = new EntidadeDAO();

                Console.WriteLine(obj_Entidade);
                
                obj_EntidadeDAO.Remover(obj_Entidade);                //Chamando as funções da ClasseDAO                     

            }
        }

        #region ATUALIZAR REGISTRO  
        //ATUALIZAR REGISTRO
        private static void Editar_Entidade()
        {
            using (var contexto = new BancoContext())
            {
                contexto.LogSQLToConsole();

                var obj_Entidade = contexto                      //Criando obj do Tipo RS_Entidade
                    .RS_Entidade
                    .First();                

                var obj_EntidadeDAO = new EntidadeDAO();

                obj_Entidade.RazaoSocial = "NOVA RAZAO SOCIAL";

                Console.WriteLine(obj_Entidade);

                obj_EntidadeDAO.Atualizar(obj_Entidade);                //Chamando as funções da ClasseDAO                     

            }
        }
        #endregion

    }
}
