using CleanArchitectureDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
    }
}
