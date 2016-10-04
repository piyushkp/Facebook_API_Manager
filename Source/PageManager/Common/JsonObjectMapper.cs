using FPageManager.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FPageManager.FacebookProperties;

namespace FPageManager.Common
{
    class JsonObjectMapper
    {
        public List<Post> PostMapper(JsonObject input)
        {
            List<Post> _listPost = new List<Post>();
            object picture, from, link, comments, caption, description, message;
            foreach (JsonObject post in (JsonArray)input["data"])
            {
                _listPost.Add(new Post()
                {
                    Id = (string)(post["id"]),
                    Created_Time = Convert.ToDateTime((post["created_time"])),
                    is_published = (bool)(post["is_published"]),
                    Type = (string)(post["type"]),
                    Description = (string)(post.TryGetValue("description", out description) ? description : null),
                    Message = (string)(post.TryGetValue("message", out message) ? message : null),
                    Caption = (string)(post.TryGetValue("caption", out caption) ? caption : null),
                    From = (JsonObject)(post.TryGetValue("from", out from) ? from : null),
                    Picture = (string)(post.TryGetValue("picture", out picture) ? picture : null),
                    Link = (string)(post.TryGetValue("link", out link) ? link : null),
                    Comments = (JsonObject)(post.TryGetValue("comments", out comments) ? comments : null),
                });
            }
            if (input.ContainsKey("paging"))
            {
                foreach (var page in (JsonObject)(input["paging"]))
                {
                    if (page.Key == "previous")
                        _listPost[0].previous = (string)page.Value;
                    if (page.Key == "next")
                        _listPost[0].next = (string)page.Value;
                }
            }
            return _listPost;
        }

        public int PostViewMapper(JsonObject input)
        {
            object values;
            foreach (JsonObject post in (JsonArray)input["data"])
            {
                foreach (JsonObject value in (JsonArray)post["values"])
                    return Convert.ToInt32((value.TryGetValue("value", out values) ? values : null));
            }
            return 0;
        }

        public Dictionary<string,int> PostViewMapperList(JsonObject input)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            object values = null, id = null;
            foreach (JsonObject item in input.Values)
            {
                foreach (JsonObject post in (JsonArray)item["data"])
                {
                    foreach (JsonObject value in (JsonArray)post["values"])
                    {
                        Convert.ToInt32((value.TryGetValue("value", out values) ? values : null));                        
                        //output.Add(input.Keys[index], Convert.ToInt32((values)));
                    }
                    id = post["id"];
                    id = id.ToString().Substring(0, id.ToString().IndexOf('/'));                    
                    output.Add(id.ToString(), Convert.ToInt32((values)));
                }
            }
            return output;
        }
    }
}
