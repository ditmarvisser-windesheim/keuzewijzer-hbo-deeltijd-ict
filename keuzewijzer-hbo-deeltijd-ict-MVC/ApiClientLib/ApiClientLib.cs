namespace keuzewijzer_hbo_deeltijd_ict_MVC.ApiClientLib
{
    public class ApiClient
    {
        private readonly IHttpClientFactory _factory;
        private Uri _baseaddress;

        public ApiClient(IHttpClientFactory factory, string baseaddress)
        {
            _factory = factory;
            _baseaddress = new Uri(baseaddress);
        }

        public async Task<HttpResponseMessage> Get(string path, string key)
        {
            if (key != "") path += "/" + key;
            var client = _factory.CreateClient();
            client.BaseAddress = _baseaddress;
            var response = await client.GetAsync(path);
            return response;
        }

        public async Task<HttpResponseMessage> Post<T>(string path, T entity)
        {
            var client = _factory.CreateClient();
            client.BaseAddress = _baseaddress;
            var response = await client.PostAsJsonAsync(path, entity);
            return response;
        }

        public async Task<HttpResponseMessage> Put<T>(string path, string key, T entity)
        {
            path += "/" + key;
            var client = _factory.CreateClient();
            client.BaseAddress = _baseaddress;
            var response = await client.PutAsJsonAsync(path, entity);
            return response;
        }

        public async Task<HttpResponseMessage> Delete(string path, string key)
        {
            path += "/" + key;
            var client = _factory.CreateClient();
            client.BaseAddress = _baseaddress;
            var response = await client.DeleteAsync(path);
            return response;
        }
    }
}
