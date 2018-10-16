using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SpeedUpCoreAPIExample.Models;

namespace SpeedUpCoreAPIExample.Interfaces
{
    //public class IPricesRepository
    //{
    //}
    public interface IPricesRepository
    {
        Task<IEnumerable<Price>> GetPricesAsync(int productId);
    }
}
