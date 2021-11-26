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
        public  Cliente NomeCliente{ get; set; }
        public int ClienteID { get; set; }
        public DateTime Data_aluguel { get; set; }
        public DateTime Data_devolucao { get; set; }
        public float Valor { get; set; }
        public Colaborador NomeColaborador { get; set; }
        public int ColaboradorID { get; set; }

    }
}
