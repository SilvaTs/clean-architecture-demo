using CleanArchitectureDemo.Application.InputModel;
using CleanArchitectureDemo.Application.ViewModel;
using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productInputModel)
        {
            var product = new Product();

            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);

            return new ProductViewModel(product.Title, product.Price);
        }
    }
}
}
