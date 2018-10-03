using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MVCSignalRChatSolution.Services
{
    public class ChatHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}



        public void Send(string name, string message, string connID)
        {
            // sendChat --> mismo nombre que en JavaScript
            //Clients.All.sendChat(name, message);
            Clients.All.sendChat(name, message, connID);
        }

        // Cuando un Usuaerio se Conecta
        public override Task OnConnected()
        {
            var _name = Context.User.Identity.Name;




            //Clients.All.newUser(Context.ConnectionId);
            return base.OnConnected();
        }

        // Cuando un Usuario se Desconecta
        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
    }
}