﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime Orderdate { get; set; }
        public DateTime RequireDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public decimal Freight { get; set; }

        public virtual Member Member { get; set; }
    }
}
