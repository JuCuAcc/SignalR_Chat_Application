using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Jashim_Evidence.Models;

[assembly: OwinStartup(typeof(Jashim_Evidence.Startup))]

namespace Jashim_Evidence
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            app.MapConnection<MyPerConnection>("/jashim");
        }
    }
}
