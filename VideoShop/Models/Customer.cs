using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; } // Entity Framework recongnizes this convention (MembershipTypeId) and treats this property as a Foreign Key.
    }
}