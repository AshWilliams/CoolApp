using System.Web;

namespace CoolChat.Application.Lifecycle
{
    /// <summary>
    /// Fired when a new user visits the application Web site.
    /// </summary>
    public partial class MvcApplication : HttpApplication
    {
        protected void Session_Start()
        {            
        }
    }
}