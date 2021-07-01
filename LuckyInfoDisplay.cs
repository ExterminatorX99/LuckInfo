using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace LuckInfo
{
    public class LuckyInfoDisplay : InfoDisplay
    {
        protected override string DisplayNameInternal => Language.GetTextValue("RandomWorldName_Noun.Luck");

        public override string DisplayValue() => Main.LocalPlayer.luck.ToString($"F{LuckConfig.Instance.Decimals}", Language.ActiveCulture.CultureInfo);

        public override bool Active() => Main.LocalPlayer.GetModPlayer<LuckPlayer>().accLuck;
    }
}
