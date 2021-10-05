using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class Expense
    {
        public int ID { get; set; }
        public string ExpenseName { get; set; }
        public double Amount { get; set; }
    }
}
