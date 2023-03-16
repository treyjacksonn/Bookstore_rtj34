using Bookstore_rtj34.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Components
{
    public class SummaryViewComponent: ViewComponent
    {

        private Basket basket { get; set; }

        public SummaryViewComponent(Basket b)
        {
            basket = b;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }

    }
}
