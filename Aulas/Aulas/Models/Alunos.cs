using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Models {
   public class Alunos {

        public Alunos() { 
        ListaInscrições=new HashSet<Inscricoes>();
        }
      public int NumAluno { get; set; }

      public decimal Propinas { get; set; }

      public DateTime DataMatricula { get; set; }

        /***************************************
         * Vamos criar as Relações (Fks) com outras tabelas
         */

        //relacionamento dos tipo N-1
       
        [ForeignKey(nameof(Curso))]//forma correta que nao causa problemas--Anotação que liga FK a curso
        public int CursoFk { get; set; } //Será FK para a tabela
        public Cursos Curso { get; set; } //em rigor esta instrução 
        public ICollection<Inscricoes> ListaInscrições { get; set; }
    }
}
