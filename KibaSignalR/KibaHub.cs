using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Linq;
using System.Threading.Tasks;

namespace KibaSignalR
{
    
    //这里命名尽量用小写，因为前台只认小写
    [HubName("kibahub")]
    public class kibahub : Hub
    {  
        // 这里函数命名虽然是大写，但前台Js调用要用小写字母开头
        public void Send(string message)
        {
            var id = Context.ConnectionId; 
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<kibahub>();
            context.Clients.Client(id).getmessage("518"); 
        }
        public override Task OnConnected()
        {
            var id = Context.ConnectionId;
            return base.OnConnected();
        } 
    }
}
