using System;
using System.Collections.Generic;

#nullable disable

namespace handicrafe_v2.Models
{
    public partial class Sale
    {
        public decimal IdSales { get; set; }
        public DateTime DateSale { get; set; }
        public string PdfEmail { get; set; }
        public decimal IdHandicraft { get; set; }
        public decimal Id { get; set; }

        public virtual Handicraft IdHandicraftNavigation { get; set; }
        public virtual UserInfo IdNavigation { get; set; }
    }
}
