﻿using System.ComponentModel.DataAnnotations;

namespace Aulas.Models {

   /// <summary>
   /// Classe para descrever os Cursos existentes na Escola
   /// </summary>
   public class Cursos {


      public Cursos() {
         ListaUCs = new HashSet<UnidadesCurriculares>();
         ListaAlunos = new HashSet<Alunos>();
      }

      /// <summary>
      /// Chave Primária (PK)
      /// </summary>
      [Key] 
      public int Id { get; set; }

      /// <summary>
      /// Nome do Curso
      /// </summary>
      [StringLength(100)]
      public string Nome { get; set; }

      /// <summary>
      /// Nome do ficheiro que contém o logótipo do Curso
      /// </summary>
      [Display(Name ="Logótipo")] // altera o nome do atributo no ecrã
      [StringLength(50)] // define o tamanho máximo como 50 caracteres
      public string? Logotipo { get; set; } // o ? torna o preenchimento facultativo

      /* ************************************************
       * Vamos criar as Relações (FKs) com outras tabelas
       * *********************************************** */

      // relacionamento com as Unidades Curriculares
      /// <summary>
      /// Lista das Unidades Curriculares associadas ao Curso
      /// </summary>
      public ICollection<UnidadesCurriculares> ListaUCs { get; set; }
      
      // relacionamento com os Alunos
      /// <summary>
      /// Lista dos alunos inscritos no Curso
      /// </summary>
      public ICollection<Alunos> ListaAlunos { get; set; }

   }
}
