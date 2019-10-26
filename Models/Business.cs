using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019KCFED_API.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public int MyProperty { get; set; }

        public string ShortDescription { get; set; }
        public string BusinessResume { get; set; }
        public int OwnerId { get; set; }
        public int CandidateId { get; set; }
        public ICollection<string> Category { get; set; }
        
    }
}
