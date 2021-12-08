namespace FolhaDePagamento.Models
{
    public class Funcionario
    {

        public String Nome { get; set;}
        public String Rg { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        public double Vr { get; set; }

        public double SalarioFamilia { get; set; }

        public double DescontoInss { get; set; }

        public double DescontoIrrf { get; set; }

    }
}
