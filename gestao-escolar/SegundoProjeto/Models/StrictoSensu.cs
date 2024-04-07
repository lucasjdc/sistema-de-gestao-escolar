namespace SegundoProjeto.Models
{
    internal class StrictoSensu : PosGraduacao
    {
        public IList<string> LinhaDePesquisa { get; } = new List<string>();
    }
}
