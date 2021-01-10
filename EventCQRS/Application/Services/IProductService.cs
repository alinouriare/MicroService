using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
  public  interface IProductService
    {
        Task<int> Add(AddProductViewModel product);

    }
}
