using Domain.Data;
using Domain.Models;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _appDbContext;

        public ProductService()
        {
            _appDbContext = new AppDbContext();
        }

        public Product[] GetAll()
        {
            return _appDbContext.Products();
        }

        public double GetAveragePrice()
        {
            return _appDbContext.Products().Sum(n => n.Price) / _appDbContext.Products().Length;
        }

        public int GetCount()
        {
            return _appDbContext.Products().Count();
        }

        public Product[] GetProduct(int id)
        {
            return _appDbContext.Products().Where(n=>n.Category.Id == id).ToArray();
        }

        public Product[] Search(string searchName)
        {
            return _appDbContext.Products().Where(n=>n.Name.ToLower().Trim().Contains(searchName.ToLower().Trim())).ToArray();
        }

        public Product[] SortCategory(string categoryText)
        {
            return _appDbContext.Products().Where(n=>n.Category.Name.ToLower().Trim().Contains(categoryText.ToLower().Trim())).ToArray();
        }

        public Product[] SortProduct()
        {
            return _appDbContext.Products().OrderByDescending(n => n.CreateDate).ToArray();
        }


    }
}
