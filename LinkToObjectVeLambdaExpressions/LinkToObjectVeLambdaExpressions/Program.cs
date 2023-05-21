using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkToObjectVeLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();
            arabalar.Add(new Araba() { ID = 1, Marka = "Audi", Model = "A3", Fiyat = 500000 });
            arabalar.Add(new Araba() { ID = 2, Marka = "Ford", Model = "Focus", Fiyat = 600000 });
            arabalar.Add(new Araba() { ID = 3, Marka = "Ford", Model = "Escort", Fiyat = 700000 });
            arabalar.Add(new Araba() { ID = 4, Marka = "Ford", Model = "Fusion", Fiyat = 800000 });
            arabalar.Add(new Araba() { ID = 5, Marka = "Audi", Model = "A6", Fiyat = 900000 });
            arabalar.Add(new Araba() { ID = 6, Marka = "Audi", Model = "A1", Fiyat = 1000000 });
            arabalar.Add(new Araba() { ID = 7, Marka = "Fiat", Model = "Doblo", Fiyat = 1100000 });
            arabalar.Add(new Araba() { ID = 8, Marka = "Fiat", Model = "Egea", Fiyat = 500000 });
            arabalar.Add(new Araba() { ID = 9, Marka = "Huyundai", Model = "i20", Fiyat = 400000 });
            arabalar.Add(new Araba() { ID = 10, Marka = "Huyundai", Model = "i30", Fiyat = 300000 });

            //Linq To Object
            //SQL üzerinde TSQL sorgu yaklaşımının c# içerisinde kullanılmasına olanak sağlayan yapıya Linq to Object denir
            #region WHERE
            //var filtreli = from x in arabalar
            //               where x.Fiyat > 500000
            //               select x;

            ////Lambda Expressions
            ////Koşul alabilen metotlar aracılıyla Linq kullanımına olanak tanır
            ////=> Lambda ifadesi

            //var filtreli2 = arabalar.Where(x => x.Fiyat < 500000);


            //foreach (var item in filtreli2)
            //{
            //    Console.WriteLine(item.ID + " " + item.Marka + " " + item.Model + " " + item.Fiyat);
            //}
            #endregion

            #region MAX
            //double enpahalli = arabalar.Max(x => x.Fiyat);
            //Console.WriteLine(enpahalli);
            #endregion

            #region Soru

            double enpahalli = arabalar.Max(x => x.Fiyat);

            List<Araba> filtreliler = arabalar.Where(x => x.Fiyat > 500000).ToList();

            filtreliler.ForEach(x => Console.WriteLine(x.ID + " " + x.Marka));


            #endregion

        }
    }
    class Araba
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
    }
}
