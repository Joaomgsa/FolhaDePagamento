using Microsoft.AspNetCore.Mvc;
using FolhaDePagamento.Models;

namespace FolhaDePagamento.Controllers
{
    public class FuncionarioController : Controller
    {
        [Route("Funcionario/InserirPagamento")]
        public IActionResult InserirPagamento()
        {
            return View();
        }
        
        [HttpPost]
        [Route("Funcionario/FolhaPagamento")]
        public IActionResult FolhaPagamento(Funcionario funcionario)
        {
            funcionario.DescontoInss = funcionario.Salario * 0.11;
            funcionario.DescontoIrrf = funcionario.Salario * 0.07;


            funcionario.Salario -= funcionario.DescontoInss;
            
            funcionario.Salario -= funcionario.DescontoIrrf;
            
            funcionario.Salario += funcionario.SalarioFamilia;
            
            funcionario.Salario += funcionario.Vr;

            return View(funcionario);
        }
    }
}
