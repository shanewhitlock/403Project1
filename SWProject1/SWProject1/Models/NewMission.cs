using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SWProject1.Models
{
    public class NewMission
    {
        [Key]
        public int MissionID { get; set; }
        public string MissionName { get; set; }
        public int PresID { get; set; }
        public int CountryID { get; set; }
        public string MissionHomeAddress { get; set; }
        public string PresFirstName { get; set; }
        public string PresLastName { get; set; }
        public string WifeFirstName { get; set; }
        public string WifeLastName { get; set; }
        public string Language { get; set; }
        public string Climate { get; set; }
        public string DominantReligion { get; set; }

    }
}