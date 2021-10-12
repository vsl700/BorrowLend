using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class ExpenseType
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Expense Type Name")]
        public string ExpenseTypeName { get; set; }
    }
}
