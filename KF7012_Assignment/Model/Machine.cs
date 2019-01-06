/*
 Patricia Fernandes
 Bogdana Grigore
 Michael Hay

 https://gitlab.com/thefyrewire/kf7012-assignment
*/

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KF7012_Assignment
{
    public class Machine
    {
        [Key, Required, MaxLength(25), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string machineID { get; set; }

        [Required]
        public int companyID { get; set; }

        [Required, MaxLength(25)]
        public string assetTag { get; set; }

        [Required]
        public int sizeComplexity { get; set; }

        [MaxLength]
        public string description { get; set; }
    }
}