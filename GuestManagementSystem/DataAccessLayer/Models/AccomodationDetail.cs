using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class AccomodationDetail
    {
        public int AccomodationId { get; set; }
        public string AccomodationType { get; set; } = null!;
        public int NumberOfRooms { get; set; }
        public int NumberOfBeds { get; set; }
        public string TypeOfRoom { get; set; } = null!;
        public string TypeOfBed { get; set; } = null!;
        public string? TypeOfLocation { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Town { get; set; } = null!;
        public string District { get; set; } = null!;
        public string State { get; set; } = null!;
        public decimal Pin { get; set; }
        public string? UspOfTheLocation { get; set; }
        public bool? AvailabilityToExtend { get; set; }
        public int? NumberOfDaysToExtend { get; set; }
        public int? TravelId { get; set; }

        public virtual TravelDetail? Travel { get; set; }
    }
}
