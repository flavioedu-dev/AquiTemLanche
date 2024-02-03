using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquiTemLanche.Models
{
    [Table("Snacks")]
    public class Snack
    {
        [Key]
        public int SnackId { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche.")]
        [DisplayName("Nome do lanche")]
        [StringLength(100, ErrorMessage = "O tamanho máximo do {0} é de 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe a descrição rápida do lanche.")]
        [DisplayName("Descrição rápida")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O tamanho mínimo da {0} é de {1} e o máximo {2} caracteres.")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada do lanche.")]
        [DisplayName("Descrição detalhada")]
        [StringLength(300, MinimumLength = 50, ErrorMessage = "O tamanho mínimo da {0} é de {1} e o máximo {2} caracteres.")]
        public string DetailedDescription { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche.")]
        [DisplayName("Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço dos lanches pode variar entre {1} e {2}.")]
        public decimal Price { get; set; }

        [DisplayName("Endereço da imagem normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}.")]
        public string ImageUrl { get; set; }

        [DisplayName("Endereço da imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}.")]
        public string ImageThumbnailUrl { get; set; }

        [DisplayName("Favorito?")]
        public bool IsFavoriteSnack { get; set; }

        [DisplayName("Em estoque")]
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
