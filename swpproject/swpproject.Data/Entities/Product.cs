using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace swpproject.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }

        public List<ProductInCategory> ProductInCategories { get; set; } // List này dùng để đặt khóa ngoại với Category

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }

    }
}
