using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Dominio
{
    public class Colaborador
    {
        [Key]  //metadados
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }
      
        public string Nome { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho de Função inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Funcão é obrigatório")]
        [Display(Name = "função")]
        public string Funcao { get; set; }

        public ICollection<Aluga> Alugueis { get; set; }


    }
}
