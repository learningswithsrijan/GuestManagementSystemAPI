using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class FoodDetail
    {
        public int FoodDetailsId { get; set; }
        public int? GuestId { get; set; }
        public int? FoodMenuId { get; set; }
        public TimeSpan ServingTime { get; set; }
        public string? ServingCategory { get; set; }

        public virtual FoodMenu? FoodMenu { get; set; }
        public virtual GuestDetail? Guest { get; set; }
    }
}
