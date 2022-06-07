namespace DESAFIO_Aula_03
{
    internal class TesteAlunoTurma
    {
        public void Testar()
        {
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Ana de Paula";
            aluno1.dataNascimento = "27/10/1992";
            aluno1.rg = 23559966;

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Ana Carolina";
            aluno2.dataNascimento = "25/10/1991";
            aluno2.rg = 22558899;

            aluno1.turma = new Turma();
            aluno1.turma.periodo = "Matutino";
            aluno1.turma.serie = 8;
            aluno1.turma.sigla = "M8P";
            aluno1.turma.tipoEnsino = "Presencial";

            aluno2.turma = new Turma();
            aluno2.turma.periodo = "Vespertino";
            aluno2.turma.serie = 9;
            aluno2.turma.sigla = "V9H";
            aluno2.turma.tipoEnsino = "Híbrido";

            Console.WriteLine("Dados do aluno");
            aluno1.Imprimir();
            aluno1.turma.Imprimir();
            Console.WriteLine("-------------------");
            Console.WriteLine("Dados do aluno");
            aluno2.Imprimir();
            aluno2.turma.Imprimir();
        }
    }
}
