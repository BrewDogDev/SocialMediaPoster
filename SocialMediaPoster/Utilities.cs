using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPoster
{
    /// <summary>
    /// A class to store global helper methods
    /// </summary>
    class Utilities
    {
        /// <summary>
        /// makes a string html if it is not already html
        /// Checks by seeing if the first character is <
        /// </summary>
        /// <param name="content">string to be formatted as html</param>
        /// <returns>content paramater wrapped in p/p tags</returns>
        public static string MakeHtml(string content)
        {
            if (content.StartsWith("<"))//check for html
            {
                return content;//do nothing if already html
            }
            else
            {
                return "<p>" + content + "</p>";//wrap in p tags if not in html and return
            }
        }
        /// <summary>
        /// Takes in a list of strings and formats them as medium wants them sent to their api
        /// ex: [this, that, the other]  ==>
        /// \"this\", \"that\", \"the other\"
        /// </summary>
        /// <param name="tags">list of tags to be formatted</param>
        /// <returns>tags formatted csv with qoutes surrounding each</returns>
        public static string FormatTags(List<string> tags)
        {
            string tagString = "";
            for(int i =0;i<tags.Count;i++)
            {
                tagString = tagString + "\""+tags[i]+ "\"";
                if (!(i == tags.Count - 1))
                {
                    tagString = tagString + ", ";
                }
            }
            return tagString;
        }

        public static string HashTagify(List<string> tags)
        {
            string hashTags = "";
            for (int i = 0; i < tags.Count; i++)
            {
                hashTags = hashTags +" #"+ tags[i];
            }
            return hashTags;
        }
    }
}
