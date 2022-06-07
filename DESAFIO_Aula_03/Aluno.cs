namespace DESAFIO_Aula_03
{
    internal class Aluno
    {
        public string? nome;
        public int rg;
        public string? dataNascimento;
        public Turma turma;

        public void Imprimir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"RG: {rg}");
            Console.WriteLine($"Nome: {dataNascimento}");
        }
    }
}
