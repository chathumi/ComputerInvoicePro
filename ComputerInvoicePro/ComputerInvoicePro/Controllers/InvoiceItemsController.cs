using ComputerInvoicePro.Model;
using ComputerInvoicePro.Service.Interface;
using ComputerInvoicePro.Service.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputerInvoicePro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceItemsController : ControllerBase
    {
        private readonly IRepository<InvoiceItem> _invoiceItemService;

        public InvoiceItemsController(IRepository<InvoiceItem> invoiceItemService)
        {
            _invoiceItemService = invoiceItemService;
        }

        // GET: api/InvoiceItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceItem>>> GetInvoiceItems()
        {
            var invoiceItems = await _invoiceItemService.GetAllAsync();
            return Ok(invoiceItems);
        }

        // GET: api/InvoiceItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceItem>> GetInvoiceItem(int id)
        {
            var invoiceItem = await _invoiceItemService.GetByIdAsync(id);

            if (invoiceItem == null)
            {
                return NotFound();
            }

            return invoiceItem;
        }

        // POST: api/InvoiceItems
        [HttpPost]
        public async Task<ActionResult<InvoiceItem>> PostInvoiceItem(InvoiceItem invoiceItem)
        {
            try
            {
                await _invoiceItemService.AddAsync(invoiceItem);
                return CreatedAtAction(nameof(GetInvoiceItem), new { id = invoiceItem.InvoiceItemID }, invoiceItem);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/InvoiceItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceItem(int id, InvoiceItem invoiceItem)
        {
            if (id != invoiceItem.InvoiceItemID)
            {
                return BadRequest();
            }

            try
            {
                await _invoiceItemService.UpdateAsync(id, invoiceItem);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        // DELETE: api/InvoiceItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceItem(int id)
        {
            var deleted = await _invoiceItemService.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
