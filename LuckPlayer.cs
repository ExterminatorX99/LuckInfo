using Terraria.ModLoader;

namespace LuckInfo
{
    public class LuckPlayer : ModPlayer
    {
        public bool accLuck;

        public override void ResetEffects()
        {
            accLuck = false;
        }
    }
}
