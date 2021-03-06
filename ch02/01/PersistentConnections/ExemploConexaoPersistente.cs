﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace _01.PersistentConnections
{
    public class ExemploConexaoPersistente : PersistentConnection
    {

        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return base.OnConnected(request, connectionId);
        }
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }

        
    }
}