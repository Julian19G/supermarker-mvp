using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Category ID")]
        public int IdCategoria { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is requerided")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 50 characters")]
        public string NameCategoria { get; set;}
        [DisplayName("Observation")]
        [Required(ErrorMessage = "Observation is requerided")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Observation name must be between 3 and 50 characters")]
        public String ObservationCategoria { get; set; }
     }
}
