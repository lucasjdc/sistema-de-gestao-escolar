using SegundoProjeto.Enums;

namespace SegundoProjeto.Models
{
    class Turma
    {
        private Curso _curso;

        public string CodigoTurma { get; set; }
        public PeriodoCursoEnum PeriodoCurso { get; set; }
        public TurnoTurmaEnum TurnoTurma { get; set;}
        public Curso Curso { get {  return _curso; } }
        public void RegistrarCurso(Curso curso)
        { 
            this._curso = curso;
        }
        public override bool Equals(object obj)
        {
            if (obj is Turma)
            {
                Turma t = obj as Turma;
                return this.CodigoTurma.Equals(t.CodigoTurma);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + this.CodigoTurma == null ? 0 : this.CodigoTurma.GetHashCode());
        }
    }
}
