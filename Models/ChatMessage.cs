using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jashim_Evidence.Models
{
    public class ChatMessage
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}