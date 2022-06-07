namespace DESAFIO_Aula_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcao;

            Console.Write("(1) Ver alunos\n" +
                "(2) Funcionários\n" +
                "Opçao: ");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    TesteAlunoTurma testeAlunoTurma = new TesteAlunoTurma();
                    testeAlunoTurma.Testar();
                    break;
                case 2:
                    TesteMetodosFuncionario testeFuncionario = new TesteMetodosFuncionario();
                    testeFuncionario.Testar();
                    break;
            }
        }
    }
}