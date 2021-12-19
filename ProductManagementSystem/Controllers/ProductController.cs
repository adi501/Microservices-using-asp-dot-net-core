using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            List<ProductModel> listofobj = new List<ProductModel>();
            ProductModel obj = new ProductModel();
            obj.Id = 1;
            obj.CategoryId = 1;
            obj.Name = "Product 1";
            listofobj.Add(obj);

            obj = new ProductModel();
            obj.Id = 2;
            obj.CategoryId = 1;
            obj.Name = "Product 2";
            listofobj.Add(obj);

            return listofobj;
        }
    }
}
