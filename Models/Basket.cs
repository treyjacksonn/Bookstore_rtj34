using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models
{
    public class Basket
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        //Function to add item, uses BookId to know what book the user selected
        public virtual void AddItem(Book book, int qty)
        {
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                //adds the info needed to display the basekt/cart
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty

                });            
            }
            else
            {
                //adding additional copy of the same book
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
        }
        //used to calculate the total of the basekt/cart
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;

        }
    }

    //Defines variables to hold the info for the cart
    public class CartLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
