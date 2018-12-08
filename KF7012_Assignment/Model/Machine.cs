using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class Machine
    {
        [Key, Required, MaxLength(25)]
        public string machineID { get; set; }

        [Required, MaxLength(25)]
        public string assetTag { get; set; }

        [Required]
        public int sizeComplexity { get; set; }

        public virtual Company Company { get; set; }
    }
}