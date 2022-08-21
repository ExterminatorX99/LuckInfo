namespace LuckInfo.Common.Configs;

public class LocalizedLabelAttribute : LabelAttribute
{
    public LocalizedLabelAttribute(string name)
        : base($"$Mods.LuckInfo.Config.{name}.Label")
    {
    }
}
