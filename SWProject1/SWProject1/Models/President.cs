using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace SWProject1.Models
{  
        [Table("President")]
        public class President
        {
            [Key]
            public int PresidentID { get; set; }
            public int MissionID {get; set;}
            public string PresFirstName { get; set;}
            public string PresLastName { get; set;}
            public string WifeFirstName { get; set;}
            public string WifeLastName { get; set; }
        }
    
}