using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int CheckoutID { get; set; }

        [BindNever]
        public ICollection<CartLineItem>Lines { get; set; }

        [Required(ErrorMessage ="Please enter name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter addreess:")]
        public string AddresLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Zip:")]
        public string Zip { get; set; }


        [Required(ErrorMessage = "Please enter country:")]
        public string Country { get; set; }
       
       
    }
}
