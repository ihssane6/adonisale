using ims.Data;
using ims.Models;
using ims.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ims.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/SProduct")]
    public class SProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IActionResult> GetSProduct()
        {
            List<SProduct> Items = await _context.SProduct.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<SProduct> payload)
        {
            SProduct sproduct = payload.value;
            _context.SProduct.Add(sproduct);
            _context.SaveChanges();
            return Ok(sproduct);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<SProduct> payload)
        {
            SProduct sproduct = payload.value;
            _context.SProduct.Update(sproduct);
            _context.SaveChanges();
            return Ok(sproduct);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<SProduct> payload)
        {
            SProduct sproduct = _context.SProduct
                .Where(x => x.SProductId == (int)payload.key)
                .FirstOrDefault();
            _context.SProduct.Remove(sproduct);
            _context.SaveChanges();
            return Ok(sproduct);

        }
    }
}
