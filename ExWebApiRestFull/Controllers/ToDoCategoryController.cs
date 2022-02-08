using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExWebApiRestFull.Controllers
{
    [Route("api/ToDo/{ToDoId}/Categories/{CategoryId}")]
    public class ToDoCategoryController : Controller
    {
        [HttpPost]
        public IActionResult Post(int ToDoId , int CategoryId)
        {
            //find todo
            //find category
            //add category
            return Ok();
        }
    }
}
