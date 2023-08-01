using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_Category_Git_Practice.Models.DbModel
{
    [Table("Categories_Git")]
    public class Category
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string category_description { get; set; }
    }
}
