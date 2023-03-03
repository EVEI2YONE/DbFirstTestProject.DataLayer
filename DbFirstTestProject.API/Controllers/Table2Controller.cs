using DbFirstTestProject.DataLayer.Context;
using DbFirstTestProject.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstTestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Table2Controller : Controller
    {
        private readonly ILogger<Table1Controller> _logger;
        private readonly EntityProjectContext _context;

        public Table2Controller(ILogger<Table1Controller> logger, EntityProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("Details/{id}")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            return Ok(_context.Set<Table2>().Find(id));
        }

        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            var count = _context.Table2.Count();

            _context.Set<Table2>().Add(new Table2() { Col5_Extra = count });
            _context.SaveChanges();
            return Ok(count+1);
        }
    }
}
