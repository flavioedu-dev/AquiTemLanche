using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquiTemLanche.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo do nome é de 100 caracteres.")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe a descrição da categoria.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo da descrição é de 200 caracteres.")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        public List<Snack> Snacks { get; set; }
    }
}
