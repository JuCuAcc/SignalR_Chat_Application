using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Jashim_Evidence.Models
{
    public class ChatContext:DbContext
    {
        public ChatContext():base("DbCon")
        {

        }
        public DbSet<ChatMessage> ChatMessages  { get; set; }
    }
}