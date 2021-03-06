﻿using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class SemesterStudent
    {
        public string SemesterCode { get; set; }
        public string StuCode { get; set; }
        public int Year { get; set; }

        public virtual Semester SemesterCodeNavigation { get; set; }
        public virtual Student StuCodeNavigation { get; set; }
    }
}
