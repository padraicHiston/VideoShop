using System;
using System.ComponentModel.DataAnnotations;
using VideoShop.Models;

namespace VideoShop.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; } // Entity Framework recongnizes this convention (MembershipTypeId) and treats this property as a Foreign Key.

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}