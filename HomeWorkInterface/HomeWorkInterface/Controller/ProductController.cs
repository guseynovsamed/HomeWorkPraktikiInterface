using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface.Controller
{
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetCountProduct()
        {
            Console.WriteLine(_productService.GetCount());
        }

        public void SearchByName()
        {
            Console.WriteLine("Add Product Search Text");
            string searchName = Console.ReadLine();

            foreach(var item in _productService.Search(searchName))
            {
                var result = $"{item.Name}-{item.Price}-{item.CreateDate.ToString("dd-MM-yyyy")}-{item.Category.Name}";
                Console.WriteLine(result);
            }


        }

        public void GetAll()
        {
            foreach(var item in _productService.GetAll())
            {
                var result = $"{item.Name}-{item.Price}-{item.CreateDate:dd-MM-yyyy}-{item.Category.Name}";
                Console.WriteLine(result);
            }
        }



        public void AveragePrice()
        {
            Console.WriteLine(_productService.GetAveragePrice());
        }

        public void DateSort()
        {
            foreach(var item in _productService.SortProduct())
            {
                var result = $"{item.Name}-{item.Price}-{item.CreateDate:dd-MM-yyyy}";
                Console.WriteLine(result);
            }
        }


        public void CategorySort()
        {
            Console.WriteLine("Add Product Search Text");
            string catogoryText = Console.ReadLine();

            foreach(var item in _productService.SortCategory(catogoryText))
            {
                
                Console.WriteLine(item.Name+" "+item.Price+" "+item.Category.Name);
            }
        }


        public void GetAllProduct()
        {
            Console.WriteLine("Please Add Category Id");
            int id =Convert.ToInt32( Console.ReadLine());

            foreach(var item in _productService.GetProduct(id))
            {
                var result = $"{item.Name}-{item.Price}-{item.CreateDate:dd-MM-yyyy}-{item.Category.Name}";
                Console.WriteLine(result);
            }

        }
    }
}
