using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;

namespace app02.Classes
{
   public class Celula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CelulaId { get; set; }
        public string Name { get; set; }
        public DayOfWeek Dia { get; set; }
        public string Horario { get; set; }
        public int? EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco CelulaEndereco { get; set; }


        [NotMapped]
        public string MsgErro { get; set; }
    }
}
