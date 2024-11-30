using OverwatchArcade.Domain.Models.Constants;

namespace OverwatchArcade.Domain.Models
{
    //ревью -- класс можно сделать sealed
    public class Whitelist
    {
        //ревью -- возможен null reference exception
        public string ProviderKey { get; set; }
        public SocialProviders Provider { get; set; }
    }
}