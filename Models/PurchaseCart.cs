using AquiTemLanche.Context;
using Microsoft.EntityFrameworkCore;

namespace AquiTemLanche.Models
{
    public class PurchaseCart
    {
        private readonly AppDbContext _context;
        public PurchaseCart(AppDbContext context)
        {
            _context = context;
        }

        public string PurchaseCartId {  get; set; }
        public List<PurchaseCartItems> PurchaseCartItems { get; set; }

        public PurchaseCart GetCart(IServiceProvider services)
        {
            // Define uma sessão
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            // Obtém um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            // Obtém ou gera o Id do carrinho
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            return new PurchaseCart(context)
            {
                PurchaseCartId = cartId
            };
        }

        public void AddItemToCart(Snack snack)
        {
            var purchaseCartItem = _context.PurchaseCartItems.SingleOrDefault(s => s.Snack.SnackId == snack.SnackId && s.PurchaseCartId == PurchaseCartId);

            if (purchaseCartItem == null)
            {
                var newPurchaseCartItem = new PurchaseCartItems
                {
                    PurchaseCartId = this.PurchaseCartId,
                    Snack = snack,
                    Amount = 1
                };

                _context.PurchaseCartItems.Add(newPurchaseCartItem);
            }
            else
                purchaseCartItem.Amount++;

            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Snack snack)
        {
            var purchaseItemCart = _context.PurchaseCartItems.SingleOrDefault(s => s.Snack.SnackId == snack.SnackId && s.PurchaseCartId == PurchaseCartId);

            if(purchaseItemCart != null)
            {
                if(purchaseItemCart.Amount > 1)
                {
                    purchaseItemCart.Amount--;
                }
                else
                    _context.PurchaseCartItems.Remove(purchaseItemCart);

                _context.SaveChanges();
            }
        }

        public List<PurchaseCartItems> GetListPurchaseCartItems()
        {
            return PurchaseCartItems ?? (PurchaseCartItems = _context.PurchaseCartItems.Where(c => c.PurchaseCartId == PurchaseCartId).Include(s => s.Snack).ToList());
        }

        public void ClearCart()
        {
            var itemsFromCart = _context.PurchaseCartItems.Where(c => c.PurchaseCartId == PurchaseCartId);

            _context.PurchaseCartItems.RemoveRange(itemsFromCart);

            _context.SaveChanges();
        }

        public decimal GetTotalCartValue()
        {
            decimal totalCartValue = _context.PurchaseCartItems
                .Where(c => c.PurchaseCartId == PurchaseCartId)
                .Select(s => s.Snack.Price * s.Amount)
                .Sum();

            return totalCartValue;
        }
    }
}
