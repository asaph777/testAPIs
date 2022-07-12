<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using familyAPI.Data;

namespace familyAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class OdamsController : ControllerBase
    {
        private readonly FamilyDb _context;
        public OdamsController(FamilyDb context)
        {
            _context = context;
        }

        [HttpGet("/all")]
        public async Task<ActionResult<IEnumerable<Odam>>> GetOdam()
        {
            if (_context.Odam == null)
            {
                return NotFound();
            }
            return await _context.Odam.ToListAsync();
        }

        [HttpGet("/{param}/{id}")]
        public List<Odam> GetOdam(int id, int param)
        {
            List<Odam> odams = new List<Odam>();
            recSearch(id, param, odams);
            return odams;
        }
        void recSearch(int? id, int param, List<Odam> odams)
        {
            var current = _context.Odam.Where(o => o.Id == id).SingleOrDefault();
            if (current != null)
            {
                if (param == 1)
                {
                    var father = _context.Odam.Where(o => o.Id == current.Father).SingleOrDefault();
                    if (father != null)
                    {
                        odams.Add(father);
                        recSearch(father.Id, param, odams);
                    }
                }
                if (param == 2)
                {
                    var childs = _context.Odam.Where(o => o.Father == current.Id).ToList();
                    if (childs.Count > 0)
                    {
                        for (int i = 0; i < childs.Count; i++)
                        {
                            odams.Add(childs[i]);
                            recSearch(childs[i].Id, param, odams);
                        }
                    }
                }
            }
        }
    }
}
>>>>>>> 2913a87e4978204e8b72e499b616b9331073ee7b
