namespace DESAFIO_Aula_03
{
    internal class Funcionario
    {
        public string? nome;
        public double salario;

        public void AumentarSalario(double valor)
        {
            salario += valor;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário atual: {salario}");
        }
    }
}
