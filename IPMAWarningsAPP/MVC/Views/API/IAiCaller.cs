using IPMAWarningsApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IPMAWarningsApp.API
{
    public interface IAiCaller
    {
        Task<List<Aviso>> GetWarningsAsync();
    }
}
