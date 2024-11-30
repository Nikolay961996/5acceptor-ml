using OverwatchArcade.Domain.Models.Overwatch;

namespace OverwatchArcade.Persistence.Repositories.Interfaces
{
    public interface IDailyRepository : IRepository<Daily>
    {
        //ревью -- методы можно сделать асиннхронными
        Daily GetDaily();
        public Task SoftDeleteDaily();
        public Task HardDeleteDaily();
        public Task<bool> HasDailySubmittedToday();
    }
}