using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app02.Classes
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }

        [NotMapped]
        public string MsgErro { get; set; }
    }
}
