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
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _appDbContext;
        public CategoryService()
        {
            _appDbContext = new AppDbContext();
        }
        public Category[] GetCategories()
        {
            return _appDbContext.Category();
        }
    }
}
