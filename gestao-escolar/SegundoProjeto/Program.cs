using SegundoProjeto.Models;

class Program
{
    static void Main()
    {
        var graduacao = new Graduacao() { Nome = "Curso de Graduação" };
        var latoSensu = new LatoSensu() { Nome = "Curso de Lato Sensu" };
        var strictoSenso = new StrictoSensu() { Nome = "Curso de Stricto Sensu" };

        var repositorioCursos = new RepositorioCurso();
        repositorioCursos.Gravar(graduacao);
        repositorioCursos.Gravar(latoSensu);
        repositorioCursos.Gravar(strictoSenso);

        Console.WriteLine();
        Console.WriteLine("Cursos gravados");

        foreach (var curso in repositorioCursos.ObterTodos())
        {
            Console.WriteLine($"==> {curso.Nome} ({curso.GetType()})");
        }
        Console.WriteLine("Pression qualquer tecla para continuar");
        Console.ReadKey();

    }
}
