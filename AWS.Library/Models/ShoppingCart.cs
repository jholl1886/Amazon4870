using AWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS.library.Models
{
    internal class ShoppingCart
    {
        int Id {  get; set; } //add to

        public List<Items>? Contents { get; set; }
    }
}
