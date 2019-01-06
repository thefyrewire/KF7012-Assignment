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
    public class Company
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyID { get; set; }

        [MaxLength(255), Required]
        public string name { get; set; }

        [MaxLength(255), Required]
        public string location { get; set; }

        /*[MaxLength(25)]
        public string machineID { get; set; }*/
    }
}
