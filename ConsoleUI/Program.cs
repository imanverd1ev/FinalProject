using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ProductTest();
			CategoryManager categoryManager = new CategoryManager(new EfCategorydDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryId);
            }
        }

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetAllByUnitPrice(20, 399))
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}