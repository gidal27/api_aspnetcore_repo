using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course4.Models
{
    public class Note
    {
        public long Id { get; set; }
        public String subject { get; set; }
        public String Detail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModiefiedDate { get; set; }
        public Boolean IsDeleted { get; set; }//usable when we have to stop fetching this data from user app in front end; then just set the value as true..
    }

}
