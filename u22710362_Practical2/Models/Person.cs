﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u22710362_Practical2.Models
{
	public class Person
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Current Age")]
        public int Age { get; set; } = 0;
        [Display(Name = "Living Status")]
        public bool IsAlive { get; set; } = true;
        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }
    }
}