using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class TravelDetail
    {
        public TravelDetail()
        {
            AccomodationDetails = new HashSet<AccomodationDetail>();
        }

        public int TravelId { get; set; }
        public int GuestId { get; set; }
        public DateTime TravelStartDate { get; set; }
        public TimeSpan TravelStartTime { get; set; }
        public DateTime TravelEndDate { get; set; }
        public TimeSpan TravelEndTime { get; set; }
        public string SourceLocation { get; set; } = null!;
        public string DestinationLocation { get; set; } = null!;
        public int? ConveyanceId { get; set; }

        public virtual ConveyanceDetail? Conveyance { get; set; }
        public virtual GuestDetail Guest { get; set; } = null!;
        public virtual ICollection<AccomodationDetail> AccomodationDetails { get; set; }
    }
}
