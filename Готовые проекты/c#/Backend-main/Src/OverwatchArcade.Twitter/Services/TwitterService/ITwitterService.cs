namespace OverwatchArcade.Twitter.Services.TwitterService
{
    public interface ITwitterService
    {
        //ревью -- лучше использовать dto
        public Task PostTweet(string screenshotUrl, string currentEvent);
        public Task DeleteLastTweet();
    }
}
