using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
{

}

namespace Supermarket_mvp1.Models
{
    internal class ProductModel
    {
        [DisplayName ("Product Id")]
        public int Product_Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage ="Product name is requered")]
        [StringLength (50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 a 50 characters")]
        public string Product_Name { get; set; }

        [DisplayName("Product Precie")]
        [Required(ErrorMessage = "Product precie is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Select Valor of product")]
        public string Product_Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product stock is required")]
        [StringLength(200, MinimumLength = 3,ErrorMessage = "no have stock")]
        public string Product_Stock { get; set; }
    }
}
