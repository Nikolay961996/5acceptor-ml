using OverwatchArcade.Domain.Models.Constants;
using OverwatchArcade.Domain.Models.ContributorInformation;

namespace OverwatchArcade.Domain.Models
{
    public class Contributor
    {
        public Guid Id { get; init; }
        //ревью -- возможен null reference exception
        public string Username { get; init; }
        //ревью -- возможен null reference exception
        public string Email { get; init; }
        //ревью -- возможен null reference exception
        public string Avatar { get; set; }
        public ContributorGroup Group { get; init; }
        public ContributorStats? Stats { get; set; }
        public ContributorProfile? Profile { get; set; }
        public DateTime RegisteredAt { get; init; }
        
        public bool HasDefaultAvatar()
        {
            return Avatar.Equals(ImageConstants.DefaultAvatar);
        }
    }
}