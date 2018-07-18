using RestSharp;
namespace SocialMediaPoster.Posters
{
    public class MediumPoster
    {   
        static void Post(Classes.Post post)
        {
            Post(post.GetTitle(),post.GetBody(),"","");
        }
        static void Post(string title, string body, string url, string tags)
        {
            var client = new RestClient("https://api.medium.com/v1/users/" + Config.MEDIUM_USER_ID + "/posts");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Postman-Token", "f3e31120-dab2-41cc-99a2-8d9b5c3008a0");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Authorization", "Bearer " + Config.MEDIUM_USER_AUTH_TOKEN);
            request.AddHeader("Host", "api.medium.com");
            request.AddHeader("Accept-Charset", "utf-8");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n  \"title\": \"" + title 
                                 + "\",\r\n  \"contentFormat\": \"html\",\r\n  \"content\": \"" + body 
                                 + "\",\r\n  \"canonicalUrl\": \"" + url 
                                 + "\",\r\n  \"tags\": [" + tags 
                                 + "],\r\n  \"publishStatus\": \"" + Config.MEDIUM_PUBLISH_STATUS 
                                 + "\"\r\n}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
        }
    }
}

