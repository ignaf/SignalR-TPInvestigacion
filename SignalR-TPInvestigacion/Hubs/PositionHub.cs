using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_TPInvestigacion.Hubs
{
    public class PositionHub : Hub
    {
        public async Task SendPosition(int left, int top)
        {
            await Clients.Others.SendAsync("ReceivePosition", left, top);
        }
    }
}
