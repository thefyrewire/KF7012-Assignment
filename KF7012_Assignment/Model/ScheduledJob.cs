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
        public int jobID { get; set; }

        [Required]
        public int priority { get; set; }

        public DateTime startDate { get; set; }

        [MaxLength]
        public string skillsNeeded {get; set;}

        [MaxLength(25)]
        public string completionTimeNeeded { get; set; }

        public DateTime completionDate { get; set; }
    }
}
