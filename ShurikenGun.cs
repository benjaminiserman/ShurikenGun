using Terraria.ModLoader;

namespace ShurikenGun
{
	class ShurikenGun : Mod
	{
		public ShurikenGun()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
