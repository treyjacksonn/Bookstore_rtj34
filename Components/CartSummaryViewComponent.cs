using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore_rtj34.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_rtj34.Components
{
        public class CartSummaryViewComponent : ViewComponent
        {
            private Basket cart;
            public CartSummaryViewComponent(Basket cartService)
            {
                cart = cartService;
            }
            public IViewComponentResult Invoke()
            {
                return View(cart);
            }
        }
}
