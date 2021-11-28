using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Dominio
{
    public class Aluga
    {
        [Key]  //metadados
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }
        public string NomeCliente { get; set; }
        public string Tamanho { get; set; }
        public string Codigo { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_aluguel { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }

        public DateTime Data_devolucao { get; set; }
        public float Valor { get; set; }
        public string NomeColaborador { get; set; }
        
        public string Cacamba { get; }        

    }
}
