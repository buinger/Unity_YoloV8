//如果好用，请收藏地址，帮忙分享。
using System.Collections.Generic;


namespace com.baidu.ai.search
{
    //如果好用，请收藏地址，帮忙分享。
    public class User_listItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string group_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float score { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public string face_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<User_listItem> user_list { get; set; }
    }

    public class FaceSearchInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public long error_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error_msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long log_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long cached { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Result result { get; set; }
    }
}