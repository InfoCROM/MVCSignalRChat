using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MVCSignalRChatSolution.Startup))]

namespace MVCSignalRChatSolution
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Para obtener más información sobre cómo configurar la aplicación, visite https://go.microsoft.com/fwlink/?LinkID=316888

            // Iniciaizamos SignalR
            app.MapSignalR();
        }
    }
}
