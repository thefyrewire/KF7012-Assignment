using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class Engineer
    {
        [Key, Required, MaxLength(25)]
        public string engineerID { get; set; }

        [MaxLength(255)]
        public string name { get; set; }

        [Required, MaxLength(25)]
        public string profile { get; set; }

        [MaxLength]
        public string skills { get; set; }
    }
}
