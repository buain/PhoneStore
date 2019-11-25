﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.Models
{
    public class Purchase
    {
        //phone purchase model
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int PhoneId { get; set; }
        public DateTime Date { get; set; }
    }
}