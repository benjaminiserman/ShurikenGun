using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShurikenGun
{
    public class ShurikenAmmo : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Shuriken)
            {
                item.ammo = AmmoID.Bullet;
            }
        }
    }

}