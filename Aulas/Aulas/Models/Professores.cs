namespace Aulas.Models {
   public class Professores {
        public Professores() { 
        ListaProfessores=new HashSet<Professores>();
        }
        //relacionamento dos tipo M-N para as unidades curriculares
        public ICollection<Professores> ListaProfessores { get; set; }
   }
}
