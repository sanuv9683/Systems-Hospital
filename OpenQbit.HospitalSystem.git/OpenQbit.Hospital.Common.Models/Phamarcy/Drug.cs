﻿using OpenQbit.Hospital.Common.Models.Phamarcy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
    public class Drug
    {
        public int DrugID { get; set; }

        public String drugName { get; set; }

        public String description { get; set; }

        public String company { get; set; }

        public DateTime madeDate { get; set; }

        public DateTime expireDate { get; set; }

        public virtual Medicine Medicine { get; set; }

    }

}