using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models
{
    public interface ICheckoutRepository
    {
        IQueryable<Checkout> Checkout{ get;}

        void SaveCheckout(Checkout check);
    }
}
