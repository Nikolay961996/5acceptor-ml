using OverwatchArcade.Domain.Models.ContributorInformation.Game;

namespace OverwatchArcade.Domain.Models.ContributorInformation;

public class ContributorProfile
{
    //ревью -- возможен null reference exception
    public About Personal { get; init; }
    //ревью -- возможен null reference exception
    public Socials Social { get; set; }
    //ревью -- возможен null reference exception
    public OverwatchProfile Overwatch { get; init; }
}