using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class ProvidersModel
    {
        [DisplayName("Provider ID")]
        public int IdProvider { get; set; }
        [DisplayName("Provider Name")]
        [Required(ErrorMessage = "Provider name is requerided")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provider name must be between 3 and 50 characters")]
        public string NameProvider { get; set; }
        [DisplayName("Observation")]
        [Required(ErrorMessage = "Observation is requerided")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Observation must be between 3 and 50 characters")]
        public String ObservationProvider { get; set; }

        internal void Add(ProvidersModel providersModel)
        {
            throw new NotImplementedException();
        }
    }
}
