using System;
using System.Collections.Generic;

#nullable disable

namespace handicrafe_v2.Models
{
    public partial class Handicraft
    {
        public Handicraft()
        {
            Sales = new HashSet<Sale>();
        }

        public decimal IdHandicraft { get; set; }
        public string Name { get; set; }
        public DateTime Datee { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Id { get; set; }

        public virtual UserInfo IdNavigation { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
