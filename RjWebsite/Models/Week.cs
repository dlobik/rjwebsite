using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RjWebsite.Models
{
    public class Week
    {
        public int ID { get; set; }
        public int RoommateID { get; set; }
        public virtual Roommate Roommate { get; set; }
        public virtual Chore Chore { get; set; }
        public virtual ICollection<Chore> AssignedChores { get; set; }
    }
}