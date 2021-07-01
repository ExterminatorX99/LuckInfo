using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

// ReSharper disable UnassignedField.Global

namespace LuckInfo
{
    public class LuckConfig : ModConfig
    {
        [Label("Number of decimals")]
        [DefaultValue(3)]
        [Range(1, 9)]
        public int Decimals;

        public static LuckConfig Instance => ModContent.GetInstance<LuckConfig>();
        public override ConfigScope Mode => ConfigScope.ClientSide;
    }
}
