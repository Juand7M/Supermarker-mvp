using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Categories Id")]
        public int Id { get; set; }
        [DisplayName("Categories Name")]
        [Required(ErrorMessage ="Categories name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Categories name must be between 3 and 50 characters" )]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = " Categories descripcion is required")]
        [StringLength(200, MinimumLength =3, ErrorMessage ="Categories description must be between 3 and 200 characters")]
        public string Description { get; set; }
    }
}
