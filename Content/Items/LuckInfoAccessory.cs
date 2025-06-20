﻿namespace LuckInfo.Content.Items;

using Common.Players;

public sealed class LuckInfoAccessory : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 22;
        Item.height = 20;

        Item.accessory = true;
        Item.maxStack = 1;
        Item.rare = ItemRarityID.Blue;

        Item.value = Item.sellPrice(silver: 20);
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
            .AddIngredient(ItemID.LadyBug)
            .AddIngredient(ItemID.FallenStar, 3)
            .AddRecipeGroup(RecipeGroupID.IronBar, 10)
            .AddTile(TileID.Anvils)
            .Register();
    }
}
