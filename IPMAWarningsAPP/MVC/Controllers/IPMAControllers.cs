using System.Collections.Generic;
using System.Threading.Tasks;
using IPMAWarningsApp.API;
using IPMAWarningsApp.Models;
using IPMAWarningsApp.Views;

namespace IPMAWarningsApp.Controllers
{
    public class IPMAController
    {
        private readonly IAiCaller _apiCaller;
        private readonly IMainView _mainView;

        public IPMAController(IAiCaller apiCaller, IMainView mainView)
        {
            _apiCaller = apiCaller;
            _mainView = mainView;
            _mainView.SetController(this);
        }

        public async Task<List<Aviso>> GetWarningsAsync()
        {
            return await _apiCaller.GetWarningsAsync();
        }
    }
}
