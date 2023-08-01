using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_Category_Git_Practice.Models.DbModel
{
    [Table("Products_Git")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public int product_price { get; set; }
        public int product_stock { get; set; }
        public List<Category> Categories { get; set; }
        public int? productcategoryid { get; set; }
    }
}
