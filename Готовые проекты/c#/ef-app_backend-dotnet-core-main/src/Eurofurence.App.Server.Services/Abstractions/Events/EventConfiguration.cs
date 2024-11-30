using Microsoft.Extensions.Configuration;

namespace Eurofurence.App.Server.Services.Abstractions.Events
{
    public class EventConfiguration
    {
        public string Url { get; set; }

        public static EventConfiguration FromConfiguration(IConfiguration configuration)
        //rcs1250 Упростите создание объекта
            => new EventConfiguration
            {
                Url = configuration["events:url"],
            };
    }
}
