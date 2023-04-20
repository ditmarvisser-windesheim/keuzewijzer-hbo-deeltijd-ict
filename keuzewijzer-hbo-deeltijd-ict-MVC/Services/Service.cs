using keuzewijzer_hbo_deeltijd_ict_MVC.ApiClientLib;

namespace keuzewijzer_hbo_deeltijd_ict_MVC.Services
{
    public class Service<T> : IService<T> where T : new()
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _factory;
        private readonly string _connectionstring;

        public Service(IConfiguration configuration, IHttpClientFactory factory)
        {
            _configuration = configuration;
            _factory = factory;
            _connectionstring = _configuration.GetValue<string>("ApiUri");
        }

        public async Task<bool> AddAsync(T item, string path)
        {
            var apiClient = new ApiClient(_factory, _connectionstring);
            var response = await apiClient.Post(path, item);
            if (response.IsSuccessStatusCode) return true;
            return false;
        }

        public async Task<bool> DeleteAsync(int id, string path)
        {
            var apiClient = new ApiClient(_factory, _connectionstring);
            var response = await apiClient.Delete(path, id.ToString());
            if (response.IsSuccessStatusCode) return true;
            return false;
        }

        public async Task<List<T>> GetAsync(string path)
        {
            var items = new List<T>();
            var apiClient = new ApiClient(_factory, _connectionstring);
            var response = await apiClient.Get(path, "");
            if (response.IsSuccessStatusCode) items = await response.Content.ReadAsAsync<List<T>>(); 
            return items;
        }

        public async Task<T> GetAsync(int id, string path)
        {
            T item = new();
            var apiClient = new ApiClient(_factory, _connectionstring);
            var response = await apiClient.Get(path, id.ToString());
            if (response.IsSuccessStatusCode) item = await response.Content.ReadAsAsync<T>();
            return item;
        }

        public async Task<bool> UpdateAsync(int id, T item, string path)
        {
            var apiClient = new ApiClient(_factory, _connectionstring);
            var response = await apiClient.Put(path, id.ToString(), item);
            if (response.IsSuccessStatusCode) return true;
            return false;
        }

        public async Task<bool> UpdateSpecialAsync(int id, object item, string path)
        {
            var apiClient = new ApiClient(_factory, _connectionstring);
            var response = await apiClient.Put(path, id.ToString(), item);
            if (response.IsSuccessStatusCode) return true;
            return false;
        }
    }
}
