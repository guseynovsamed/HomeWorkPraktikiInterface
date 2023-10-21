using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IProductService
    {
        int GetCount();
        Product[] Search(string searchName);
        Product[] GetAll();
        double GetAveragePrice();
        Product[] SortProduct();
        Product[] SortCategory(string categoryText);
        Product[] GetProduct(int id);
    }
}
