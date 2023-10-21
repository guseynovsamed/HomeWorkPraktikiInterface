using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface.Controller
{
    public class CategoryController
    {
        private ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }



        public void GetAll()
        {
            foreach(var item in _categoryService.GetCategories())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
