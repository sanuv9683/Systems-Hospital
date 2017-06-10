﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public double totalAmount { get; set; }

        public double ItemDiscount { get; set; }

        public DateTime date { get; set; }

        public virtual Orders Orders { get; set; }
    }
}