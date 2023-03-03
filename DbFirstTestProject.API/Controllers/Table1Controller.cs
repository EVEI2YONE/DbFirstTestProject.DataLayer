using DbFirstTestProject.DataLayer.Context;
using DbFirstTestProject.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DbFirstTestProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Table1Controller : ControllerBase
    {
        private readonly ILogger<Table1Controller> _logger;
        private readonly EntityProjectContext _context;

        public Table1Controller(ILogger<Table1Controller> logger, EntityProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("Details/{id}")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            return Ok(_context.Set<Table1>().Find(id));
        }

        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            var test = _context.Table1.Select(x => x.Col1_PK); //_context.Table1.FromSqlRaw("Select * from Table_1");
            var count = test.Count();
            var obj = new Table1() { Col3 = (int?)count };
            _context.Set<Table1>().Add(obj);
            _context.SaveChanges();
            return Ok(obj.Col1_PK);
        }
    }
}