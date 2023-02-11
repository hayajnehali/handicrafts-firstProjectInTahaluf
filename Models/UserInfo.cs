using System;
using System.Collections.Generic;

#nullable disable

namespace handicrafe_v2.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            FeedbackHandicrafts = new HashSet<FeedbackHandicraft>();
            Handicrafts = new HashSet<Handicraft>();
            Sales = new HashSet<Sale>();
            VisaCards = new HashSet<VisaCard>();
        }

        public decimal Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public DateTime RegisteringDate { get; set; }

        public virtual ICollection<FeedbackHandicraft> FeedbackHandicrafts { get; set; }
        public virtual ICollection<Handicraft> Handicrafts { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<VisaCard> VisaCards { get; set; }
    }
}
