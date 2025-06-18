using Microsoft.Xna.Framework;
namespace LuckInfo.Content.InfoDisplays;

using Common.Configs;
using Common.Players;

public sealed class LuckInfoDisplay : InfoDisplay
{
    public static string Format => "F" + LuckConfig.Instance.Decimals;

    public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)
    {
        if (Main.LocalPlayer.luck == 0) {
            displayColor = InactiveInfoTextColor;
        }

        return Main.LocalPlayer.luck.ToString(Format, Language.ActiveCulture.CultureInfo);
    }

    public override bool Active()
    {
        return Main.LocalPlayer.GetModPlayer<LuckPlayer>().LuckDisplay;
    }
}
