using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class Job
    {
        [Key]
        public int jobID { get; set; }

        [MaxLength]
        public string description { get; set; }

        [Required]
        public DateTime dateReported { get; set; }

        [Required]
        public int priority { get; set; }

        public virtual Company Company { get; set; }
        public virtual Machine Machine { get; set; }
    }
}
