using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_StructVariable
{
    class StructVariable
    {
        static void Main()
        {
            Product product;

            product.Id = 1;
            product.Title = "good book";
            product.Price = 10_000M;

            string msg = $"번호 : {product.Id}\n상품명 : {product.Title}\n가격 : {product.Price}";
            Console.WriteLine(msg);
        }
    }
    struct Product
    {
        public int Id;
        public string Title;
        public decimal Price;
    }
}
