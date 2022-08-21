namespace LuckInfo.Common.Players;

public sealed class LuckPlayer : ModPlayer
{
    public bool LuckDisplay { get; internal set; }

    public override void ResetEffects()
    {
        LuckDisplay = false;
    }
}
