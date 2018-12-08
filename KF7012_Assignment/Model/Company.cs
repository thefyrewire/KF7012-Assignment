using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class Company
    {
        [Key]
        public int companyID { get; set; }

        [MaxLength(255)]
        public string name { get; set; }

        [MaxLength(255)]
        public string location { get; set; }

        [MaxLength(25)]
        public string machineID { get; set; }
    }
}
