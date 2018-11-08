using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        [HttpGet]
        public ActionResult Get()
        {
            if (FakeData.Products != null)
            {
                return Ok(FakeData.Products.Values.ToArray());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (FakeData.Products.ContainsKey(id))
                return Ok(FakeData.Products[id]);
            else
                return NotFound();
        }

        [HttpGet("price/{low}/{high}")]
        public ActionResult Get(int low, int high)
        {
            var products = FakeData.Products.Values
            .Where(p => p.Price >= low && p.Price <= high).ToArray();
            if (products.Length > 0)
            { // LINQ guarantees the products won't be null
                return Ok(products);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]Product product)
        {
            product.ID = FakeData.Products.Keys.Max() + 1;
            FakeData.Products.Add(product.ID, product);
            return Created($"api/products/{product.ID}", product); // contains the new ID
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Product product)
        {
            if (FakeData.Products.ContainsKey(id))
            {
                var target = FakeData.Products[id];
                target.ID = product.ID;
                target.Name = product.Name;
                target.Price = product.Price;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("raise/{priceRaise}")]
        public ActionResult Put([FromRoute]double priceRaise)
        {
            try
            {
                foreach (KeyValuePair<int, Product> productDict in FakeData.Products)
                {
                    productDict.Value.Price += priceRaise;
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }



        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (FakeData.Products.ContainsKey(id))
            {
                FakeData.Products.Remove(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}