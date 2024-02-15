using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquiTemLanche.Models
{
    [Table("ShoppingCartItems")]
    public class PurchaseCartItems
    {
        public int PurchaseCartItemsId { get; set; }

        public Snack Snack { get; set; }

        [StringLength(200)]
        public string PurchaseCartId { get; set; }

        public int Amount { get; set; }
    }
}
