using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComputerInvoicePro.Model
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}