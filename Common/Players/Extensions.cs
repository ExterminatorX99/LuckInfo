namespace LuckInfo.Common.Players;

public static class Extensions
{
    public static void ShowLuckDisplay(this Player player)
    {
        player.GetModPlayer<LuckPlayer>().LuckDisplay = true;
    }
}
