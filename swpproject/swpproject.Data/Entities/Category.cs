using swpproject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace swpproject.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }

        public List<ProductInCategory> ProductInCategories { get; set; } // Liên kết khóa ngoại với Products

        public List<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
