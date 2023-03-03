using DbFirstTestProject.DataLayer.Context;
using DbFirstTestProject.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstTestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Table3Controller : Controller
    {
        private readonly ILogger<Table1Controller> _logger;
        private readonly EntityProjectContext _context;

        public Table3Controller(ILogger<Table1Controller> logger, EntityProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("Details/{id}")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            return Ok(_context.Set<Table3>().Find(id));
        }

        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            var count = _context.Table3.Count();

            _context.Set<Table3>().Add(new Table3() { Col4_Extra = count % 2 == 0 ? count : null });
            _context.SaveChanges();
            return Ok(count+1);
        }
    }
}
