using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Models
{
    public class UnidadesCurriculares
    {
        public UnidadesCurriculares() { 
        ListaProfessores=new HashSet<Professores>();
            ListaInscricos=new HashSet<Inscricoes>();
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public int AnoCurricular { get; set; }

        public int Semestre { get; set; }


        /***************************************
         * Vamos criar as Relações (Fks) com outras tabelas
         */

        //relacionamento dos tipo N-1
        /*[ForeignKey("Curso")]---Forma errada uma string pode causar problemas*/
        [ForeignKey(nameof(Curso))]//forma correta que nao causa problemas--Anotação que liga FK a curso
        public int CursoFk { get; set; } //Será FK para a tabela
        public Cursos Curso { get; set; } //em rigor esta instrução 

        //relacionamento dos tipo N-M para os professores
        public ICollection<Professores> ListaProfessores { get; set;}
        public ICollection<Inscricoes> ListaInscricos { get; set;}

    }
}
