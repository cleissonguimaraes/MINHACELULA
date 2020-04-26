using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app02.Classes
{
    public class Pessoa
    {
        /*
        public string Nome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string funcao { get; set; }*/

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PessoaId { get; set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string Funcao { get; set; }

        [ForeignKey("Endereco")]
        public int? EnderecoId { get; set; }
        [ForeignKey("Celula")]
        public int CelulaId { get; set; }


        public virtual Endereco Endereco { get; set; }


        public virtual Celula Celula { get; set; }

        [NotMapped]
        public string MsgErro { get; set; }

    }

}
