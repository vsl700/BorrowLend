using System.ComponentModel.DataAnnotations;

namespace BorrowLend.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        public string Borrower { get; set; }

        [Required]
        //[EmailAddress(ErrorMessage = "Invalid email address :)")]
        [RegularExpression("^[a-zA-Z0-9_.]+@([a-zA-Z]+.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid email address :))")]
        public string Email { get; set; }

        [Required]
        public string Lender { get; set; }
    }
}
