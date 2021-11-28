using Aluguel.Models;
using Aluguel.Models.Consulta;
using Aluguel.Models.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Controllers
{
    public class AlugueisController : Controller
    {
        private readonly Contexto  contexto;

        public AlugueisController(Contexto context)
        {
            contexto = context;
            
        }

        public IActionResult ListarItensAluga()
        {

            IEnumerable<Itens> lstItens = from item in contexto.Alugueis
                                          

                                           .OrderBy(id => id.ID)
                                           .ThenBy(nome => nome.NomeCliente)
                                           .ThenBy(Data => Data.Data_aluguel)


                                          .ToList()
                                         

                                          select new Itens
                                          {
                                              ID = item.ID,
                                              NomeCliente = item.NomeCliente,
                                              Data_aluguel = item.Data_aluguel,
                                              Endereco = item.Endereco,
                                              Bairro = item.Bairro,
                                              Tamanho = item.Tamanho,
                                              Codigo = item.Codigo,
                                              Observacao = item.Observacao,
                                              NomeColaborador = item.NomeColaborador,
                                              Data_devolucao = item.Data_devolucao,
                                              Valor = item.Valor,
                                          };                                         
                                          
                                  return View(lstItens); 


        }


    }
}
