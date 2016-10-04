
namespace FPageManager.FacebookProperties
{
    public class FacebookError
    {
        public ErrorObject Error { get; set; }

        public override string ToString()
        {
            if (this.Error != null)
                return string.Format("Facebook Error!!\nCode:{0}\nMessage:{1}\nType:{2}\nError_SubCode:{3}",
                    Error.Code, Error.Message, Error.Type, Error.Error_SubCode);
            else
                return string.Empty;
        }
    }
}
