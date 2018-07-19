using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPoster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Classes.Post p = new Classes.Post();
            p.AddTag("gog");
            p.AddTag("dog");
            p.AddTag("wog");
            p.AddTag("sog");
            p.SetBody("I wonder what will haven when i break the character limit, will it truncate, will it not post, will it explode twitter, will it post anyway, will the entire world die, will anything happen at all, will it send back an error message probably....... O wait that one didnt even break the character limit cuz apperently they increased it, which is weird... why would they do that, silly twatters.... okay i think that was atlest 40 characters");
            p.SetTitle("still works i hope!");
            p.AddSocialMedia("Medium");
            p.AddSocialMedia("Twitter");
            PostToSocialMedia(p);
            Console.ReadKey();
        }


        /// <summary>
        /// This method posts the paramater Post to all social media listed in the post
        /// </summary>
        /// <param name="post">Post to be posted to all social media listed</param>
        public static void PostToSocialMedia(Classes.Post post)
        {
            if(post.GetSocialMedia().Contains("Medium"))
            {
                Posters.MediumPoster.Post(post);
            }
            if (post.GetSocialMedia().Contains("Twitter"))
            {
                Posters.TwitterPoster.Post(post);
            }

        }
    }
}
