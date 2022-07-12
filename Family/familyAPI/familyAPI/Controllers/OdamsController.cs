using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using familyAPI.Data;

namespace familyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdamsController : ControllerBase
    {
        private readonly FamilyDb _context;
        public OdamsController(FamilyDb context)
        {
            _context = context;
        }

        [HttpGet("/all")]
        public object GetOdam()
        {           
            return _context.Odam.Select(o => new { o.Id, o.Name });
        }

        [HttpGet("/{id}")]
        public object GetOdam(int id)
        {            
            return _context.Odam.AsEnumerable().Where(o => o.Id == id).ToList();            
        }                    
    }
}
