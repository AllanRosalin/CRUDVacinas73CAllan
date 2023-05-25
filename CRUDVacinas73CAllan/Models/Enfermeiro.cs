using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUDVacinas73CAllan.Models
{
    public class Enfermeiro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Rg { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Cpf { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Endereco { get; set; }

        public int Coren { get; set; }

        [Display(Name = "Data de Admissão")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Dataadmissao { get; set; }
    }
}
