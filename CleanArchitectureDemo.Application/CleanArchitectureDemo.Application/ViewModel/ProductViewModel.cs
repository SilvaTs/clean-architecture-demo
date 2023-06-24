using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.ViewModel
{
    public class ProductViewModel
    {
        public ProductViewModel(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}
}
