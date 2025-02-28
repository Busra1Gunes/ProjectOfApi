// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//ProductManager productManager = new(new EfProductDal());
//foreach (var product in productManager.GetProductDetails().Data)
//    Console.WriteLine(product.ProductId+"  "+ product.ProductName+"  "+product.CategoryName+"  "+product.UnitPrice );



//static void ProdutTest()
//{
//    Console.WriteLine("Hello, World!");
//    ProductManager productManager = new(new EfProductDal());
//    foreach (var item in productManager.GetAll().Data)
//    {
//        Console.WriteLine(item.ProductName);

//    }
//}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new(new EfCategoryDal());
//    string veri = categoryManager.GetById(1).Data.CategoryName;
//    Console.WriteLine(veri);
//}