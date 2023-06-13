using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers.ActionFilters
{
    public class RateLimitFilter : ActionFilterAttribute
    {
        private readonly int _limit;
        private readonly int _period;

        public RateLimitFilter(int limit, int period)
        {
            _limit = limit;
            _period = period;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
            var cacheKey = $"RateLimitFilter_{ipAddress}";

            var cache = context.HttpContext.RequestServices.GetRequiredService<IMemoryCache>();

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(_period));

            if (!cache.TryGetValue(cacheKey, out int requestCount))
            {
                requestCount = 0;
            }

            if (requestCount >= _limit)
            {
                context.Result = new StatusCodeResult(429); // Too Many Requests
                return;
            }

            cache.Set(cacheKey, requestCount + 1, cacheEntryOptions);

            await next();
        }
    }
}
