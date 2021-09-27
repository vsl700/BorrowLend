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
        public string Lender { get; set; }
    }
}
