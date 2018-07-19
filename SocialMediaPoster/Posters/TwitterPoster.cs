using TweetSharp;
namespace SocialMediaPoster.Posters
{
    class TwitterPoster
    {
        /// <summary>
        /// posts a Post object to twitter
        /// only posts body and tags
        /// order goes body-->tags, truncates anything over 280 characters
        /// </summary>
        /// <param name="post">the Post object that will be posted</param>
        public static void Post(Classes.Post post)
        {
            TwitterService  service = new TwitterService(Config.TWITTER_CONSUMER_KEY, Config.TWITTER_CONSUMER_SECRET, Config.TWITTER_ACCESS_TOKEN, Config.TWITTER_TOKEN_SECRET);

            string message = post.GetBody() + Utilities.HashTagify(post.GetTags());

            service.SendTweet(new SendTweetOptions { Status =message.Substring(0,280) });//truncates if over 280 characters
        }

        /// <summary>
        /// posts a Post object to twitter
        /// posts url, body, and tags
        /// order goes url-->body-->tags, truncates anything over 280 characters
        /// </summary>
        /// <param name="post">the Post object that will be posted</param>
        public static void p(Classes.Post post)
        {
            TwitterService service = new TwitterService(Config.TWITTER_CONSUMER_KEY, Config.TWITTER_CONSUMER_SECRET, Config.TWITTER_ACCESS_TOKEN, Config.TWITTER_TOKEN_SECRET);

            string message = post.GetUrl()+" "+  post.GetBody() + Utilities.HashTagify(post.GetTags());

            service.SendTweet(new SendTweetOptions { Status = message.Substring(0, 280) });//truncates if over 280 characters
        }

    }
}

