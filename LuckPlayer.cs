using Terraria.ModLoader;

namespace LuckInfo
{
    internal class LuckPlayer : ModPlayer
    {
        public bool accLuck;

        public override void ResetEffects()
        {
            accLuck = false;
        }
    }
}
