#region Namespaces

using Facebook;
using FPageManager.Base;
using FPageManager.Common;
using FPageManager.FacebookProperties;
using FPageManager.Objects;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;

#endregion

namespace FPageManager.Managers
{
    /// <summary>
    /// Contains methods to handle Facebook Post
    /// </summary>
    public class FacebookPostManager : FacebookManager, IFacebookPostManager
    {
        #region Members

        FacebookClient fb;
        JsonObjectMapper _mapper = new JsonObjectMapper();

        #endregion

        #region C'tor

        public FacebookPostManager(FacebookClient client)
        {
            fb = client;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Creates a Facebook post
        /// </summary>
        /// <param name="post">The post object</param>
        /// <param name="accessToken">The Facebook access token</param>
        /// <returns>Returns the Id of the newly created the post</returns>
        public string CreatePost(Dictionary<string, object> parameters)
        {
            try
            {
                dynamic result = fb.Post(base.pageID + "/feed", parameters);
                return result.id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///  Upload Multiple Photos 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public JsonArray UploadMultiplePhotos(List<Dictionary<string, object>> parameters)
        {
            try
            {
                FacebookBatchParameter[] batchArray = new FacebookBatchParameter[parameters.Count];
                for (int i = 0; i < parameters.Count; i++)
                {
                    batchArray[i] = new FacebookBatchParameter(HttpMethod.Post, base.pageID + "/photos", parameters[i]);
                }

                dynamic result = fb.Batch(batchArray);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Upload Multiple Video files
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public JsonArray UploadMultipleVideos(List<Dictionary<string, object>> parameters)
        {
            try
            {
                FacebookBatchParameter[] batchArray = new FacebookBatchParameter[parameters.Count];
                for (int i = 0; i < parameters.Count; i++)
                {
                    batchArray[i] = new FacebookBatchParameter(HttpMethod.Post, base.pageID + "/videos", parameters[i]);
                }
                dynamic result = fb.Batch(batchArray);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Upload large video in chunk
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        async public Task<bool> UploadVideoInChunk(string filePath)
        {
            try
            {
                int size = (int)new System.IO.FileInfo(filePath).Length;
                
                string[] _initOut = InitUploadSession(size);
                string upload_session_id = _initOut[0];
                int start_offset = Convert.ToInt32(_initOut[2]);
                int end_offset = Convert.ToInt32(_initOut[3]);
                int index = 0;
                do
                {
                    // upload video in chunk
                    byte[] bytes = readFileInChunk(filePath, start_offset, (end_offset - start_offset) -2);
                    //Array.Copy(input,bytes,(end_offset-start_offset));
                    int[] _out = await TransferInChunk(upload_session_id, start_offset, index, bytes);
                    if (_out.Length > 1)
                    {
                        start_offset = _out[0];
                        end_offset = _out[1];
                    }
                    index++;
                } while (start_offset != end_offset);

                return FinishInChunk(upload_session_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Read input video file in chunk, if the input video file size greater than 2 GB
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public byte[] readFileInChunk(string filePath, int startIndex, int length)
        {
            try
            {
                byte[] buffer = new byte[length];
                using (Stream video = File.OpenRead(filePath))
                {
                    video.Seek(startIndex, 0);
                    int bytesRead = video.Read(buffer, 0, buffer.Length);
                }
                return buffer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Initialize the upload session
        /// </summary>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        public string[] InitUploadSession(int fileSize)
        {
            try
            {
                string[] output = new string[4];
                Dictionary<string, object> parameter = new Dictionary<string, object>
                {
                    {"upload_phase", "start"},
                    {"file_size", fileSize}
                };
                dynamic result = fb.Post(base.pageID + "/videos", parameter);
                output[0] = result.upload_session_id;
                output[1] = result.video_id;
                output[2] = result.start_offset;
                output[3] = result.end_offset;
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Transfer the chunk of data
        /// </summary>
        /// <param name="upload_session_id"></param>
        /// <param name="start_offset"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        async public Task<int[]> TransferInChunk(string upload_session_id, int start_offset, int index, byte[] bytes)
        {
            try
            {
                int[] output = new int[2];
                var mediaObject = new FacebookMediaObject
                {
                    FileName = "@chunk" + index + ".mp4",
                    ContentType = "video/mp4"
                };
                mediaObject.SetValue(bytes);

                Dictionary<string, object> parameter = new Dictionary<string, object>
                {
                    {"upload_phase", "transfer"},
                    {"upload_session_id", upload_session_id},
                    {"start_offset", start_offset},
                    {"video_file_chunk", mediaObject}
                };
                dynamic result = await fb.PostTaskAsync(base.pageID + "/videos", parameter);
                output[0] = Convert.ToInt32(result.start_offset);
                output[1] = Convert.ToInt32(result.end_offset);
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Finish the upload large video
        /// </summary>
        /// <param name="upload_session_id"></param>
        /// <returns></returns>
        public bool FinishInChunk(string upload_session_id)
        {
            try
            {
                Dictionary<string, object> parameter = new Dictionary<string, object>
                {
                    {"upload_phase", "finish"},
                    {"upload_session_id", upload_session_id}
                };
                dynamic result = fb.Post(base.pageID + "/videos", parameter);
                MessageBox.Show("Uploading large file is done.");
                return (bool)result.success;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets all published page Posts
        /// </summary>
        /// <param name="postId">The Id of the Facebook Post</param>
        /// <param name="accessToken">The Facebook access token</param>
        /// <returns>Returns a Facebook post object</returns>
        public List<Post> GetAllPublishedPosts(string pageID, bool isPagination, string url)
        {
            try
            {
                List<Post> posts = new List<Post>();
                if (!isPagination)
                {
                    Dictionary<string, object> _parameters = new Dictionary<string, object>
                                 {                                     
                                     {"fields", new[] {"id", "message", "is_published", "picture", "type","created_time", "from","to","link","caption","description","comments"}}
                                 };
                    JsonObject _output = fb.Get(base.pageID + "/posts", _parameters) as JsonObject;
                    posts = _mapper.PostMapper(_output);
                    
                    //get all views in one API call
                    var s = string.Join(",", posts.Select(p => p.Id.ToString()));
                    Dictionary<string, int> views = GetNumberOfPeopleViewedInOneRequest(s);
                    foreach (Post post in posts)
                    {
                        post.NumberOfPeopleViewed = views[post.Id];
                    }
                }
                else
                {
                    JsonObject _output = fb.Get(url) as JsonObject;
                    posts = _mapper.PostMapper(_output);
                    
                    //get all views in one API call
                    var s = string.Join(",", posts.Select(p => p.Id.ToString()));
                    Dictionary<string, int> views = GetNumberOfPeopleViewedInOneRequest(s);
                    foreach (Post post in posts)
                    {
                        post.NumberOfPeopleViewed = views[post.Id];
                    }

                }
                return posts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageID"></param>
        /// <param name="isPagination"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public List<Post> GetAllUnpublishedPosts(string pageID, bool isPagination, string url)
        {
            try
            {
                List<Post> posts = new List<Post>();
                if (!isPagination)
                {
                    Dictionary<string, object> _parameters = new Dictionary<string, object>
                                 {                                     
                                     {"fields", new[] {"id", "message", "is_published", "picture", "type","created_time", "from","to","link","caption","description","comments", "scheduled_publish_time", "is_expired"}}
                                 };
                    JsonObject _output = fb.Get(base.pageID + "/promotable_posts?is_published=false", _parameters) as JsonObject;
                    posts = _mapper.PostMapper(_output);
                    //foreach (Post post in posts)
                    //{
                    //    GetNumberOfPeopleViewedByPost(post);
                    //}
                }
                else
                {
                    JsonObject _output = fb.Get(url) as JsonObject;
                    posts = _mapper.PostMapper(_output);
                    //foreach (Post post in posts)
                    //{
                    //    GetNumberOfPeopleViewedByPost(post);
                    //}
                }
                return posts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, int> GetNumberOfPeopleViewedInOneRequest(string ids)
        {
            try
            {
                //post_id/insights/post_impressions_unique?period=day&since=1427846400&until=1429142400
                JsonObject _output = fb.Get(base.pageID + "/insights/post_impressions_unique?ids="+ids, null) as JsonObject;
                return _mapper.PostViewMapperList(_output);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        ///{page-id}/insights/page_posts_impressions
        /// <summary>
        /// get the number of people viewed by post
        /// </summary>
        /// <param name="post"></param>
        public void GetNumberOfPeopleViewedByPost(Post post)
        {
            try
            {
                //post_id/insights/post_impressions_unique?period=day&since=1427846400&until=1429142400
                JsonObject _output = fb.Get(post.Id + "/insights/post_impressions_unique", null) as JsonObject;
                post.NumberOfPeopleViewed = _mapper.PostViewMapper(_output);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletePost(string post_id)
        {
            try
            {
                dynamic result = fb.Delete(post_id);
                return result.sucess;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonArray EditPost(string post_id, Dictionary<string, object> parameters)
        {
            try
            {
                FacebookBatchParameter[] batchArray = new FacebookBatchParameter[2];
                batchArray[0] = new FacebookBatchParameter(HttpMethod.Delete, post_id);
                batchArray[1] = new FacebookBatchParameter(HttpMethod.Post, post_id,parameters);
                dynamic result = fb.Batch(batchArray);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Async Methods

        async public Task<List<Post>> GetAllPublishedPostsAsync(bool isPagination, string url)
        {
            try
            {
                List<Post> posts = new List<Post>();
                if (!isPagination)
                {
                    Dictionary<string, object> _parameters = new Dictionary<string, object>
                                 {                                     
                                     {"fields", new[] {"id", "message", "is_published", "picture", "type","created_time", "from","to","link","caption","description","comments"}}
                                 };
                    dynamic _output = await fb.GetTaskAsync(FacebookManager.Instance.pageID + "/posts", _parameters) as JsonObject;
                    posts = _mapper.PostMapper(_output);
                    //get all views in one API call
                    var s = string.Join(",", posts.Select(p => p.Id.ToString()));
                    Dictionary<string, int> views = GetNumberOfPeopleViewedInOneRequest(s);
                    foreach (Post post in posts)
                    {
                        post.NumberOfPeopleViewed = views[post.Id];
                    }
                }
                else
                {
                    JsonObject _output = await fb.GetTaskAsync(url) as JsonObject;
                    posts = _mapper.PostMapper(_output);
                    //foreach (Post post in posts)
                    //{
                    //    GetNumberOfPeopleViewedByPost(post);
                    //}

                    //get all views in one API call
                    var s = string.Join(",", posts.Select(p => p.Id.ToString()));
                    Dictionary<string, int> views = GetNumberOfPeopleViewedInOneRequest(s);
                    foreach (Post post in posts)
                    {
                        post.NumberOfPeopleViewed = views[post.Id];
                    }
                }
                return posts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task<JsonArray> UploadMultiplePhotosAsync(List<Dictionary<string, object>> parameters)
        {
            try
            {
                FacebookBatchParameter[] batchArray = new FacebookBatchParameter[parameters.Count];
                for (int i = 0; i < parameters.Count; i++)
                {
                    batchArray[i] = new FacebookBatchParameter(HttpMethod.Post, base.pageID + "/photos", parameters[i]);
                }

                dynamic result = await fb.BatchTaskAsync(batchArray);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task<JsonArray> UploadMultipleVideosAsync(List<Dictionary<string, object>> parameters)
        {
            try
            {
                FacebookBatchParameter[] batchArray = new FacebookBatchParameter[parameters.Count];
                for (int i = 0; i < parameters.Count; i++)
                {
                    batchArray[i] = new FacebookBatchParameter(HttpMethod.Post, base.pageID + "/videos", parameters[i]);
                }
                dynamic result = await fb.BatchTaskAsync(batchArray);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
