

using GestorZeta_DAO.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;                  //Para utilizar o IList

namespace GestorZeta_DAO.Dados
{
    class EntidadeDAO : IDisposable
    {

        private BancoContext contexto;

        //Construtor
        public EntidadeDAO()
        {
            contexto = new BancoContext();
        }

        public void Adicionar(Entidade obj)
        {
            contexto.RS_Entidade.Add(obj);
            contexto.SaveChanges();
        }

        public void Atualizar(Entidade obj)
        {
            contexto.RS_Entidade.Update(obj);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();                 //Para limpar a memoria
        }

        public IList<Entidade> Objs()
        {
            return contexto.RS_Entidade.ToList();
        }

        public void Remover(Entidade obj)
        {
            contexto.RS_Entidade.Remove(obj);
            contexto.SaveChanges();
        }
    }
}
