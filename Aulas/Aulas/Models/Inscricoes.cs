using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Models {
   public class Inscricoes {

        public DateTime DataInscricao { get; set; }

        public Inscricoes() { 
        }
        [ForeignKey(nameof(UC))]
        public int UCFK { get; set; }
        public UnidadesCurriculares UC { get; set; }

        [ForeignKey(nameof(Inscricoes))]
        public int InscriçõesFK { get; set; }
        public Inscricoes ListaInscrições { get; set; }
    }
}
