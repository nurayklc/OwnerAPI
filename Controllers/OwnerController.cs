using Microsoft.AspNetCore.Mvc;
using OwnerAPI.DataGenerator;
using OwnerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OwnerAPI.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("AllOwners")]
        public List<Owner> GetOwners()
        {
            return new OwnerData().GetAllOwners();
        }


        [HttpPost]
        [Route("Create")]
        [Consumes("application/json")]
        public IActionResult CreateOwner(Owner owner)
        {
            var owners = new OwnerData().GetAllOwners();
            owners.Add(owner);
            return owner.Description.Contains("hack") ? BadRequest("Your description cannot contain the word hack") :  Ok(owner);
        }


        [HttpPut("{id:int}")]
        public IActionResult UpdateOwner(int id, Owner owner)
        {
            var result = new OwnerData().GetAllOwners().FirstOrDefault(x => x.Id == id);
            if (result is null)
                throw new InvalidOperationException("Kullanıcı bulunamadı");
            result.NameSurname = owner.NameSurname != default ? owner.NameSurname : result.NameSurname;
            result.Description = owner.Description != default ? owner.Description : result.Description;
            result.Genre = owner.Genre != default ? owner.Genre : result.Genre;
            return Ok(result);
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteOwner(int id)
        {
            var res = new OwnerData().GetAllOwners();
            var owner = res.FirstOrDefault(x => x.Id == id);
            if (owner is null)
                return NotFound($"{id} not found owner");

            res.Remove(owner);
            return Ok("Delete owner successfully");
        }
    }
}
