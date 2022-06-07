namespace DESAFIO_Aula_03
{
    internal class TesteMetodosFuncionario
    {
        public void Testar()
        {
            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Carolina Mello";
            funcionario1.salario = 4000;

            Console.WriteLine("Dados do funcionário");
            funcionario1.Imprimir();

            double aumentoSalario;
            Console.Write("Valor do aumento: ");
            double.TryParse(Console.ReadLine(), out aumentoSalario);
            funcionario1.AumentarSalario(aumentoSalario);

            Console.WriteLine("-------------------");
            funcionario1.Imprimir();
        }
    }
}
