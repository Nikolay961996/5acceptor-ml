using OverwatchArcade.Domain.Models.ContributorInformation.Personal;

namespace OverwatchArcade.Domain.Models.ContributorInformation
{
    public class About
    {
        //ревью -- возможен null reference exception
        public string Text { get; set; }
        //ревью -- возможен null reference exception
        public Country Country { get; set; }
    }
}