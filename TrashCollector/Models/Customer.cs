using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Display(Name = "Pick Up Day")]
        public DayOfWeek PickupDay { get; set; }

        [Display(Name = "Extra Pickup Date")]
        [DataType(DataType.Date)]
        public DateTime? ExtraPickupDate { get; set; }

        [Display(Name = "Suspension Starting Date")]
        [DataType(DataType.Date)]
        public DateTime? SuspensionStartDate { get; set; }

        [Display(Name = "Suspension End Date")]
        [DataType(DataType.Date)]
        public DateTime? SuspensionEndDate { get; set; }

        [Display(Name = "Amount Due")]
        [DataType(DataType.Currency)]
        public double? AmountDue { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
