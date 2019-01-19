using System.Collections.Generic;
using System.Linq;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ZentryAnticheat.Client.Controller
{
    public class PedManager : BaseScript
    {
        private int[] pedIdInterzise = new int[9]
        {
            451459928,
            882848737,
            351016938,
            307287994,
            1684083350,
            880829941,
            1096929346,
            -1404353274,
            2109968527
        };

        private int[] objIdInterzise = new int[52]
        {
            -1298203218,
            970385471,
            -553616286,
            243282660,
            -1968824367,
            1109266474,
            779917859,
            -1147467348,
            2108146567,
            2064886860,
            -1354005816,
            -1268267712,
            -234152995,
            -234152995,
            568309711,
            1888301071,
            323971301,
            2124719729,
            -1003748966,
            -1639085878,
            289396019,
            -131025346,
            148511758,
            -1065766299,
            14103519,
            -1295299286,
            1208606316,
            -468144679,
            -1645730886,
            -1236638811,
            1372198431,
            -717890986,
            1714199852,
            1737474779,
            -1027860019,
            -1507470892,
            -1775547488,
            932490441,
            1088428993,
            -543669801,
            1803116220,
            -1240857364,
            -1011638209,
            118627012,
            1952396163,
            267881419,
            -1288515433,
            1623304263,
            1426534598,
            -1991361770,
            322248450,
            1945457558
        };


        public void PedScan()
        {
            CitizenFX.Core.Debug.WriteLine("CHECANDO");
            foreach (Ped allPed in World.GetAllPeds())
            {
                int entityModel = API.GetEntityModel(allPed.Handle);
                int selectedPedWeapon = API.GetSelectedPedWeapon(allPed.Handle);
                if (API.DoesEntityExist(allPed.Handle))
                {
                    if (selectedPedWeapon == -1312131151 || selectedPedWeapon ==
                        -2084633992)
                        allPed.Delete();
                    else if (((IEnumerable<int>) this.pedIdInterzise).Contains<int>(entityModel))
                        allPed.Delete();
                }
            }

            foreach (Entity allProp in World.GetAllProps())
            {
                int entityModel = API.GetEntityModel(allProp.Handle);
                if (API.DoesEntityExist(allProp.Handle) &&
                    ((IEnumerable<int>) this.objIdInterzise).Contains<int>(entityModel))
                    allProp.Delete();
            }
        }
    }
}