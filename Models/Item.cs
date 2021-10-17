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
        [RegularExpression("[0-9]{9}", ErrorMessage = "Invalid phone 📱! Requires only 9 digits! First digit is not required!")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Lender { get; set; }
    }
}
