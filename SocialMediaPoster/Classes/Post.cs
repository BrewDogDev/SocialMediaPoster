using System;
using System.Collections.Generic;

namespace SocialMediaPoster.Classes
{
    public class Post
    {
        private string title;
        private string body;
        private string url;
        private List<string> socialMediaList;
        private List<string> tagList;
        public Post()
        {
            title = "";
            body = "";
            url = "";
            socialMediaList = new List<string>();
            tagList = new List<string>();
        }

        /// <summary>
        /// get method for body of Post
        /// </summary>
        /// <returns>body of Post</returns>
        public string GetBody()
        {
            return body;
        }
        /// <summary>
        /// get method for all the social media the post should be posted to
        /// </summary>
        /// <returns> string List of social media to be posted to</returns>
        public List<string> GetSocialMedia()
        {
            return socialMediaList;
        }
        /// <summary>
        /// get method for tags on this Post
        /// </summary>
        /// <returns>string list of tags to be posted with Post</returns>
        public List<string> GetTags()
        {
            return tagList;
        }
        /// <summary>
        /// get method for title of this Post
        /// </summary>
        /// <returns>string title of this Post</returns>
        public string GetTitle()
        {
            return title;
        }
        /// <summary>
        /// get method for canonical url of this post (the original site this post was posted to)
        /// </summary>
        /// <returns>string url of this Posts origin</returns>
        public string GetUrl()
        {
            return url;
        }


        /// <summary>
        /// set method for body of this post
        /// </summary>
        /// <param name="newBody"> what the body of this post will be after this method is run(string)</param>
        public void SetBody(string newBody)
        {
            body = newBody;
        }
        /// <summary>
        /// set method for title of this post
        /// </summary>
        /// <param name="newTitle">what the title of this post will be after this method is run(string)</param>
        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }
        /// <summary>
        /// set method for the canonical url of this post(canonical url = site to which this post was originally posted)
        /// </summary>
        /// <param name="newUrl">what the canonical url of this post will be after this method is run</param>
        public void SetUrl(string newUrl)
        {
            url = newUrl;
        }
        /// <summary>
        /// set method for the tags of this post
        /// </summary>
        /// <param name="newTags">list of strings, each string is a tag that will be posted with this Post</param>
        public void SetTags(List<string> newTags)
        {
            tagList = newTags;
        }
        /// <summary>
        /// set method for social media of this post
        /// </summary>
        /// <param name="newSocialMedia"> list of strings, each string is a social media site that this Post will be posted to</param>
        public void SetSocialMedia(List<string> newSocialMedia)
        {
            socialMediaList = newSocialMedia;
        }


        /// <summary>
        /// adds a tag to this post
        /// </summary>
        /// <param name="tagToAdd"> a string representing a tag that this post will have</param>
        public void AddTag(string tagToAdd)
        {
            tagList.Add(tagToAdd);
        }
        /// <summary>
        /// adds a social media site to this post
        /// </summary>
        /// <param name="socialMediaToAdd">string repesenting a social media ste that this Post will be posted to</param>
        public void AddSocialMedia(string socialMediaToAdd)
        {
            socialMediaList.Add(socialMediaToAdd);
        }


        /// <summary>
        /// removes a social media site from this post by name
        /// </summary>
        /// <param name="socialMediaToRemove">the string name of the site that will be removed after this mehtod is run</param>
        public void RemoveSocialMedia(string socialMediaToRemove)
        {
            socialMediaList.Remove(socialMediaToRemove);
        }
        /// <summary>
        /// removes a tag from this post
        /// </summary>
        /// <param name="tagToRemove">string name of the tag that will be removed after this method is run</param>
        public void RemoveTag(string tagToRemove)
        {
            socialMediaList.Remove(tagToRemove);
        }
        
    }
}
