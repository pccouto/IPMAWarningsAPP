using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IPMAWarningsApp.Models;
using IPMAWarningsApp.API;

namespace IPMAWarningsApp.Controllers
{
    public class IPMAController
    {
        private readonly IAiCaller _apiCaller;

        public IPMAController(IAiCaller apiCaller)
        {
            _apiCaller = apiCaller;
        }

        public Task<List<Aviso>> GetWarningsAsync()
        {
            return _apiCaller.GetWarningsAsync();
        }
    }
}
