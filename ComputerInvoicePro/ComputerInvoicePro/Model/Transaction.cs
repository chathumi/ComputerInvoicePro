using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerInvoicePro.Model
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int CustomerID { get; set; }

        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        public Customer Customer { get; set; }

        public Invoice Invoice { get; set; }
    }
}
