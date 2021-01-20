using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //Ürün adı
        public int Id { get; set; }
        //
        public string ProductName { get; set; }
        //Birim fiyatı
        public double UnitPrice { get; set; }
        //Kategori adı
        public int CategoryId { get; set; }
        //StokAdedi
        public int UnitsInStock { get; set; }


    }
}
