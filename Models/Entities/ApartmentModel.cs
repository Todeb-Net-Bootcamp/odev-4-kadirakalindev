using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    class ApartmentModel
    {
        [Key]
        public string ID { get; set; }
        public string Block { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
        public string No { get; set; }
        public string Owner { get; set; }
    }
}
