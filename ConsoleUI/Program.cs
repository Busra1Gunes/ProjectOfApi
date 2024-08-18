// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;

Console.WriteLine("Hello, World!");
ProductManager productManager=new ProductManager(new InMemoryProductDal());
foreach (var item in productManager.GetAll())
{
	Console.WriteLine(item.ProductName);

}
