namespace OverwatchArcade.Domain.Models.ContributorInformation.Personal
{
    public class Country
    {
        //ревью -- возможен null reference exception
        public string Name { get; set; }
        //ревью -- возможен null reference exception
        public string Code { get; set; }
    }
}