namespace SegundoProjeto.Models
{
    abstract class Curso
    {
        public string Nome {  get; set; }
        public int CargaHoraria { get; set; }
        public HashSet<Disciplina> Disciplinas { get; } = new HashSet<Disciplina>();
        public HashSet<Professor> Professores { get; } = new HashSet<Professor>();

        public void RegistrarProfessor(Professor p)
        {
            this.Professores.Add(p);
            p.Cursos.Add(this);
        }

        public HashSet<Turma> Turmas { get; } = new HashSet<Turma>();

        public void RegistrarTurma(Turma t)
        {
            Turmas.Add(t);
            t.RegistrarCurso(this);
        }

        public HashSet<Aluno> Alunos { get; } = new HashSet<Aluno>();
        
        public void RegistrarAluno(Aluno a)
        {
            Alunos.Add(a);
            a.Cursos.Add(this);
        }
    }
}
