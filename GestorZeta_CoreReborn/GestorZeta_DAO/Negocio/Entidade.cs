

using System;

namespace GestorZeta_DAO.Negocio
{
    class Entidade
    {

        public int EntidadeId { get; set; }             //Para a chave primária não pode separar com o "_"
        public int? EmpresaId { get; set; }
        public int? Entidade_TranspId { get; set; }
        public int? Forma_PgtoId { get; set; }
        public int? Seg_MercadoId { get; set; }
        public int? CRTId { get; set; }

        public DateTime? DATA_ULT_ALT { get; set; }
        public DateTime? HORA_ULT_ALT { get; set; }
        public string USUARIO_ULT_ALT { get; set; }
        public DateTime? DATA_CADASTRO { get; set; }
        public string USUARIO_CADASTRO { get; set; }
        public string OBS { get; set; }
        public Boolean EXCLUIDO { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string IE_SUBS { get; set; }
        public Boolean Contribuinte_ICMS { get; set; }
        public Boolean Tipo_Fornecedor { get; set; }
        public Boolean Tipo_Funcionario { get; set; }
        public Boolean Tipo_Cliente { get; set; }
        public DateTime? Data_Abertura { get; set; }
        public string Inscr_Municipal { get; set; }
        public string CNAE { get; set; }
        public Double? Inscr_Suframa { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Email_NFe { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public Boolean Bloqueado { get; set; }
        public Double? Credito_Pre_Aprovado { get; set; }
        public Double? Comissao { get; set; }

        public override string ToString()
        {
            return $"Entidade ({EntidadeId}): {RazaoSocial} -- {Fantasia}";
        }

    }

}
