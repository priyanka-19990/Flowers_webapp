using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plants_WebApplication3.Models;
using Plants_WebApplication3.RequestModal;

namespace Plants_WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private readonly PlantsContext _plantscontext;

        public FlowersController(PlantsContext plantss)
        {
            _plantscontext = plantss;
        }



        // GET: api/Flowers
        [HttpGet]
        public IActionResult Get()
        {
            var getflowers = _plantscontext.Flowers.ToList();
            return Ok(getflowers);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get1(int id)
        {
            try
            {
                var getid = _plantscontext.Flowers.First(obj => obj.SNo == id);
                if (getid == null)
                    return NotFound();
                return Ok(getid);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Flower SNo Not Found");
            }
        }


        //get: api/flowers
        [HttpGet("Flowers/{value}")]
        public IActionResult Get(string value)
        {



            var result = _plantscontext.Flowers.Where(obj => obj.Name.Contains(value));
            return Ok(result);



        }


        // POST: api/Flowers
        [HttpPost]
         public void Post([FromBody] Class value)
         {
            Flowers obj = new Flowers();
            obj.Name = value.Name;
            obj.BinomialName = value.BinomialName;
            obj.State = value.State;
            _plantscontext.Flowers.Add(obj);
            _plantscontext.SaveChanges();



         }

         // PUT: api/Flowers/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE: api/ApiWithActions/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }
    }
}
