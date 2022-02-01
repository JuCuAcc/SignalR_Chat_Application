using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jashim_Evidence.Models
{
    public class ChatHub : Hub
    {
        public void sendMessage(string name, string message)
        {
            ChatMessage chatMessage = new ChatMessage();
            chatMessage.UserName = name;
            chatMessage.Message = message;

            ChatContext db = new ChatContext();
            db.ChatMessages.Add(chatMessage);
            db.SaveChanges();

            Clients.All.broadcastMessage(name, message);
        }
    }
}