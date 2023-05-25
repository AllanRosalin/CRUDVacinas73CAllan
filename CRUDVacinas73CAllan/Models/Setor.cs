using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUDVacinas73CAllan.Models
{
    public class Setor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Nome { get; set; }

        public string ? Descricao { get; set; }
    }
}
