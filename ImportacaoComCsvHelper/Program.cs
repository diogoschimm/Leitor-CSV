using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportacaoComCsvHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("C:\\Users\\Diogo\\Desktop\\Exemplo.csv"))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<ItemCsv>();
                foreach (var item in records)
                {
                    Console.Write($"{item.status};");
                    Console.Write($"{item.pedidoExt};");
                    Console.Write($"{item.referenciaExt};");
                    Console.Write($"{item.solicitacao};");
                    Console.Write($"{item.titular};");
                    Console.Write($"{item.dataAprovacao};");
                    Console.Write($"{item.situacao};");
                    Console.Write($"{item.dataSituacao};");
                    Console.Write($"{item.recusas};");
                    Console.Write($"{item.email};");
                    Console.Write($"{item.unidadeExt};");
                    Console.Write($"{item.unidade};");
                    Console.Write($"{item.extProduto};");
                    Console.Write($"{item.extProdutoNome};");
                    Console.Write($"{item.idusuario};");
                    Console.Write($"{item.usuario};");
                    Console.Write($"{item.idcertificado};");
                    Console.Write($"{item.renovacao};");
                    Console.Write($"{item.atendimentoexterno};");
                    Console.Write($"{item.certificado};");
                    Console.Write($"{item.campo1};");
                    Console.Write($"{item.campo2};");
                    Console.Write($"{item.campo3};");
                    Console.Write($"{item.validade};");

                    Console.WriteLine("");
                }
                Console.ReadKey();
            }
        }
    }
}
