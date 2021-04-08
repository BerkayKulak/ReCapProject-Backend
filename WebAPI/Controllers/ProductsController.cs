using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled = gevşek bağlılık yani soyuta bağlı
        //naming convention
        //IoC Container -- Inversion of control = değişimin kontrolü
        ICarService _carService;//defaultu private tabi
        public ProductsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public List<Car> Get()
        {

            // dependency chain--

            var result = _carService.GetAll();
            return result.Data;
        }
    }
}
