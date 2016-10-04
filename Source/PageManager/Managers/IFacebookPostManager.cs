using Facebook;
using FPageManager.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPageManager.Managers
{
    interface IFacebookPostManager
    {
        #region Methods

        /// <summary>
        /// Creates a Facebook post
        /// </summary>
        /// <param name="post">The post object</param>
        /// <param name="accessToken">The Facebook access token</param>
        /// <returns>Returns the Id of the newly created the post</returns>
        string CreatePost(Dictionary<string, object> parameters);
       

        /// <summary>
        ///  Upload Multiple Photos 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        JsonArray UploadMultiplePhotos(List<Dictionary<string, object>> parameters);
        

        /// <summary>
        /// Upload Multiple Video files
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        JsonArray UploadMultipleVideos(List<Dictionary<string, object>> parameters);
       
        /// <summary>
        /// Upload large video in chunk
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        Task<bool> UploadVideoInChunk(string filePath);
        
        /// <summary>
        /// Read input video file in chunk
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        byte[] readFileInChunk(string filePath, int startIndex, int length);
        
        /// <summary>
        /// Initialize the upload session
        /// </summary>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        string[] InitUploadSession(int fileSize);
        
        /// <summary>
        /// Transfer the chunk of data
        /// </summary>
        /// <param name="upload_session_id"></param>
        /// <param name="start_offset"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        Task<int[]> TransferInChunk(string upload_session_id, int start_offset, int index, byte[] bytes);
        
        /// <summary>
        /// Finish the upload large video
        /// </summary>
        /// <param name="upload_session_id"></param>
        /// <returns></returns>
        bool FinishInChunk(string upload_session_id);
        
        /// <summary>
        /// Gets all published page Posts
        /// </summary>
        /// <param name="postId">The Id of the Facebook Post</param>
        /// <param name="accessToken">The Facebook access token</param>
        /// <returns>Returns a Facebook post object</returns>
        List<Post> GetAllPublishedPosts(string pageID, bool isPagination, string url);
        
        List<Post> GetAllUnpublishedPosts(string pageID, bool isPagination, string url);
        
        ///{page-id}/insights/page_posts_impressions
        /// <summary>
        /// get the number of people viewed by post
        /// </summary>
        /// <param name="post"></param>
        void GetNumberOfPeopleViewedByPost(Post post);
       
        #endregion

        #region Async Methods

        Task<List<Post>> GetAllPublishedPostsAsync(bool isPagination, string url);
       
        Task<JsonArray> UploadMultiplePhotosAsync(List<Dictionary<string, object>> parameters);
        
        Task<JsonArray> UploadMultipleVideosAsync(List<Dictionary<string, object>> parameters);
        
        #endregion
    }
}
