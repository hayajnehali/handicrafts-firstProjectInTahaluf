﻿using System;
using System.Collections.Generic;

#nullable disable

namespace handicrafe_v2.Models
{
    public partial class VisaCard
    {
        public decimal IdVisa { get; set; }
        public decimal Total { get; set; }
        public decimal Id { get; set; }

        public virtual UserInfo IdNavigation { get; set; }
    }
}
