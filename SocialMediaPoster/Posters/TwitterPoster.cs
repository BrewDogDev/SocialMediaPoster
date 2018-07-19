using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;
using TweetSharp;


namespace SocialMediaPoster.Posters
{
    class TwitterPoster
    {
        public static void Post(Classes.Post post)
        {
            TwitterService  service = new TwitterService(Config.TWITTER_CONSUMER_KEY, Config.TWITTER_CONSUMER_SECRET, Config.TWITTER_ACCESS_TOKEN, Config.TWITTER_TOKEN_SECRET);

            string message = post.GetBody() + Utilities.HashTagify(post.GetTags());

            service.SendTweet(new SendTweetOptions { Status =message.Substring(0,280) });//truncates if over 280 characters
        }

        public static void PostWithUrl(Classes.Post post)
        {
            TwitterService service = new TwitterService(Config.TWITTER_CONSUMER_KEY, Config.TWITTER_CONSUMER_SECRET, Config.TWITTER_ACCESS_TOKEN, Config.TWITTER_TOKEN_SECRET);

            string message = post.GetUrl()+" "+  post.GetBody() + Utilities.HashTagify(post.GetTags());

            service.SendTweet(new SendTweetOptions { Status = message.Substring(0, 280) });//truncates if over 280 characters
        }

    }
}

