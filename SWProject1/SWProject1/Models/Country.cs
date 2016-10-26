﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace SWProject1.Models
{
    
        [Table("Country")]
        public class Country
        {
            [Key]
            public int CountryID { get; set; }
            public string CountryName { get; set;}
            public string Language { get; set;}
        }
    
}