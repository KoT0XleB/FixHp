using Qurre.API.Addons;
using System.Collections.Generic;
using System.ComponentModel;

namespace FixHP
{
    public class Config : IConfig
    {
        [Description("Plugin Name")]
        public string Name { get; set; } = "FixHP";
        [Description("Enable the plugin?")]
        public bool IsEnable { get; set; } = true;
        [Description("Dictionary of all classes: ")]
        public Dictionary<RoleType, int> ConfigMaxpHp { get; set; } = new Dictionary<RoleType, int>
        {
            [RoleType.ChaosConscript] = 120,
            [RoleType.ChaosMarauder] = 120,
            [RoleType.ChaosRepressor] = 120,
            [RoleType.ChaosRifleman] = 120,
            [RoleType.ClassD] = 100,
            [RoleType.FacilityGuard] = 100,
            [RoleType.NtfCaptain] = 150,
            [RoleType.NtfPrivate] = 100,
            [RoleType.NtfSergeant] = 120,
            [RoleType.NtfSpecialist] = 120,
            [RoleType.Scientist] = 100,
            [RoleType.Scp049] = 2500,
            [RoleType.Scp0492] = 500,
            [RoleType.Scp096] = 2000,
            [RoleType.Tutorial] = 100,
            [RoleType.Scp106] = 850,
            [RoleType.Scp173] = 3000,
            [RoleType.Scp93953] = 1800,
            [RoleType.Scp93989] = 1800,
            [RoleType.Tutorial] = 100
        };
    }
}
