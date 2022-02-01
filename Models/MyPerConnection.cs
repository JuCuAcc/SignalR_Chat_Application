using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Jashim_Evidence.Models;

namespace Jashim_Evidence.Models
{
    public class MyPerConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return Connection.Send(connectionId, "Welcome!");
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {

            ChatMessage chatMessage = new ChatMessage();
            chatMessage.UserName = "Persistant User";
            chatMessage.Message = data;

            ChatContext db = new ChatContext();
            db.ChatMessages.Add(chatMessage);
            db.SaveChanges();

            return Connection.Broadcast(data);
        }
    }
}