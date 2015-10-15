using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using _01.PersistentConnections;


namespace _01
{
  public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapSignalR();
            app.MapSignalR<ExemploConexaoPersistente>("/ExemploPC");
        }
    }
}