namespace LuckInfo.Content.Items;

using Common.Players;

public sealed class LuckInfoAccessory : ModItem
{
    public override void SetStaticDefaults()
    {
        SacrificeTotal = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 22;
        Item.height = 20;

        Item.accessory = true;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(gold: 1);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.ShowLuckDisplay();
    }

    public override void UpdateEquip(Player player)
    {
        player.ShowLuckDisplay();
    }

    public override void UpdateInventory(Player player)
    {
        player.ShowLuckDisplay();
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemID.DirtBlock, 10)
            .AddTile(TileID.WorkBenches)
            .Register();
    }
}
