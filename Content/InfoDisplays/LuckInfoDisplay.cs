namespace LuckInfo.Content.InfoDisplays;

using Common.Configs;
using Common.Players;

public sealed class LuckInfoDisplay : InfoDisplay
{
    private static readonly char[] TrimKey = { '{', '}', '$' };

    public static string Format => "F" + LuckConfig.Instance.Decimals;

    // Needed because 'LocalizationLoader.RefreshModLanguage' doesn't handle keys in 'InfoDisplayName'
    protected override string DisplayNameInternal => Language.GetTextValue(base.DisplayNameInternal.Trim(TrimKey));

    public override string DisplayValue()
    {
        return Main.LocalPlayer.luck.ToString(Format, Language.ActiveCulture.CultureInfo);
    }

    public override bool Active()
    {
        return Main.LocalPlayer.GetModPlayer<LuckPlayer>().LuckDisplay;
    }
}
