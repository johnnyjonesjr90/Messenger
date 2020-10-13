using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Messenger.Models;
using Microsoft.AspNetCore.Identity;

namespace Messenger.Models
{
    // Add profile data for application users by adding properties to the MessengerUser class
    public class MessengerUser : IdentityUser
    {
        public int UserID { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        public MessengerUser()
        {
            Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
