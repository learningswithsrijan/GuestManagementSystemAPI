using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class PaymentDetail
    {
        public int PaymentDetailId { get; set; }
        public int? GuestId { get; set; }
        public string? ModeOfPayment { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? DateAndTime { get; set; }

        public virtual GuestDetail? Guest { get; set; }
    }
}
