using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiviansPieShop.Models;

namespace LiviansPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
