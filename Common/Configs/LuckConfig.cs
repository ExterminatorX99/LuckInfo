namespace LuckInfo.Common.Configs;

[Label("$Mods.LuckInfo.Config.Label")]
public sealed class LuckConfig : ModConfig
{
    public static LuckConfig Instance => ModContent.GetInstance<LuckConfig>();

    [LocalizedLabel(nameof(Decimals))]
    [LocalizedTooltip(nameof(Decimals))]
    [DefaultValue(3)]
    [Range(2, 9)]
    public int Decimals;

    public override ConfigScope Mode => ConfigScope.ClientSide;
}
