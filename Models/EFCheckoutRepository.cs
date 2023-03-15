using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models
{
    public class EFCheckoutRepository : ICheckoutRepository
    {
        private BookstoreContext context;

        public EFCheckoutRepository(BookstoreContext temp)
        {
            context = temp;

        }
        public IQueryable<Checkout> Checkout => context.Checkout.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SaveCheckout(Checkout check)
        {
            context.AttachRange(check.Lines.Select(x => x.Book));

            if (check.CheckoutID == 0)
            {
                context.Checkout.Add(check);
            }

            context.SaveChanges();
        }
    }
}
