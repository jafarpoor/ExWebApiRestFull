using ExWebApiRestFull.Model.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExWebApiRestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly CategoryRepository categoryRepository;
        public CategoriesController(CategoryRepository category)
        {
            categoryRepository = category;
        }
        // GET: api/<CategoriesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(categoryRepository.GetAll());
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(categoryRepository.Find(id));
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Post(string Name)
        {
            var Result = categoryRepository.Add(Name);
            return Created(Url.Action(nameof(Get), "Categories", new { Id = Result }, Request.Scheme ), true);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut]
        public IActionResult Put([FromBody]CategoryDto categoryDto)
        {
            return Ok(categoryRepository.Edit(categoryDto));
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(categoryRepository.Delet(id));
        }
    }
}
