using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using MVCSignalRChatSolution.Data.Models;

namespace MVCSignalRChatSolution.Services
{
    public class ChatHub : Hub
    {
        private DBService _dBService = new DBService();

        public void Send(string name, string message, string connID)
        {
            // sendChat --> mismo nombre que en JavaScript
            //Clients.All.sendChat(name, message);
            Clients.All.sendChat(name, message, connID);
        }

        // Cuando un Usuaerio se Conecta
        public override Task OnConnected()
        {
            var _userId = Context.QueryString["userId"];
            var _user = _dBService.GetUser(_userId);

            if (_user != null)
            {
                _user.ConnectionId = Context.ConnectionId;
                _dBService.UpdateUser(_user);
            }

            Clients.All.activeUsers(_dBService.GetUsers());

            return base.OnConnected();
        }

        // Cuando un Usuario se Desconecta
        public override Task OnDisconnected(bool stopCalled)
        {
            var _userId = Context.QueryString["userId"];
            var _user = _dBService.GetUser(_userId);

            if (_user != null)
                _dBService.DeleteUser(_user);

            Clients.All.activeUsers(_dBService.GetUsers());

            return base.OnDisconnected(stopCalled);
        }
    }
}