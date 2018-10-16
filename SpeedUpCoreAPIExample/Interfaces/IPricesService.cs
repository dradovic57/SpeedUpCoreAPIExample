using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace SpeedUpCoreAPIExample.Interfaces
{
    //public class IPricesService
    //{
    //}
    public interface IPricesService
    {
        Task<IActionResult> GetPricesAsync(int productId);
    }
}
