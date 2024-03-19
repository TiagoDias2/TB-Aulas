namespace Aulas.Models
{
    public class Cursos
    {

        public Cursos()
        {
            ListaUCs = new HashSet<UnidadesCurriculares>();
            ListaAlunos = new HashSet<Alunos>();
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Logotipo { get; set; }

        //Relacionamento do tipo 1-N com as unidades curriculares
        public ICollection<UnidadesCurriculares> ListaUCs { get; set; }

        //Relacionamento do tipo 1-N com os alunos
        public ICollection<Alunos> ListaAlunos { get; set; }
    }
}
