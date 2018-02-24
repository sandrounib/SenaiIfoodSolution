using System;
using Microsoft.AspNetCore.Mvc;
using senai.ifood.domain.Contacts;
using senai.ifood.domain.Entities;

namespace senai.ifood.webapi.Controllers
{

    [Route("api/[controller]")]
    public class RestauranteController : Controller
    {

         private IBaseRepository<RestauranteDomain> _restauranteRepository;


         public RestauranteController(IBaseRepository<RestauranteDomain> restauranteRepository)
         {
             _restauranteRepository = restauranteRepository;
         }

        
        [HttpGet] 

        public IActionResult GetAction(){           
            return Ok(_restauranteRepository.Listar(new string[]{"ProdutosRestaurante"}));
        }                

    }
}