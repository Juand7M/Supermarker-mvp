using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_mvp.Models
{
    internal class ProductsModel
    {
        [DisplayName("Products Id")]
        public int Id { get; set; }
        [DisplayName("Products Name")]
        [Required(ErrorMessage = "Products name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Products name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Products Price")]
        [Required(ErrorMessage = "Products Prince is required")]
        public string Price { get; set; }
        [DisplayName("Products Stock")]
        [Required(ErrorMessage = "Products Stock is required")]
        public string Stock { get; set; }
        [DisplayName("Products Categories_Id")]
        [Required(ErrorMessage = "Products Categories_Id is required")]
        public string Categories_Id { get; set; }
    }
}
