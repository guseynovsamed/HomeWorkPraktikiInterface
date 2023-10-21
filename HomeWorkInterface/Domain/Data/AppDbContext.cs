using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AppDbContext
    {

        public Category[] Category()
        {
            return new Category[]
            {
                new Category{Id = 1, Name = "Phone"},
                new Category{Id = 2, Name = "Tv"},
                new Category{Id = 3, Name = "Console"},
                new Category{Id = 4, Name = "Notebook"},
                new Category{Id = 5, Name = "Toys"}

            };
        }


        public Product[] Products()
        {
            return new Product[]
            {
                new Product { Id = 1,  Name = "Iphone 12" , Price = 1500 , CreateDate = new(2018 , 01 ,27 ),  Category = Category().FirstOrDefault(n=>n.Id== 1)},
                new Product { Id = 2,  Name = "Samsung 7" , Price = 2500 , CreateDate = new(2020 , 03 ,11 ),  Category = Category().FirstOrDefault(n=>n.Id== 2)},
                new Product { Id = 3,  Name = "Sony PS5" , Price = 1100 , CreateDate = new(2021 , 09 ,01 ),  Category = Category().FirstOrDefault(n=>n.Id== 3)},
                new Product { Id = 4,  Name = "Macbook Pro" , Price = 3500 , CreateDate = new(2017 , 11 ,07 ),  Category = Category().FirstOrDefault(n=>n.Id== 4)}

            };
        }
    }
}
