using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage= "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+" , ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage= "Please enter your Phone #")]
        public string Phone { get; set; }

        [Required(ErrorMessage= "Please let us know if you'll attend")]
        // used nullable bool so we could determine if a choice has been made or not.
        public bool? WillAttend { get; set; }
    }
}