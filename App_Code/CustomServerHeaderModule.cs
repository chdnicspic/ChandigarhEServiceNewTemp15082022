
using System;
using System.Web;

namespace ChandigarheServices.ServerModules
{
    public class CustomServerHeaderModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PreSendRequestHeaders += OnPreSendRequestHeaders;
        }
        public void Dispose()
        {
        }
        public void OnPreSendRequestHeaders(object sender, EventArgs e)
        {

            System.Web.HttpContext.Current.Response.Headers.Remove("Server");
        }

    }
}
