using System;
using MEC;
using Qurre;
using Qurre.API;
using Qurre.API.Events;

namespace FixHP
{
    public class FixHP : Plugin
    {
        public override string Developer => "KoToXleB#4663";
        public override string Name => "FixHP";
        public override Version Version => new Version(1, 0, 0);
        public override void Enable() => RegisterEvents();
        public override void Disable() => UnregisterEvents();
        public Config CustomConfig { get; private set; }
        public void RegisterEvents()
        {
            CustomConfig = new Config();
            CustomConfigs.Add(CustomConfig);
            if (!CustomConfig.IsEnable) return;

            Qurre.Events.Player.RoleChange += OnRoleChange;
        }
        public void UnregisterEvents()
        {
            CustomConfigs.Remove(CustomConfig);
            if (!CustomConfig.IsEnable) return;

            Qurre.Events.Player.RoleChange += OnRoleChange;
        }
        public void OnRoleChange(RoleChangeEvent ev)
        {
            if (CustomConfig.ConfigMaxpHp.TryGetValue(ev.NewRole, out int ConfigMaxpHp))
            {
                Timing.CallDelayed(0.1f, () => {
                    ev.Player.MaxHp = ConfigMaxpHp;
                    ev.Player.Hp = ConfigMaxpHp;
                });
            }
        }
    }
}
