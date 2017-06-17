﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.Common.Models.Management
{
    public class Employee
    {
        public int EmployeeId { get; set; }


        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
