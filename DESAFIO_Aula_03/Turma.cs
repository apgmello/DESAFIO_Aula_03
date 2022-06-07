namespace DESAFIO_Aula_03
{
    internal class Turma
    {
        public string? periodo;
        public int serie;
        public string? sigla;
        public string? tipoEnsino;

        public void Imprimir()
        {
            Console.WriteLine($"Periodo: {periodo}");
            Console.WriteLine($"Série: {serie}");
            Console.WriteLine($"Sigla: {sigla}");
            Console.WriteLine($"Tipo de ensino: {tipoEnsino}");
        }
    }
}
