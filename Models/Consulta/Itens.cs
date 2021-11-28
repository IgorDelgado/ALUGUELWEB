using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Consulta
{
    public class Itens
    {

        public int ID { get; set; } // ID ALUGA
        public string NomeCliente { get; set; } // Nome Cliente
        public DateTime Data_aluguel { get; set; } //data aluguel Aluga
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Tamanho { get; set; } // Tamanho Cacamba
        public string Codigo { get; set; } // Codigo Cacamba
        public string Observacao { get; set; } // OBS Cacamba

        public string NomeColaborador { get; set; } // Nome colab

        public DateTime Data_devolucao { get; set; }  // data entrega aluga

        public float Valor { get; set; } // valor aluga
    }




}

