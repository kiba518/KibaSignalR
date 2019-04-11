using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
// 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
[assembly: OwinStartup(typeof(KibaSignalR.Startup))] 
namespace KibaSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(); 
        }
    }
}
