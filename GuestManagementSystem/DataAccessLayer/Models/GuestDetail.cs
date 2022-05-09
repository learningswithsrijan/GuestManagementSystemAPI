using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class GuestDetail
    {
        public GuestDetail()
        {
            FoodDetails = new HashSet<FoodDetail>();
            PaymentDetails = new HashSet<PaymentDetail>();
            TravelDetails = new HashSet<TravelDetail>();
        }

        public int GuestId { get; set; }
        public bool? TravelingInGroup { get; set; }
        public int? GroupId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Town { get; set; } = null!;
        public string District { get; set; } = null!;
        public string State { get; set; } = null!;
        public decimal Pin { get; set; }
        public string EmailIdprimary { get; set; } = null!;
        public string? EmailIdsecondary { get; set; }
        public decimal MobileNumberPrimary { get; set; }
        public decimal? MobileNumberSecondary { get; set; }

        public virtual ICollection<FoodDetail> FoodDetails { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
        public virtual ICollection<TravelDetail> TravelDetails { get; set; }
    }
}
