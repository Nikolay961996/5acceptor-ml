using OverwatchArcade.Domain.Models.Overwatch;

namespace OverwatchArcade.Persistence.Repositories.Interfaces
{
    public interface IOverwatchRepository : IRepository<ArcadeMode>
    {
        //ревью -- методы можно сделать асиннхронными
        List<ArcadeMode> GetArcadeModes();
        List<Label> GetLabels();
    }
}
