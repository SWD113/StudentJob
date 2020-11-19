﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOS.Job
{
	public class JobRequest
	{
        public int Id { get; set; }
        public string MajorCode { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Benefit { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}
