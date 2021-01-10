
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models.Users
{
   public class CustomIdentityUser// : IdentityUser<int>
    {
        public int Id { get; set; }
        [StringLength(32)]
        public string FirstName { get; set; }

        [StringLength(32)]
        public string LastName { get; set; }

        public long Mobile { get; set; }

        [StringLength(32)]
        public string PhotoFileName { get; set; }
        public DateTimeOffset? BrithDate { get; set; }
        public DateTimeOffset? LastVisitDateTime { get; set; }

        public bool IsEmailPublic { get; set; }
        public string Location { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateAt { get; set; }

        public int LoginCount { get; set; }

        public int PurchasedNumber { get; set; }
        public CustomIdentityUser()
        {

        }

        public void UpdatePurchasedNumber()
        {
            PurchasedNumber = PurchasedNumber + 1;
        }
    }
}
