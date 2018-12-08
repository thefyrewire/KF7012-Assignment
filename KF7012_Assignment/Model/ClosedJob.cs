using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class ClosedJob
    {
        [Key, Required]
        public int jobID { get; set; }

        [Required]
        public DateTime completionDate { get; set; }

        public DateTime closingDate { get; set; }

        [MaxLength]
        public string solution { get; set; }

        [MaxLength]
        public string notes { get; set; }
    }
}
