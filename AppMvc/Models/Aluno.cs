using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppMvc.Models
{
    public class Aluno
    {
        [Key]
        public int Id{ get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage ="O Campo {0} é requerido")]
        public string Nome { get; set; }

   
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O Campo {0} é requerido")]
        [EmailAddress(ErrorMessage ="E-mail Formato invállido")]

        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo {0} é requerido")]

        public string CPF { get; set; }

        public int DataMatricula { get; set; }

    //    public bool Ativo { get; set; }
     //   [Required(ErrorMessage = "O Campo {0} é requerido")]
      //  public string Senha { get; set; }

      //  [Compare(otherProperty:"Senha",ErrorMessage="As senhas informadas não conferem")]
      //  [Required(ErrorMessage = "O Campo {0} é requerido")]
     //   public string ConfirmacaoSenha { get; set; }

    }
}