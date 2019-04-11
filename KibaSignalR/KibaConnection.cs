using Microsoft.AspNet.SignalR;
using System.Linq;
using System.Threading.Tasks;

namespace KibaSignalR
{
    public class KibaConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return Connection.Send(connectionId, "Welcome!");
            return base.OnConnected(request, connectionId);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
            return base.OnReceived(request, connectionId, data);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId, bool stopCalled)
        {
            return base.OnDisconnected(request, connectionId, stopCalled);
        }
        protected override Task OnReconnected(IRequest request, string connectionId)
        {
            return base.OnReconnected(request, connectionId);
        }
    }
}
