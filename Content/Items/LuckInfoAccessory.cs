using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckInfo.Content.Items
{
    internal class LuckInfoAccessory : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Divines your luck");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(gold: 1);
        }

        public override void UpdateInventory(Player player)
        {
            player.GetModPlayer<LuckPlayer>().accLuck = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
