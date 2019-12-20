using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportacaoComCsvHelper
{
    public class ItemCsv
    {
        public string status { get; set; }
        public string id { get; set; } 
        public string pedidoExt { get; set; }
        public string referenciaExt { get; set; }
        public string solicitacao { get; set; }
        public string titular { get; set; }
        public string dataAprovacao { get; set; }
        public string situacao { get; set; }
        public string dataSituacao { get; set; }
        public string recusas { get; set; }
        public string email { get; set; }
        public string unidadeExt { get; set; }
        public string unidade { get; set; }
        public string extProduto { get; set; }
        public string extProdutoNome { get; set; }
        public string idusuario { get; set; }
        public string usuario { get; set; }
        public string idcertificado { get; set; }
        public string renovacao { get; set; }
        public string atendimentoexterno { get; set; }
        public string certificado { get; set; }
        public string campo1 { get; set; }
        public string campo2 { get; set; }
        public string campo3 { get; set; }
        public string validade { get; set; }

        public override string ToString()
        {
            return $"{solicitacao};{titular};";
        }
    }
}
