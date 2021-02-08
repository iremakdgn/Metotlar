using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoriId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoriId=5, UnitsInStock=5, 
                ProductName="Kalem", UnitPrice=35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int, double,float .. sayısal tipler değer tipleri
            //dizi,class,abstract class,interface.. referans tiptir

        }
    }
}
