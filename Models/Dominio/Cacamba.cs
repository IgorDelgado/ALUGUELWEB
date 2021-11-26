using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Dominio
{
    public class Cacamba
    {
        [Key]  //metadados
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }
        public string Tamanho { get; set; }
        public string Codigo { get; set; }
        public string Observacao { get; set; }
    }

}
