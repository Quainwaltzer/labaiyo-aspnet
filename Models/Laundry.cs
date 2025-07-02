using LabaIyo.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;


namespace LabaIyo.Models
{
    public class Laundry
    {
        [Key]
        public int Id { get; set; }
        public string? fname { get; set; }
        public string? lname { get; set; }
        public string? email { get; set; }

        [Phone]
        [Display(Name = "Contact Number")]
        public string? phone { get; set; }
        public string? address { get; set; }
        public List<items> items { get; set; }

    }

    public class items
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Laundry")]
        public int LaundryId { get; set; }
        public Laundry Laundry { get; set; }

        public string itemName { get; set; }
        public string itemQuantity { get; set; }
        public string itemType { get; set; }
        public string itemColor { get; set; }

    }
    public class IdenUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}


