using System;
using System.Diagnostics;
using System.Threading.Tasks;
using CitizenFX.Core;
using ZentryAnticheat.Client.Controller;

namespace ZentryAnticheat.Client
{
    class Main : BaseScript
    {
        public Main()
        {    
            this.EventHandlers.Add("scanPeds",(Delegate) new Action(new PedManager().PedScan));
        }

    }
}