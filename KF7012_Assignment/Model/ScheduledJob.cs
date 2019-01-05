using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class ScheduledJob
    {
        [Key, Required]
        public int scheduledJobID { get; set; }

        [Required]
        public int jobID { get; set; }

        [Required]
        public int assignedEngineer {get; set;}

        [Required]
        public int estimatedDays { get; set; }
    }
}
