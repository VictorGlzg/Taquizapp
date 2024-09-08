using System.Text.Json;

namespace Taquizapp.Services
{
    public abstract class BaseService
    {
        public readonly JsonSerializerOptions JsonOptions;

        public BaseService()
        {
            JsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }
    }
}
