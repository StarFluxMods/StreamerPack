using KitchenLib;
using System.Reflection;
using UnityEngine;
using System.IO;
using StreamerPack.Cosmetics.Hats;
using StreamerPack.Cosmetics.Outfits;
using System.Linq;
#if BEPINEX
using BepInEx;
#endif
#if WORKSHOP
using KitchenMods;
#endif

namespace StreamerPack
{
#if BEPINEX
	[BepInProcess("PlateUp.exe")]
	[BepInPlugin("streamerpack", "Streamer Outfit Pack", "0.1.0")]
#endif
	public class Main : BaseMod
	{
		public Main() : base("streamerpack", "Streamer Outfit Pack", "StarFluxGames", "0.1.0", "1.1.2", Assembly.GetExecutingAssembly()) { }

		public static AssetBundle bundle;

#if WORKSHOP
		protected override void OnPostActivate(Mod mod)
		{
			bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];
		}
#endif

		protected override void OnInitialise()
		{
#if BEPINEX
			bundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "streamerpack.assets"));
#endif
			AddGameDataObject<SipsOutfit>();
			AddGameDataObject<PedguinOutfit>();
			AddGameDataObject<HafuOutfit>();
			AddGameDataObject<OntaioOutfit>();
			AddGameDataObject<WonktootieOutfit>();
			AddGameDataObject<MissMonicaOutfit>();

			AddGameDataObject<CranchanHat>();
			AddGameDataObject<ItsGNGHat>();
			AddGameDataObject<LemurHat>();
			AddGameDataObject<OntarioHat>();
			AddGameDataObject<PedguinHat>();
			AddGameDataObject<SkootieHat>();
			AddGameDataObject<WonktootieHat>();
			AddGameDataObject<MissMonicaHat>();
		}
	}
}