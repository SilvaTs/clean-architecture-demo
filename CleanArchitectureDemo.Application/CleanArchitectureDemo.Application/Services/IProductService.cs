using CleanArchitectureDemo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Services
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
    }
}
