using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUDVacinas73CAllan.Models
{
    public class Vacina
    {
            public int Id { get; set; }

            [Required(ErrorMessage = "Campo obrigatório")]
            public int lote { get; set; }

            [Required(ErrorMessage = "Campo obrigatório")]
            public int Quantidade { get; set; }

            [Display(Name = "Data de Fabricação")]
            [Required(ErrorMessage = "Campo obrigatório")]
            public DateTime Datafabricacao { get; set; }

            [Display(Name = "Data de Vencimento")]
            [Required(ErrorMessage = "Campo obrigatório")]
            public DateTime Datavencimento { get; set; }
    }
}
