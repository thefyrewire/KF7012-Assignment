/*
 Patricia Fernandes
 Bogdana Grigore
 Michael Hay

 https://gitlab.com/thefyrewire/kf7012-assignment
*/

using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace KF7012_Assignment
{
    public class User
    {
        [Key, Required]
        public int userID { get; set; }

        [Required, MaxLength(25)]
        public string username { get; set; }

        [Required, MaxLength(50)]
        public string password { get; set; }

        [Required, MaxLength(25)]
        public string profile { get; set; }
    }
}
