using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore50Adventure.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Membership> Memberships { get; set; }
    }

    public class ExternalUser : User
    {
        public string ExternalCompany { get; set; }
    }

    public class TimeRestrictedUser : User
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Membership> Memberships { get; set; }
    }

    public class Membership
    {
        public User User { get; set; }
        public Group Group { get; set; }
        public DateTime MemberSince { get; set; }
    }
}
