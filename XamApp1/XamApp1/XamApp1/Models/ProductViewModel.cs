using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamApp1.Models
{
    public class ProductViewModel
    {
        public IList<Product> Products { get; set; }
        public int ProductCount {
            get
            {
                int count = 0;
                if (this.Products != null)
                {
                    count = this.Products.Count;
                }
                return count;
            }
        }
    }
}
