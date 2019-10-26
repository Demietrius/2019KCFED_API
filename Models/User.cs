using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _2019KCFED_API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public string ShortDescription { get; set; }
        public int Location { get; set; }

        /// <summary>
        /// Collection for database
        /// </summary>
        public ICollection<int> ImageId { get; set; }
        public ICollection<int> BusinessID { get; set; }
        public ICollection<Links> Links { get; set; }

        public ICollection<Message> Messages { get; set; }

        public ICollection<Skill> Skills { get; set; }
        public ICollection<string> Filters{ get; set; }


    }

/// <summary>
/// Link object for database
/// </summary>
    public class Links
    {
        public string url { get; set; }
        public int id { get; set; }
        public string Tag { get; set; }
        public int ImageId { get; set; }
    }
    /// <summary>
    /// skill object for database
    /// </summary>

    public class Skill
    {
        public string skill { get; set; }
        public int skillId { get; set; }
    }

    /// <summary>
    /// Message object for database
    /// </summary>

    public class Message{
        public string SavedMessage { get; set; }
        public int MessageId { get; set; }
        public User Users { get; set; }




    }
}
