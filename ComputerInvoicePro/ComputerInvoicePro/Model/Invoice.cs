using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComputerInvoicePro.Model
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public int CustomerId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? Discount { get; set; }

        public string CustomerName { get; set; }

        public Customer Customer { get; set; }
    }
}
