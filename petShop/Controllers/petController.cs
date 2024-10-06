namespace PetShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPets()
        {
            var pets = new List<string> { "Cachorro", "Gato", "Pássaro" };
            return Ok(pets); // Retorna 200 OK com a lista de pets
        }
    }
}
