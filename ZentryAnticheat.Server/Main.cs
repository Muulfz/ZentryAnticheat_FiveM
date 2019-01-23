using System;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace ZentryAnticheat.Server
{
    public class Main : BaseScript
    {
        public Main()
        {
            this.Tick += new Func<Task>(this.OnTick);
        }

        private async Task OnTick()
        {
            BaseScript.TriggerClientEvent("scanEntitys");
            await BaseScript.Delay(500);
        }
    }
}