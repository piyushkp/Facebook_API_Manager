#region Namespaces

using Facebook;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Text;

#endregion

namespace FPageManager.Base{
    
    #region Class

    /// <summary>
    /// 
    /// </summary>
    public class FacebookManager
    {
        #region Members

        private string _appID = ConfigurationManager.AppSettings["APPID"];
        private string _appSecret = ConfigurationManager.AppSettings["AppSecret"];
        private string _pageID = ConfigurationManager.AppSettings["PageID"];
        private static FacebookManager instance;
        static FacebookClient fb = new FacebookClient();

        #endregion

        #region Properties

        public string AppToken { get; set; }
        public string UserToken { get; set; }
        public string PageToken { get; set; }
        public string appID { get; set; }
        public string appSecret { get; set; }
        public string pageID { get; set; }
        //singleton pattern
        public static FacebookManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FacebookManager();
                }
                return instance;
            }
        }

        #endregion

        #region C'tor

        public FacebookManager()
        {
            appID = _appID;
            appSecret = _appSecret;
            pageID = _pageID;

            AppToken = getAppAccessToken();
            UserToken = getUserAccessToken();
            PageToken = getPageAccessToken();
        }

        #endregion

        #region Methods

        private string getUserAccessToken()
        {
            return ConfigurationManager.AppSettings["UserAccessToken"];            
        }

        private string getAppAccessToken()
        {
            try
            {
                dynamic result = fb.Get("oauth/access_token", new
                {
                    client_id = appID,
                    client_secret = appSecret,
                    grant_type = "client_credentials",
                    scope = "manage_pages,publish_stream,read_insights",
                });

                return result.access_token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string getPageAccessToken()
        {
            try
            {
                fb.AccessToken = UserToken;
                dynamic result = fb.Get(pageID + "?fields=access_token", null);

                return result.access_token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }

    #endregion
}
