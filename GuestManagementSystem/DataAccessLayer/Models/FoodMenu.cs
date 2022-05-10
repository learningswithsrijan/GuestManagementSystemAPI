using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class FoodMenu
    {
        public FoodMenu()
        {
            FoodDetails = new HashSet<FoodDetail>();
            InverseItemCuisine = new HashSet<FoodMenu>();
        }

        public int MenuId { get; set; }
        public bool? IsCuisine { get; set; }
        public string? CuisineName { get; set; }
        public string? ItemName { get; set; }
        public int? ItemCuisineId { get; set; }
        public decimal? Cost { get; set; }

        public virtual FoodMenu? ItemCuisine { get; set; }
        public virtual ICollection<FoodDetail> FoodDetails { get; set; }
        public virtual ICollection<FoodMenu> InverseItemCuisine { get; set; }
    }
}
