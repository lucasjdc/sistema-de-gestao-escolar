namespace SegundoProjeto.Models
{
    internal class Disciplina
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public override bool Equals(Object obj)
        {
            if (obj in Disciplina)
            {
                Disciplina d = obj as Disciplina;
                return this.Nome.Equals(d.Nome);

            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
        }
    }
}
