using CategoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CategoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<CategoryModel> Get()
        {
            List<CategoryModel> listofobj = new List<CategoryModel>();
            CategoryModel obj = new CategoryModel();
            obj.Id = 1;
            obj.Name = "Category 1";
            listofobj.Add(obj);

            obj = new CategoryModel();
            obj.Id = 2;
            obj.Name = "Category 2";
            listofobj.Add(obj);

            return listofobj;
        }
    }
}
