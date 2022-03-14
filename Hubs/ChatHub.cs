using Microsoft.AspNetCore.SignalR;

namespace SIgnalRConnectionBlazorApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message, string user)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, user);
        }
    }
}
