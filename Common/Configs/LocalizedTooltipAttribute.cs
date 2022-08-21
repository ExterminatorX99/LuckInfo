namespace LuckInfo.Common.Configs;

public class LocalizedTooltipAttribute : TooltipAttribute
{
    public LocalizedTooltipAttribute(string name)
        : base($"$Mods.LuckInfo.Config.{name}.Tooltip")
    {
    }
}
