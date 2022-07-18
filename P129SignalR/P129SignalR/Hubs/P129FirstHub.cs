﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129SignalR.Hubs
{
    public class P129FirstHub : Hub
    {
        public async Task MesajGonder(string isdifadeci, string mesaji)
        {
            await Clients.All.SendAsync("mesajqebuleden", isdifadeci, mesaji, DateTime.UtcNow.AddHours(4).ToString("dd.MM.yyyy HH:mm"));
        }
    }
}
