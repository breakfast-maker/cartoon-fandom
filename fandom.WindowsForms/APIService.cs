using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace fandom.WindowsForms
{
    class APIService
    {
        private readonly string _route = null;

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>()
        {
            var url = $"{Properties.Settings.Default.API}/{_route}";
            var result = await url.GetJsonAsync<T>();

            return result;
        }
    }
}
