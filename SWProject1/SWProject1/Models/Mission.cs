using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SWProject1.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int MissionID { get; set; }
        public int PresID { get; set; }
        public string MissionHomeAddress { get; set; }
        public int CountryID { get; set; }
        public string MissionName { get; set; }
        public string Climate { get; set; }
        public string DominantReligion { get; set; }
    }
}