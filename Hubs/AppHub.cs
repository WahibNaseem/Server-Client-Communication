using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ServerApp_Prototype.Hubs
{

  public class AppHub : Hub
  {
    public Task BroadCastMessage(string sender, string message)
    {
      return Clients.Others.SendAsync(method: "ReceiveMessage", sender, message);
    }
  }
}
