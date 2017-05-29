using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(TaskBoardWebApi.Startup))]

namespace TaskBoardWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);

                var hubConfiguration = new HubConfiguration {
                    EnableJSONP = true,

                    #if DEBUG
                    EnableDetailedErrors = true
                    #endif
                };

                map.RunSignalR(hubConfiguration);
            });
        }
    }
}