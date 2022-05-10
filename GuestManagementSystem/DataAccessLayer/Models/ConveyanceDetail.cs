using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class ConveyanceDetail
    {
        public ConveyanceDetail()
        {
            TravelDetails = new HashSet<TravelDetail>();
        }

        public int ConveyanceId { get; set; }
        public string MediumOfConveyance { get; set; } = null!;
        public string NameOfConveyance { get; set; } = null!;
        public string UniqueIdentification { get; set; } = null!;
        public string SourceLocation { get; set; } = null!;
        public string DestinationLocation { get; set; } = null!;

        public virtual ICollection<TravelDetail> TravelDetails { get; set; }
    }
}
