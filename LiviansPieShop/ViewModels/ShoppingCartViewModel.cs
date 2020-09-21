using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiviansPieShop.Models;

namespace LiviansPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
