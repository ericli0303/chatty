﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chatty.Api.Models;

namespace Chatty.Api.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
