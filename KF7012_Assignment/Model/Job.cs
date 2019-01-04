using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KF7012_Assignment
{
    public class Job
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int jobID { get; set; }

        [Required]
        public int companyID { get; set; }

        [Required, MaxLength(25)]
        public string machineID { get; set; }

        [Required, MaxLength]
        public string fault { get; set; }

        [Required]
        public DateTime dateReported { get; set; }

        [Required]
        public int urgency { get; set; }

        [Required]
        public DateTime lastStartDate { get; set; }

        [Required, MaxLength(15)]
        public string state { get; set; }
    }
}
