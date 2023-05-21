using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();

            List<Products> urunler = db.Products.ToList();

            foreach (Products item in urunler)
            {
                Console.WriteLine(item.ProductName + " - " + item.Categories.CategoryName+ item.Categories.Description);
            }

        }
    }
}
