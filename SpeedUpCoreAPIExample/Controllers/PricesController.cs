﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SpeedUpCoreAPIExample.Interfaces;

namespace SpeedUpCoreAPIExample.Controllers
{
    //public class PricesController
    //{
    //}
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        private readonly IPricesService _pricesService;

        public PricesController(IPricesService pricesService)
        {
            _pricesService = pricesService;
        }

        // GET /api/prices/1
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPricesAsync(int id)
        {
            return await _pricesService.GetPricesAsync(id);
        }
    }
}
