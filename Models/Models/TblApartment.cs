using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Models
{
    public partial class TblApartment
    {
        public int ApartmentId { get; set; }
        public string ApartmentBlock { get; set; }
        public string ApartmentStatus { get; set; }
        public string ApartmentType { get; set; }
        public string ApartmentFloor { get; set; }
        public string ApartmentNo { get; set; }
        public string ApartmentOwner { get; set; }
    }
}
